using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RrNoTran
    {
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public DateTime? LastTranDate { get; set; }
    }
}
