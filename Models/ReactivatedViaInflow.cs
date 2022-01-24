using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ReactivatedViaInflow
    {
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public decimal? Balance { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public DateTime? DateReactivatd { get; set; }
        public string AcctMgrUserId { get; set; }
        public string Descr { get; set; }
        public string Restricted { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
