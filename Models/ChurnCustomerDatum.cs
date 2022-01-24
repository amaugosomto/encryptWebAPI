using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class ChurnCustomerDatum
    {
        public long? RowNum { get; set; }
        public string CifId { get; set; }
        public string SolId { get; set; }
        public string Acid { get; set; }
        public string Foracid { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public decimal? Currentbal { get; set; }
        public string SchmCode { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string AgeGrp { get; set; }
        public int? AcctYear { get; set; }
        public int? Tenor { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public int? DaySinceLastTran { get; set; }
        public DateTime? LastTranDate { get; set; }
        public int? CrTranCnt { get; set; }
        public int? DrTranCnt { get; set; }
        public string AccountStatus { get; set; }
        public int IsAlatCustomer { get; set; }
        public int IsBvnSupplied { get; set; }
        public int? AccountPerCustomer { get; set; }
        public int Label { get; set; }
    }
}
