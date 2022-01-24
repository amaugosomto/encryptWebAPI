using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40SettlementTransactionLog
    {
        public int? TransactionType { get; set; }
        public int? TransactionStatus { get; set; }
        public decimal? Amount { get; set; }
        public string SettlementTransactionResponse { get; set; }
        public string TransactionStan { get; set; }
        public string PlatformReference { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Narration { get; set; }
        public string SettlementTransactionStan { get; set; }
        public string ClientReference { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string SourceAccountNumber { get; set; }
        public string TransferPurpose { get; set; }
        public int? DigitalBankControllerSelector { get; set; }
        public string ChannelId { get; set; }
    }
}
