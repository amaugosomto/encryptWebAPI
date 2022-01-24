using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class VwPosOnU
    {
        public string RspCodeRsp { get; set; }
        public string ResponseMeaning { get; set; }
        public int? Count { get; set; }
        public decimal? AmountRequested { get; set; }
        public string YearMonth { get; set; }
        public string Type { get; set; }
    }
}
