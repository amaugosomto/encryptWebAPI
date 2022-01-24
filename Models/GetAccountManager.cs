using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class GetAccountManager
    {
        public string EmpId { get; set; }
        public string EntityCreFlg { get; set; }
        public string DelFlg { get; set; }
        public string EmpIntls { get; set; }
        public string SolId { get; set; }
        public string EmpName { get; set; }
        public string EmpShortName { get; set; }
        public decimal? EmpSignPowerNum { get; set; }
        public decimal? EmpSignPowerAmt { get; set; }
        public string EmpDesig { get; set; }
        public string EmpStat { get; set; }
        public decimal? TotModTimes { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public string IsHeadTeller { get; set; }
        public decimal? TsCnt { get; set; }
        public string EmpEmailId { get; set; }
        public string Alt1EmpName { get; set; }
        public string Alt1EmpShortName { get; set; }
    }
}
