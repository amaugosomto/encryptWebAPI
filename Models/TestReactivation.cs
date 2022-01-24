using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TestReactivation
    {
        public Guid? Id { get; set; }
        public string Cif { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateReactivated { get; set; }
        public string FinacleResponse { get; set; }
        public string AccountNumber { get; set; }
        public string DocumentUrl { get; set; }
        public bool? IsDocumentRequired { get; set; }
        public bool? IsAddressRequired { get; set; }
        public string ResidentialAddress { get; set; }
        public bool? IsAccountReactivated { get; set; }
        public int? ReactivationStatus { get; set; }
        public string ChannelId { get; set; }
    }
}
