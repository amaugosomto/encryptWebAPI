using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Incentive1
    {
        public string AccountNumber { get; set; }
        public string AcctName { get; set; }
        public string AccountMgrId { get; set; }
        public string AcctMgrName { get; set; }
        public string BranchNo { get; set; }
        public string BranchName { get; set; }
        public string Zone { get; set; }
        public string SchmCode { get; set; }
        public string Product { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public int? Counts { get; set; }
        public decimal? Value { get; set; }
    }
}
