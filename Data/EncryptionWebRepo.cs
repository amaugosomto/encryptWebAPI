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
using System.Reflection;

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

        public async Task<bool> DecryptAllData()
        {
            var total = await context.PcAccounts1Bs.CountAsync();
            List<PcAccounts1BDTO> pcAccounts1Bs = new List<PcAccounts1BDTO>();
            List<PcAccounts1BDTO> decryptedData = new List<PcAccounts1BDTO>();
            var maxNum = 20000.0;

            if (total < (int)maxNum)
            {
               pcAccounts1Bs = await context.PcAccounts1Bs.Select(x => new PcAccounts1BDTO(){ 
                    AccountId = x.AccountId,
                    AccountIdEncrypted =  x.AccountIdEncrypted
               }).ToListAsync();

                decryptedData = await GetDecryptedData(pcAccounts1Bs);
                await SaveAllData(decryptedData);
            }
            else
            {
                var loopTotal = total % maxNum != 0 ? Math.Floor(total / maxNum) + 1 : total / maxNum;
                var loopGotten = 0;

                for (int i = 0; i < loopTotal; i++)
                {
                    pcAccounts1Bs = await context.PcAccounts1Bs.Select(x => new PcAccounts1BDTO()
                    {
                        AccountId = x.AccountId,
                        AccountIdEncrypted = x.AccountIdEncrypted
                    }).Skip(loopGotten).Take((int)maxNum).ToListAsync();

                    loopGotten += pcAccounts1Bs.Count;

                    decryptedData = await GetDecryptedData(pcAccounts1Bs);
                    await SaveAllData(decryptedData);
                }
            }

            return true;
        }

        private async Task<List<PcAccounts1BDTO>> GetDecryptedData(List<PcAccounts1BDTO> data)
        {
            var username = "postcard_encrypt";
            var password = "Wema@1234";
            var url = "http://172.52.12.23:5050/cms/api/v2/crypto/encrypt-decrypt?operation=2";

            using var client = new HttpClient();
            var authToken = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

            List<PcAccounts1BDTO> decryptedData = new List<PcAccounts1BDTO>();
            dynamic expandoObject = new ExpandoObject();
            Dictionary<string, string> dataToSend = new Dictionary<string, string>();

            foreach (var item in data)
            {
                dataToSend.Add($"key_{item.AccountId}_enc", item.AccountIdEncrypted);
            }

            try
            {
                var toSend = JsonSerializer.Serialize(dataToSend);
                var requestContent = new StringContent(toSend, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, requestContent);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var decryptedContent = JsonSerializer.Deserialize<Dictionary<string, string>>(content);

                PcAccounts1BDTO userToEdit = new PcAccounts1BDTO();
                foreach (var item in decryptedContent)
                {
                    var userID = item.Key.Split('_')[1];
                    userToEdit = data.Find(x => x.AccountId == userID);
                    userToEdit.AccountIdEncrypted = item.Value;
                }

                decryptedData.Add(userToEdit);
            }
            catch (Exception ex)
            {
                return decryptedData;
            }

            return data;
        }

        public async Task<Boolean> SaveAllData(List<PcAccounts1BDTO> model)
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
