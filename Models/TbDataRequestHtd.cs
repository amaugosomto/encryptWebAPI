using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbDataRequestHtd
    {
        public string AccountNo { get; set; }
        public string AcctName { get; set; }
        public string Currency { get; set; }
        public DateTime? TranDate { get; set; }
        public string TranId { get; set; }
        public string TranSubType { get; set; }
        public string PartTranType { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? TranAmt { get; set; }
        public string TranParticular { get; set; }
    }
}
