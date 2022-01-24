using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class SmtCamStaged
    {
        public string Acid { get; set; }
        public string AcctStatus { get; set; }
        public DateTime? AcctStatusDate { get; set; }
        public string PrevAcctStatus { get; set; }
        public string Source { get; set; }
    }
}
