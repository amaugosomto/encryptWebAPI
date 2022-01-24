using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40RemitaPaymentsTransaction
    {
        public Guid? Id { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
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
        public string VendorAccount { get; set; }
        public string Rrr { get; set; }
        public string PayerEmail { get; set; }
        public string PayerName { get; set; }
        public string PayerNumber { get; set; }
        public string Description { get; set; }
        public string PaymentRef { get; set; }
        public bool? UseServiceBus { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? TransferTransactionStatus { get; set; }
        public string Cif { get; set; }
        public string ReceiptUrl { get; set; }
        public string OriginalDateTime { get; set; }
        public string CallBackUrl { get; set; }
        public string ChannelId { get; set; }
    }
}
