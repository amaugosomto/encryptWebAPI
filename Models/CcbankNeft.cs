using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CcbankNeft
    {
        public double? NeftId { get; set; }
        public string BranchDesc { get; set; }
        public decimal? CalcAmount { get; set; }
        public string BankDesc { get; set; }
        public DateTime? ProcessingDt { get; set; }
        public string InOut { get; set; }
    }
}
