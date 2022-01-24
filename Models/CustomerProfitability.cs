using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CustomerProfitability
    {
        public string Acid { get; set; }
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public double? AverageBal { get; set; }
        public double? IntExp { get; set; }
        public double? Float { get; set; }
        public double? IncomeOnLr { get; set; }
        public double? Profitability { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
