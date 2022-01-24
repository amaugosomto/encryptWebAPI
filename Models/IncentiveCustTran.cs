using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class IncentiveCustTran
    {
        public string Foracid { get; set; }
        public int? TotalCount { get; set; }
        public decimal? TotalValue { get; set; }
        public int? NipCount { get; set; }
        public decimal? NipValue { get; set; }
        public int? BillCount { get; set; }
        public decimal? BillValue { get; set; }
        public int? AirtimeCount { get; set; }
        public decimal? AirtimeValue { get; set; }
        public int? DataCount { get; set; }
        public decimal? DataValue { get; set; }
    }
}
