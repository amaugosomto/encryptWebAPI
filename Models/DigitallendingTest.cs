using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class DigitallendingTest
    {
        public string Cif { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public double? LoanPurpose { get; set; }
        public double? Gender { get; set; }
        public int? TenorMonth { get; set; }
        public int? Experience { get; set; }
        public double? Amountrequested { get; set; }
        public double? MaritalStatus { get; set; }
        public double? Netincome { get; set; }
    }
}
