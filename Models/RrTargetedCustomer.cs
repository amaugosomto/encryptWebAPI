using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RrTargetedCustomer
    {
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferralCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Cif { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public string CurrentStatus { get; set; }
    }
}
