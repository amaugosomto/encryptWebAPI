using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Ror
    {
        public string CifId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNo { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string ReferralCode { get; set; }
        public string AccountName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime? DateActioned { get; set; }
    }
}
