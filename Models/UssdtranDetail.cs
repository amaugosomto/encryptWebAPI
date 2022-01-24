using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class UssdtranDetail
    {
        public long? Id { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string IncomeAccountNumber { get; set; }
        public string SuspenseAccountNumber { get; set; }
        public string DestinationBank { get; set; }
        public string SourceBank { get; set; }
        public int? TransactionStatus { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string TransactionReference { get; set; }
        public string TransactionDescription { get; set; }
        public string Narration { get; set; }
        public decimal? TransactionFee { get; set; }
        public string SourceBankCode { get; set; }
        public string DestinationBankCode { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public int? TransactionType { get; set; }
        public string Channel { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public int? AuthType { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UniqueIdentifier { get; set; }
        public string Vendor { get; set; }
    }
}
