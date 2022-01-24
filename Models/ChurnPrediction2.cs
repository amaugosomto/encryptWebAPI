using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ChurnPrediction2
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string SolId { get; set; }
        public string Foracid { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string Gender { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public decimal? Tenor { get; set; }
        public DateTime? LastTranDate { get; set; }
        public decimal? Age { get; set; }
        public decimal? CurrentBalance { get; set; }
        public string Status { get; set; }
        public double? Prediction { get; set; }
        public string Segment { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
