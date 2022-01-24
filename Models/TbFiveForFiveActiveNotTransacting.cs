using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbFiveForFiveActiveNotTransacting
    {
        public string CifId { get; set; }
        public string AcctName { get; set; }
        public string AccountNumber { get; set; }
        public string Band { get; set; }
        public decimal? Balance { get; set; }
        public string AccountStatus { get; set; }
        public string RestrictedStatus { get; set; }
        public string SolId { get; set; }
        public string Branch { get; set; }
        public string Zone { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string Flag { get; set; }
        public DateTime? LastTranDate { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
