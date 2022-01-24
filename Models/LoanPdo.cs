using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class LoanPdo
    {
        public string CifId { get; set; }
        public string AcctClsFlg { get; set; }
        public string LoanAccountNo { get; set; }
        public string LoanAcctName { get; set; }
        public string OperAcctBrnId { get; set; }
        public string OperAcctBrnName { get; set; }
        public string OperAcctNo { get; set; }
        public string OperAcctName { get; set; }
        public string OperAcctBal { get; set; }
        public string OperAcctLienAmt { get; set; }
        public string SchmCode { get; set; }
        public string LoanAcctBal { get; set; }
        public string InterestDue { get; set; }
        public string PrincipalDue { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? LoanAmount { get; set; }
    }
}
