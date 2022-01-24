using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ClvPrediction
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public decimal? NoOfAccounts { get; set; }
        public decimal? Age { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public double? AvgBalance { get; set; }
        public double? Profitability { get; set; }
        public double? Prediction { get; set; }
        public decimal? Clusters { get; set; }
        public string ClvStatus { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
