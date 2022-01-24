using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class IncentiveReactivated
    {
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public decimal? ClrBalAmt { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public string AcctMgrUserId { get; set; }
        public string AccountMangerName { get; set; }
        public string SolId { get; set; }
        public string BranchName { get; set; }
        public string Region { get; set; }
        public string AcctMgrGroup { get; set; }
    }
}
