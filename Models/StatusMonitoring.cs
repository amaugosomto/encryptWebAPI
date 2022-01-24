using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class StatusMonitoring
    {
        public int? ActiveBankwide { get; set; }
        public int? InactiveBankwide { get; set; }
        public int? DormantBankwide { get; set; }
        public decimal? Active { get; set; }
        public decimal? Inactive { get; set; }
        public decimal? Dormant { get; set; }
        public int? ActiveAlat { get; set; }
        public int? InactiveAlat { get; set; }
        public int? RestrictedAlat { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
