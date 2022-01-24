using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40ReactivationRequest
    {
        public Guid? Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string AccountNumber { get; set; }
        public string AccountSchemeCode { get; set; }
        public string AccountName { get; set; }
        public string Cif { get; set; }
        public string AccountStatus { get; set; }
        public string DocumentUrl { get; set; }
        public Guid? ReactivationId { get; set; }
        public string ResidentialAddress { get; set; }
        public bool? HasChangedResidentialAddress { get; set; }
        public string RequestStatus { get; set; }
    }
}
