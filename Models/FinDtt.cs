using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class FinDtt
    {
        public string Acid { get; set; }
        public string TranId { get; set; }
        public decimal? TranAmt { get; set; }
        public string PartTranSrlNum { get; set; }
        public DateTime? TranDate { get; set; }
        public string DelFlg { get; set; }
        public string FlowCode { get; set; }
        public string PartTranType { get; set; }
        public DateTime? ValueDate { get; set; }
        public string TranParticulars { get; set; }
    }
}
