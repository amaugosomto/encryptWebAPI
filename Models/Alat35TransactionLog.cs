using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35TransactionLog
    {
        public long Id { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string DestinationBank { get; set; }
        public string SourceBank { get; set; }
        public int? TransactionStatus { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionReference { get; set; }
        public string Narration { get; set; }
        public string SourceBankCode { get; set; }
        public string DestinationBankCode { get; set; }
        public string Cif { get; set; }
        public long? CustomerProfileId { get; set; }
        public string DestinationAccountName { get; set; }
        public string Currency { get; set; }
        public int? TransactionType { get; set; }
        public string ChannelType { get; set; }
        public string DeviceType { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string C24originalTransactionDatetime { get; set; }
    }
}
