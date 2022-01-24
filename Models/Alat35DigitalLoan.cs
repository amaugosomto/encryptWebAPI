using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35DigitalLoan
    {
        public long? Id { get; set; }
        public long? CustomerId { get; set; }
        public decimal? AmountRequested { get; set; }
        public byte? TenureMonths { get; set; }
        public decimal? AmountOffered { get; set; }
        public double? InterestRate { get; set; }
        public byte? Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public decimal? OutStandingAmount { get; set; }
        public decimal? InterestAccrued { get; set; }
        public DateTime? LastInterestExecutionDate { get; set; }
        public string ScheduledPaymentArchive { get; set; }
        public string FailureReason { get; set; }
        public DateTime? NextLoanRepaymentReminderDate { get; set; }
        public decimal? TotalInterestAccrued { get; set; }
        public string CreditAccount { get; set; }
        public string DebitAccount { get; set; }
        public string DebitBankId { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? ScorePercentage { get; set; }
        public string StatusRemarks { get; set; }
        public decimal? MonthlyRepaymentAmount { get; set; }
        public DateTime? StartDate { get; set; }
        public byte? CollectionStatus { get; set; }
        public byte? KycStatus { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LoanAccountNumber { get; set; }
        public bool? IsWorkIdReviewRequired { get; set; }
        public bool? WorkIdValid { get; set; }
        public string StatusName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public string Emailaddress { get; set; }
        public string Address { get; set; }
        public string Employer { get; set; }
    }
}
