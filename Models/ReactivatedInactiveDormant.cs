using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ReactivatedInactiveDormant
    {
        public int? Reactivated { get; set; }
        public int? Dormant { get; set; }
        public int? Inactive { get; set; }
        public string SolDesc { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
