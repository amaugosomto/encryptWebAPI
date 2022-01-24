using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ClvDatum
    {
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int? UniqueBranch { get; set; }
        public int? NoOfAccts { get; set; }
        public int? Age { get; set; }
        public string AgeGrp { get; set; }
        public string Gender { get; set; }
        public string Staff { get; set; }
        public string MaritalStatus { get; set; }
        public string EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Subsegment { get; set; }
        public string SegmentationClass { get; set; }
        public int? SouthWest { get; set; }
        public int? Lagos { get; set; }
        public int? Others { get; set; }
        public int? NorthBank { get; set; }
        public int? SouthSouth { get; set; }
        public int? DaysSinceLastTran { get; set; }
        public int? CountOfTranLast90days { get; set; }
        public int? CountOfTranLast180days { get; set; }
        public int? CountOfTranLast365days { get; set; }
        public decimal? CreditinflowLast90days { get; set; }
        public decimal? CreditinflowLast180days { get; set; }
        public decimal? CreditinflowLast365days { get; set; }
        public double? AvgBal { get; set; }
        public double? Proitability { get; set; }
    }
}
