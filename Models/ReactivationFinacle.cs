using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ReactivationFinacle
    {
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public DateTime? ReactivatedDate { get; set; }
        public string AcctMgrUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
