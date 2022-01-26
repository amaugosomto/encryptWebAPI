using EncryptionWebAPI.DTO;
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
        Task<bool> DecryptAllData();
        Task<bool> SaveAllData(List<PcAccounts1BDTO> model);
    }
}
