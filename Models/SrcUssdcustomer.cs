using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class SrcUssdcustomer
    {
        public string CifId { get; set; }
        public string AccountNumber { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNetwork { get; set; }
        public string OnboardingChannels { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string Status { get; set; }
        public string IsDeleted { get; set; }
        public string OnUssd { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
