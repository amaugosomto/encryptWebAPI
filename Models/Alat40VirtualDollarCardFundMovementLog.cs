using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40VirtualDollarCardFundMovementLog
    {
        public int? Id { get; set; }
        public Guid? VirtualCardId { get; set; }
        public int? ActivityLogId { get; set; }
        public decimal? LocalCurrencyAmount { get; set; }
        public decimal? ForeignCurrencyAmount { get; set; }
        public int? RateId { get; set; }
        public string DateRequested { get; set; }
        public string DebitAccount { get; set; }
        public string DebitAccountSchemeCode { get; set; }
        public string CreditAccount { get; set; }
        public string FinacleResponse { get; set; }
        public int? TransactionStatus { get; set; }
        public string ResponseDescription { get; set; }
        public byte? VirtualCardOperation { get; set; }
        public string PaymentReference { get; set; }
        public string OriginalDateTime { get; set; }
        public string PaymentPlatformRef { get; set; }
        public string TransactionStan { get; set; }
        public string UpdatedDate { get; set; }
        public bool? IsReversed { get; set; }
        public decimal? Charge { get; set; }
        public decimal? TotalDebitAmount { get; set; }
    }
}
