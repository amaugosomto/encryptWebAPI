using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class SolTran
    {
        public string SolId { get; set; }
        public double? Tcount { get; set; }
        public double? SumAmt { get; set; }
    }
}
