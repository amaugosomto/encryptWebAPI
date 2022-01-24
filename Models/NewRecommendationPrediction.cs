using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewRecommendationPrediction
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public decimal? UniqueBranch { get; set; }
        public decimal? NoOfAccounts { get; set; }
        public decimal? Age { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
        public double? AlatUser { get; set; }
        public double? AlatGoals { get; set; }
        public double? Ussd { get; set; }
        public double? Cards { get; set; }
        public double? CreditCardAccount { get; set; }
        public double? CurrentAccount { get; set; }
        public double? SavingsAccount { get; set; }
        public double? BusinessAccount { get; set; }
        public double? DomicillaryAccount { get; set; }
        public double? TermDeposit { get; set; }
        public double? Loan { get; set; }
        public double? Mortgage { get; set; }
        public double? HcmLoan { get; set; }
        public double? WemaTreasure { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
