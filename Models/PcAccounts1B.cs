using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class PcAccounts1B
    {
        public int? IssuerNr { get; set; }
        public string AccountId { get; set; }
        public string AccountType { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public string HoldRspCode { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string AccountProduct { get; set; }
        public string ExtendedFields { get; set; }
        public decimal? OverdraftLimit { get; set; }
        public string AccountIdEncrypted { get; set; }
        public string AccountNickname { get; set; }
        public int? Vip { get; set; }
        public DateTime? VipLapseDate { get; set; }
        public string CompanyName { get; set; }
    }
}
