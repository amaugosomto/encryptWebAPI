using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ConsolidatedCard
    {
        public string AccountNumber { get; set; }
        public DateTime? DateIssued { get; set; }
        public string ProductName { get; set; }
        public string CifId { get; set; }
        public string AcctName { get; set; }
        public decimal? Balance { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public string AcctMgrUserId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime? DateActivated { get; set; }
    }
}
