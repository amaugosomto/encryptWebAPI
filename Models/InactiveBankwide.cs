using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class InactiveBankwide
    {
        public string AcctName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountStatus { get; set; }
        public string RestrictedStatus { get; set; }
        public string Flag { get; set; }
        public string StatusDuration { get; set; }
        public DateTime? RunDate { get; set; }
        public string Email { get; set; }
    }
}
