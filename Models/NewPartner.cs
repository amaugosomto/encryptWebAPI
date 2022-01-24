using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewPartner
    {
        public DateTime? TranDate { get; set; }
        public string AcctName { get; set; }
        public string PartTranType { get; set; }
        public decimal? TranAmt { get; set; }
    }
}
