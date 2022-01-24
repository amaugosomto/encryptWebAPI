using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class MasterData2
    {
        public long? RowNum { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string CifId { get; set; }
        public string Acid { get; set; }
        public string Foracid { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public decimal? CurrentBal { get; set; }
        public DateTime? LastTranDate { get; set; }
        public string AccountStatus { get; set; }
        public string CustFirstName { get; set; }
        public string CustMiddleName { get; set; }
        public string CustLastName { get; set; }
        public int? BirthYear { get; set; }
        public string AgeGrp { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string EmploymentStatus { get; set; }
        public string Staffflag { get; set; }
        public string Occupation { get; set; }
        public string MaritalStatus { get; set; }
        public string Bvn { get; set; }
        public string HasCards { get; set; }
        public string AlatUser { get; set; }
        public string OnUssd { get; set; }
        public string CrTranCnt { get; set; }
        public string DrTranCnt { get; set; }
    }
}
