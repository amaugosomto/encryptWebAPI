using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewTbWebAppCustomerCluster
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public string Cif { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationBank { get; set; }
        public string DesitnationAccountNumber { get; set; }
        public int? TransactionCount { get; set; }
        public double? SumAmmount { get; set; }
        public double? TotalTransactionVolume { get; set; }
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public string CustFisrtName { get; set; }
        public string CustLastName { get; set; }
        public string SolId { get; set; }
        public string Region { get; set; }
        public string Zone { get; set; }
        public string SolDesc { get; set; }
        public string Orgkey { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
