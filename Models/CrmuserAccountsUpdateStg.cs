using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CrmuserAccountsUpdateStg
    {
        public decimal? Accountid { get; set; }
        public string Bvn { get; set; }
        public string CustFirstName { get; set; }
        public string CustMiddleName { get; set; }
        public string CustLastName { get; set; }
        public string Gender { get; set; }
        public DateTime? CustDob { get; set; }
        public string Occupation { get; set; }
        public string Staffflag { get; set; }
        public DateTime? Bodatemodified { get; set; }
        public decimal? Bomodifiedby { get; set; }
        public string SegmentationClass { get; set; }
        public string Subsegment { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string PrimarySolId { get; set; }
    }
}
