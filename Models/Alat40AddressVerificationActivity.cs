using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40AddressVerificationActivity
    {
        public Guid? ActivityId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? ResidentialAddressId { get; set; }
        public string VendorId { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? VerificationStatus { get; set; }
        public DateTime? DateVerified { get; set; }
        public string RejectionReasons { get; set; }
    }
}
