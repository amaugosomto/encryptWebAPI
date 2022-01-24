using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TestRor
    {
        public string CifId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Accountno { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string Referralcode { get; set; }
        public string Accountname { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime? Reactivationdate { get; set; }
    }
}
