using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class StampDutyTranDet
    {
        public string Acid { get; set; }
        public string Foracid { get; set; }
        public DateTime? TranDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string TranId { get; set; }
        public decimal? PrincipalAmt { get; set; }
        public string SolId { get; set; }
        public string PartTranSrlNum { get; set; }
        public string ProcessedFlg { get; set; }
    }
}
