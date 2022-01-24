using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TransactingBranch5f5
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string SolId { get; set; }
        public string Branch { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
        public int? TotalTranCount { get; set; }
        public decimal? Value { get; set; }
        public int? Customer { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
