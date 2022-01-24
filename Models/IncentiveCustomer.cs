using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class IncentiveCustomer
    {
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string AcctMgrUserId { get; set; }
        public string AcctMgrGroup { get; set; }
        public string EmpName { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public decimal? ClrBalAmt { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string BranchNo { get; set; }
        public string BranchName { get; set; }
    }
}
