using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40ReactivationActivity
    {
        public Guid? ActivityId { get; set; }
        public Guid? CustomerId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ApproverId { get; set; }
        public int? ApproverStatus { get; set; }
        public DateTime? ApproverTreatedDate { get; set; }
        public string VerifierId { get; set; }
        public int? VerifierStatus { get; set; }
        public DateTime? VerifierTreatedDate { get; set; }
        public string Cif { get; set; }
    }
}
