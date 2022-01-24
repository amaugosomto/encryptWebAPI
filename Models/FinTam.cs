using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class FinTam
    {
        public string Acid { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? DepositPeriodDays { get; set; }
        public decimal? MaturityAmount { get; set; }
        public string RepaymentAcid { get; set; }
    }
}
