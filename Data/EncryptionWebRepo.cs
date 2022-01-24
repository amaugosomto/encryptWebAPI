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
            return accountids;
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
