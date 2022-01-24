using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Segmentation
    {
        public string CifId { get; set; }
        public string SolId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string Gender { get; set; }
        public string AgeGrp { get; set; }
        public string Phoneno { get; set; }
        public string Email { get; set; }
        public string AccountStatus { get; set; }
        public double? Tcount { get; set; }
        public double? TotalDr { get; set; }
        public double? TotalCr { get; set; }
    }
}
