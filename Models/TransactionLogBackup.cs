using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TransactionLogBackup
    {
        public string Cif { get; set; }
        public string SchemeCode { get; set; }
        public decimal? Amount { get; set; }
        public string SourceAccountName { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string DestinationBankName { get; set; }
        public string DestinationBankCode { get; set; }
        public string TransactionType { get; set; }
        public string Narration { get; set; }
        public int? TransactionStatus { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Remarks { get; set; }
        public string ChannelId { get; set; }
        public string Currency { get; set; }
        public int? AuthenticationType { get; set; }
        public bool? IsAuthenticated { get; set; }
        public bool? IsTransferLimitExceeded { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
