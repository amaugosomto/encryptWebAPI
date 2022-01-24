using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class FinUpr
    {
        public string UserId { get; set; }
        public string DelFlg { get; set; }
        public string UserWorkClass { get; set; }
        public string SolId { get; set; }
        public string UserSolTenor { get; set; }
        public string RemoteAccessFlg { get; set; }
        public decimal? UserMaxInactiveTime { get; set; }
        public DateTime? UserAcctExpyDate { get; set; }
        public DateTime? UserPwExpyDate { get; set; }
        public string AuthUserId { get; set; }
        public decimal? TotModTimes { get; set; }
        public string UserApplName { get; set; }
        public DateTime? UserDisabledFromDate { get; set; }
        public DateTime? UserDisabledUptoDate { get; set; }
        public string NewUserFlg { get; set; }
        public byte[] UserPw { get; set; }
        public string UserEmpId { get; set; }
        public string UserTempWorkClass { get; set; }
        public DateTime? UserTmpWrkClassEffUpto { get; set; }
        public string UserLoggedOnFlg { get; set; }
        public DateTime? UserLoginTimeLow { get; set; }
        public DateTime? UserLoginTimeHigh { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public string AppLangCode { get; set; }
        public string DefaultTermId { get; set; }
        public string VirtualFlg { get; set; }
        public string ProxyPostAllwd { get; set; }
        public decimal? TsCnt { get; set; }
        public string RoleId { get; set; }
        public string EntityCreFlg { get; set; }
        public string HomeBankId { get; set; }
        public string MultiBankUserProfileId { get; set; }
        public string ViewScheduledRptFlg { get; set; }
        public string Rmtliteralflg { get; set; }
        public string UserSvsGrpName { get; set; }
        public string RelationshipManagerFlg { get; set; }
        public string FreeCode1 { get; set; }
        public string EnableInqAuditFlg { get; set; }
        public DateTime? InqAuditStartDate { get; set; }
        public DateTime? InqAuditEndDate { get; set; }
    }
}
