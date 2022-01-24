using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class AlatTran
    {
        public string CifId { get; set; }
        public double? SumTcnt { get; set; }
        public double? SumTamt { get; set; }
    }
}
