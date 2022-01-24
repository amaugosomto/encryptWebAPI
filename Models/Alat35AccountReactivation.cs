using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35AccountReactivation
    {
        public int? Id { get; set; }
        public long? CustomerId { get; set; }
        public string AccountsToReactivate { get; set; }
        public bool? ImageUploaded { get; set; }
        public int? AccountReactivationStatusId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public bool? IsTierOne { get; set; }
        public bool? IsTierOneReactivated { get; set; }
        public string ReactivationResponseMessage { get; set; }
        public bool? IsAddressChanged { get; set; }
    }
}
