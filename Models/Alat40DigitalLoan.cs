using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40DigitalLoan
    {
        public Guid? Id { get; set; }
        public Guid? CustomerId { get; set; }
        public string LoanType { get; set; }
        public string IncomeCheckRequestId { get; set; }
        public decimal? AmountRequested { get; set; }
        public decimal? CreditCheckInstallmentAmount { get; set; }
        public byte? LoanTenorInMonths { get; set; }
        public decimal? MonthlyRepaymentAmount { get; set; }
        public double? InterestRate { get; set; }
        public byte? Status { get; set; }
        public string CreatedDate { get; set; }
        public string LastUpdated { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public byte? ScoreCardPercentage { get; set; }
        public byte? CollectionStatus { get; set; }
        public byte? KycStatus { get; set; }
        public decimal? AmountOffered { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public string LoanAccountNumber { get; set; }
        public string DebitBankId { get; set; }
        public string DebitBankName { get; set; }
        public string StatusRemarks { get; set; }
        public string FailureReason { get; set; }
        public decimal? AverageMonthlySalary { get; set; }
        public decimal? TotalInterestAccrued { get; set; }
        public string RemitaTransRef { get; set; }
        public string MandateId { get; set; }
        public string CollectonId { get; set; }
        public string CollectonProvider { get; set; }
        public string CollectonData { get; set; }
        public string CustomerRemitaId { get; set; }
        public string RemitaAuthorizationCode { get; set; }
        public string TermsAndConditionVersion { get; set; }
        public Guid? PlatformRequestId { get; set; }
        public bool? WorkIdReview { get; set; }
        public string RemitaBankAccountNumber { get; set; }
        public string RemitaBankCode { get; set; }
        public bool? Gsiacceptance { get; set; }
        public bool? TermsAndConditionAcceptance { get; set; }
        public string TermsAndConditionAcceptedDate { get; set; }
        public string EmployerName { get; set; }
        public bool? LoanActivated { get; set; }
        public decimal? AverageMonthlyIncome { get; set; }
        public string StatusName { get; set; }
    }
}
