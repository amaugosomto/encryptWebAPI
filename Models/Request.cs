using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Request
    {
        public string Bvn { get; set; }
        public DateTime? Dob { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string RelationshipManager { get; set; }
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public string Phoneno { get; set; }
        public string Email { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public DateTime? LastTranDate { get; set; }
        public string Oct { get; set; }
        public double? OctCrTurnover { get; set; }
    }
}
