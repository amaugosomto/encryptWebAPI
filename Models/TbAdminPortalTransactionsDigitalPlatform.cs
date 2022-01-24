using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbAdminPortalTransactionsDigitalPlatform
    {
        public string Months { get; set; }
        public int? Years { get; set; }
        public int? Volume { get; set; }
        public decimal? Value { get; set; }
        public string Platform { get; set; }
    }
}
