using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class AnalyticsUser
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Department { get; set; }
        public DateTime? ProfiledDate { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsApproved { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsRegionalHead { get; set; }
        public bool? SentProfiledMail { get; set; }
    }
}
