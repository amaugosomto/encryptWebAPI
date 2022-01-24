using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40BillsPayment
    {
        public Guid Id { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerIdentifier { get; set; }
        public string CustomerName { get; set; }
        public decimal? TransAmount { get; set; }
        public decimal? Charge { get; set; }
        public string AccountNumber { get; set; }
        public string Narration { get; set; }
        public string ClientTransactionRef { get; set; }
        public int? AuthenticationType { get; set; }
        public int? TransactionStatus { get; set; }
        public string TransactionMessage { get; set; }
        public string ReferenceCode { get; set; }
        public string TransferReference { get; set; }
        public string TransactionStan { get; set; }
        public int? PackageId { get; set; }
        public bool? UseServiceBus { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsRecurring { get; set; }
        public string ValidationInfo { get; set; }
        public string Vendor { get; set; }
        public string VendorAccount { get; set; }
        public int? TransferTransactionStatus { get; set; }
        public string Cif { get; set; }
        public string BillerName { get; set; }
        public string PackageName { get; set; }
        public string Value { get; set; }
        public int? ValueType { get; set; }
        public string OriginalDateTime { get; set; }
        public int? Trials { get; set; }
        public string CallBackUrl { get; set; }
        public string ChannelId { get; set; }
        public string GlobalAccount { get; set; }
    }
}
