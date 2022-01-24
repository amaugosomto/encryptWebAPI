using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class PcCardAccounts1A
    {
        public int? IssuerNr { get; set; }
        public string Pan { get; set; }
        public string SeqNr { get; set; }
        public string AccountId { get; set; }
        public string AccountTypeNominated { get; set; }
        public int? AccountTypeQualifier { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public string AccountType { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
