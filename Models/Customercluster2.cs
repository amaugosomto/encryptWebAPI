using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Customercluster2
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public string Cif { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationBank { get; set; }
        public string DestinationAccountNumber { get; set; }
        public int? Tcount { get; set; }
        public decimal? SumAmount { get; set; }
        public decimal? TotalTransactionVolume { get; set; }
    }
}
