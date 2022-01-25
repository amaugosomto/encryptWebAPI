using EncryptionWebAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.DirectoryServices;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using EncryptionWebAPI.DTO;
using System.Text.Json;

namespace EncryptionWebAPI.Data
{
    public class EncryptionWebRepo : IEncryptionWebRepo
    {
        private IDbConnection db;

        //private readonly Utility utility = new Utility();
        private readonly DataAnalyticsContext context;

        public EncryptionWebRepo(IConfiguration config, DataAnalyticsContext context)
        {
            this.db = new SqlConnection(config.GetConnectionString("Connection"));
            this.context = context;
        }

        public async Task<IEnumerable<SaleZonesRegion>> GetAllSaleZone()
        {
            var sales = await context.SaleZonesRegions.ToListAsync();

            return sales;
        }

        public async Task<IEnumerable<PcAccounts1B>> DecryptAllData()
        {
            var accountids = await context.PcAccounts1Bs.ToListAsync();
            var decrypedData = await GetDecryptedData(accountids);
            await SaveAllData(decrypedData);
            return accountids;
        }

        private async Task<List<PcAccounts1B>> GetDecryptedData(List<PcAccounts1B> data)
        {
            var username = "postcard_encrypt";
            var password = "Wema@1234";
            var url = "http://172.52.12.23:5050/cms/api/v2/crypto/encrypt-decrypt?operation=2";

            using var client = new HttpClient();
            var authToken = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

            foreach (var dat in data)
            {

                var dataToSend = new DataToSendDTO
                {
                    key1_enc = dat.AccountIdEncrypted
                };
                var toSend = JsonSerializer.Serialize(dataToSend);
                var requestContent = new StringContent(toSend, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, requestContent);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var decryptedContent = JsonSerializer.Deserialize<dynamic>(content);

                dat.AccountIdEncrypted = decryptedContent.key1_enc_dec;
            }

            return data;
        }

        public async Task<Boolean> SaveAllData(List<PcAccounts1B> model)
        {
            try
            {
                foreach (var item in model)
                {
                    var pcAccount = await context.PcAccounts1Bs.SingleOrDefaultAsync(x => x.AccountId == item.AccountId);
                    if (pcAccount != null)
                    {
                        pcAccount.AccountIdEncrypted = item.AccountIdEncrypted;
                        await context.SaveChangesAsync();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {

                return true;
            }

        }
    }
}
