using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class DigitallendingPrediction
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public decimal? Age { get; set; }
        public string Purpose { get; set; }
        public decimal? Experience { get; set; }
        public decimal? Netincome { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TenorMonth { get; set; }
        public double? Prediction { get; set; }
        public string Classification { get; set; }
        public DateTime? Insertdate { get; set; }
    }
}
