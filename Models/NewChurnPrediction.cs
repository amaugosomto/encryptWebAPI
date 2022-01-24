using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewChurnPrediction
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string SolId { get; set; }
        public string Acid { get; set; }
        public string Foracid { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public double? CuurentBalance { get; set; }
        public string SchmCode { get; set; }
        public string Gender { get; set; }
        public decimal? Age { get; set; }
        public string AgeGroup { get; set; }
        public decimal? Tenor { get; set; }
        public DateTime? AcctOpenDate { get; set; }
        public decimal? DaysSinceLastTran { get; set; }
        public DateTime? LastTranDate { get; set; }
        public decimal? CrTranCntIn180Days { get; set; }
        public decimal? DrTranCntIn180Days { get; set; }
        public string AccountStatus { get; set; }
        public string IsAlatNumber { get; set; }
        public int? IsBvnSupplied { get; set; }
        public double? Prediction { get; set; }
        public string Segment { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
