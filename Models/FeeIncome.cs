using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class FeeIncome
    {
        public string Acid { get; set; }
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public decimal? FeeIncome1 { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
