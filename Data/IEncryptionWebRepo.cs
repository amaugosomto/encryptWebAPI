using EncryptionWebAPI.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptionWebAPI.Data
{
    public interface IEncryptionWebRepo
    {
        Task<IEnumerable<SaleZonesRegion>> GetAllSaleZone();
        Task<IEnumerable<PcAccounts1B>> DecryptAllData();
        Task<Boolean> SaveAllData(List<PcAccounts1B> model);
    }
}
