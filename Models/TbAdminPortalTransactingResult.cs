using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbAdminPortalTransactingResult
    {
        public DateTime? TranDate { get; set; }
        public string PartTranType { get; set; }
        public string AcctName { get; set; }
        public int? Volume { get; set; }
        public decimal? Value { get; set; }
    }
}
