using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RevPayEbill
    {
        public DateTime? TranDate { get; set; }
        public int? UniqueCustomers { get; set; }
        public int? TransactionCount { get; set; }
        public decimal? Income { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Report { get; set; }
    }
}
