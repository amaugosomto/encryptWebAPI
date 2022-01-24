using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CardableActive
    {
        public int? CardedActiveAccounts { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string Zones { get; set; }
        public string Region { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
