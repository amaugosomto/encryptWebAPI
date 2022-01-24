using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35Account
    {
        public int Id { get; set; }
        public long? CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime? DateRequested { get; set; }
        public string SchemeType { get; set; }
        public string SchemeCode { get; set; }
        public string GlsubHeadCode { get; set; }
        public string Currency { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string AccountType { get; set; }
        public string ApplyPndstatus { get; set; }
        public bool? AccountIsFunded { get; set; }
        public int? QualifiedForRemapped { get; set; }
        public int? ReMappedStatus { get; set; }
        public DateTime? DateRemmapped { get; set; }
        public bool? AccountRemapped { get; set; }
    }
}
