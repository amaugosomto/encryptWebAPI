using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40LoanManagement
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Cif { get; set; }
        public int? LoanTenor { get; set; }
        public double? LoanRate { get; set; }
        public double? LoanAmount { get; set; }
        public string AlatAccountNumber { get; set; }
        public DateTime? InstallmentStartDate { get; set; }
        public string LoanType { get; set; }
        public string ChannelId { get; set; }
        public string LoanAccountNumber { get; set; }
        public bool? PassCreateLoanValidation { get; set; }
        public bool? PassDisburseLoanValidation { get; set; }
        public bool? LoanAccountCreated { get; set; }
        public bool? LoanDisbursed { get; set; }
        public string Notes { get; set; }
        public decimal? EquityAmount { get; set; }
        public string CallBackRequestId { get; set; }
        public bool? CallBackRequired { get; set; }
        public string EquityDebitAccount { get; set; }
        public bool? KycCompleted { get; set; }
        public int? LoanProcessingStatusId { get; set; }
        public int? LoanTypeId { get; set; }
        public int? ProcessingRetryCount { get; set; }
        public bool? EquityPaymentProcessed { get; set; }
        public string WemaSalaryAccount { get; set; }
        public bool? WorkIdReviewRequired { get; set; }
        public string DeviceLoanReferenceId { get; set; }
        public string AccountNumberCredited { get; set; }
        public double? Charges { get; set; }
        public bool? IsChargeDebited { get; set; }
        public bool? IsIndicina { get; set; }
        public bool? IsSentToIndicina { get; set; }
    }
}
