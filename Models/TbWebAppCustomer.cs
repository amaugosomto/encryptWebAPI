using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbWebAppCustomer
    {
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public decimal? NoOfAccounts { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
        public string Alat { get; set; }
        public string Ussd { get; set; }
        public string Cards { get; set; }
        public string AlatGoals { get; set; }
        public string CreditCardAccount { get; set; }
        public string CurrentAccount { get; set; }
        public string SavingsAccount { get; set; }
        public string DomicillaryAccount { get; set; }
        public string TermDeposit { get; set; }
        public string Loan { get; set; }
        public string Mortgage { get; set; }
        public string HcmLoan { get; set; }
        public string WemaTreasure { get; set; }
        public string BusinessAccount { get; set; }
        public string Orgkey { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string CurrentProducts { get; set; }
        public string SolId { get; set; }
        public string AlatGoalBasedLoan { get; set; }
        public string Segmentation { get; set; }
        public string ClvStatus { get; set; }
        public string ChurnStatus { get; set; }
    }
}
