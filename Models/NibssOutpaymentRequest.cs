using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NibssOutpaymentRequest
    {
        public long? Id { get; set; }
        public long? TransactionUid { get; set; }
        public string RequestId { get; set; }
        public string BatchId { get; set; }
        public string ChannelRequestBatchId { get; set; }
        public string PayerBankCode { get; set; }
        public string PayerName { get; set; }
        public string PayerAccountNumber { get; set; }
        public string PayerAddress { get; set; }
        public string BenNarration { get; set; }
        public string BenBankSortCode { get; set; }
        public string BenAccountNumber { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public double? BenAmount { get; set; }
        public string BatchStatus { get; set; }
        public string TxnStatus { get; set; }
        public string ReversalStatus { get; set; }
        public string ReversalTranId { get; set; }
        public string Currency { get; set; }
        public string ErpIntegratorRequestId { get; set; }
        public bool? IsBatchProcessed { get; set; }
        public DateTime? DateCreated { get; set; }
        public string PayerLocation { get; set; }
        public string NapsPaymentReference { get; set; }
        public string StatusDetails { get; set; }
        public string SessionId { get; set; }
        public string Stan { get; set; }
        public string OriginalTxnDateTime { get; set; }
        public string BranchCode { get; set; }
    }
}
