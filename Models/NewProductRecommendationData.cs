using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewProductRecommendationData
    {
        public int? RowNum { get; set; }
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int? UniqueBranch { get; set; }
        public int? NoOfAccount { get; set; }
        public double? Age { get; set; }
        public string AgeGrp { get; set; }
        public string Gender { get; set; }
        public int? SouthWest { get; set; }
        public int? Lagos { get; set; }
        public int? Others { get; set; }
        public int? NorthBank { get; set; }
        public int? SouthSouth { get; set; }
        public string CustomerType { get; set; }
        public string MaritalStatus { get; set; }
        public string EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string SubSegment { get; set; }
        public int? AlatUsers { get; set; }
        public int? AlatGoals { get; set; }
        public int? Ussd { get; set; }
        public int? Cards { get; set; }
        public int? CreditCardAccount { get; set; }
        public int? CurrentAccount { get; set; }
        public int? SavingsAccount { get; set; }
        public int? BusinessAccount { get; set; }
        public int? DomiciliaryAccount { get; set; }
        public int? TermDepost { get; set; }
        public int? Loan { get; set; }
        public int? Mortgage { get; set; }
        public int? HcmLoan { get; set; }
        public int? WemaTreasure { get; set; }
    }
}
