using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewClvDatum
    {
        public int Id { get; set; }
        public string CifId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int? UnitBranch { get; set; }
        public int? NoOfAccounts { get; set; }
        public int? Age { get; set; }
        public string AgeGroup { get; set; }
        public string Gender { get; set; }
        public string Staff { get; set; }
        public string MaritalStatus { get; set; }
        public string EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string SubSegment { get; set; }
        public string SegmentationClass { get; set; }
        public int? SouthWest { get; set; }
        public int? Lagos { get; set; }
        public int? Other { get; set; }
        public int? NorthBank { get; set; }
        public int? SouthSouth { get; set; }
        public int? DaysSinceLastTran { get; set; }
        public int? CountOfTranLast90days { get; set; }
        public int? CountOfTranLast180days { get; set; }
        public int? CountOfTranLast365days { get; set; }
        public double? CreditinflowLast90days { get; set; }
        public double? CreditinflowLast180days { get; set; }
        public double? CreditinflowLast365days { get; set; }
        public double? AverageBalance { get; set; }
        public double? Profitability { get; set; }
    }
}
