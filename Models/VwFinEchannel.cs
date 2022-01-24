using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class VwFinEchannel
    {
        public string Typez { get; set; }
        public int? Volume { get; set; }
        public decimal? TranAmt { get; set; }
        public string SolDesc { get; set; }
        public string YearMonth { get; set; }
        public int? MonthNo { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
    }
}
