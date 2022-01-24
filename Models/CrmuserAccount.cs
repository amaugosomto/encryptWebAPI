using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CrmuserAccount
    {
        public decimal? Accountid { get; set; }
        public string Orgkey { get; set; }
        public string Bvn { get; set; }
        public string CustFirstName { get; set; }
        public string CustMiddleName { get; set; }
        public string CustLastName { get; set; }
        public string Gender { get; set; }
        public DateTime? CustDob { get; set; }
        public string CustTypeCode { get; set; }
        public string Occupation { get; set; }
        public string Uniqueid { get; set; }
        public string Staffflag { get; set; }
        public DateTime? Bodatecreated { get; set; }
        public decimal? Bocreatedby { get; set; }
        public DateTime? Bodatemodified { get; set; }
        public decimal? Bomodifiedby { get; set; }
        public decimal? Createduserid { get; set; }
        public string SegmentationClass { get; set; }
        public string PrimarySolId { get; set; }
        public string Sector { get; set; }
        public string Subsector { get; set; }
        public string Iscorprep { get; set; }
        public string Isebankingenabled { get; set; }
        public string Issmsbankingenabled { get; set; }
        public string Subsegment { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
