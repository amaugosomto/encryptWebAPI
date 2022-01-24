using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40Datum
    {
        public Guid? Id { get; set; }
        public string ClientTransactionReference { get; set; }
        public string TransactionReference { get; set; }
        public string DebitAccountNumberValue { get; set; }
        public string Otp { get; set; }
        public string BiometricToken { get; set; }
        public string BiometricPolicy { get; set; }
        public string CreditAccount { get; set; }
        public bool? DataRequestStatus { get; set; }
        public int? PackageId { get; set; }
        public int? VendorId { get; set; }
        public string PhoneNumberValue { get; set; }
        public int? AuthenticationType { get; set; }
        public bool? AirtimeRequestStatus { get; set; }
        public decimal? Amount { get; set; }
        public string DateTimeCreated { get; set; }
        public string ResponseStatus { get; set; }
        public string Narration { get; set; }
        public string ResponseMessage { get; set; }
        public string TransactionStan { get; set; }
        public string TransferReference { get; set; }
        public string TransferNarration { get; set; }
        public bool? IsRecurringServices { get; set; }
        public Guid? RecurringTransactionId { get; set; }
        public int? TrialCount { get; set; }
        public string ChannelId { get; set; }
        public string CallBackUrl { get; set; }
        public string ProcessingStage { get; set; }
    }
}
