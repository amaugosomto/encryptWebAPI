using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NullValue
    {
        public string CifId { get; set; }
        public string Acid { get; set; }
        public int? CountOfTranLast90days { get; set; }
        public decimal? CreditInflowLast90days { get; set; }
        public int? CountOfTranLast180days { get; set; }
        public decimal? CreditInflowLast180days { get; set; }
        public int? CountOfTranLastDay365days { get; set; }
        public decimal? CreditInflowLast265days { get; set; }
        public int? CountOfDrTranLast90days { get; set; }
        public decimal? DebitOutflowLast90days { get; set; }
        public int? CountOfDrTranLast180days { get; set; }
        public decimal? DebitOutflowLast180days { get; set; }
    }
}
