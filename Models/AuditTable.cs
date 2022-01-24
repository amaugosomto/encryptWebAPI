using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class AuditTable
    {
        public string RefNum { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public string AuditSolId { get; set; }
        public string Acid { get; set; }
        public string GlSubHeadCode { get; set; }
        public string AuthId { get; set; }
        public string Rmks { get; set; }
        public DateTime? AuditDate { get; set; }
        public string ModifiedFieldsData { get; set; }
        public string FuncCode { get; set; }
        public string InitSolId { get; set; }
        public DateTime? AuthDate { get; set; }
    }
}
