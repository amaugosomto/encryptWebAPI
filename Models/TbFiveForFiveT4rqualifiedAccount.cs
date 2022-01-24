using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbFiveForFiveT4rqualifiedAccount
    {
        public string Cif { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string SchmCode { get; set; }
        public string Product { get; set; }
        public decimal? EodBal { get; set; }
        public decimal? CrInflow { get; set; }
        public int? DebitCnt { get; set; }
        public DateTime? RunDate { get; set; }
        public string SolId { get; set; }
        public string Branch { get; set; }
        public string Directorate { get; set; }
        public string Bvn { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime? CustDob { get; set; }
    }
}
