using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Htdtable
    {
        public DateTime? TranDate { get; set; }
        public string TranId { get; set; }
        public string TranType { get; set; }
        public string TranSubType { get; set; }
        public string PartTranType { get; set; }
        public string GlSubHeadCode { get; set; }
        public string Acid { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? TranAmt { get; set; }
        public string TranParticular { get; set; }
        public string EntryUserId { get; set; }
        public string PstdUserId { get; set; }
        public string VfdUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? PstdDate { get; set; }
        public DateTime? VfdDate { get; set; }
        public string RptCode { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public string SolId { get; set; }
        public string DthInitSolId { get; set; }
        public decimal? RegularizationAmt { get; set; }
        public string InstrmntType { get; set; }
        public string InstrmntNum { get; set; }
        public DateTime? InstrmntDate { get; set; }
        public string PstdFlg { get; set; }
        public string PartTranSrlNum { get; set; }
        public string TranRmks { get; set; }
        public string DelFlg { get; set; }
        public string RefNum { get; set; }
        public string InstrmntAlpha { get; set; }
        public string PrntAdvcInd { get; set; }
        public string AmtReservationInd { get; set; }
        public decimal? ReservationAmt { get; set; }
        public string RestrictModifyInd { get; set; }
        public string CustId { get; set; }
        public string VoucherPrintFlg { get; set; }
        public string ModuleId { get; set; }
        public string BrCode { get; set; }
        public decimal? FxTranAmt { get; set; }
        public string RateCode { get; set; }
        public decimal? Rate { get; set; }
        public string CrncyCode { get; set; }
        public string NavigationFlg { get; set; }
        public string TranCrncyCode { get; set; }
        public string RefCrncyCode { get; set; }
        public decimal? RefAmt { get; set; }
        public string BankCode { get; set; }
        public string TreaRefNum { get; set; }
        public decimal? TreaRate { get; set; }
        public decimal? TsCnt { get; set; }
        public string GstUpdFlg { get; set; }
        public string IsoFlg { get; set; }
        public string EabfabUpdFlg { get; set; }
        public string LiftLienFlg { get; set; }
        public string ProxyPostInd { get; set; }
        public string SiSrlNum { get; set; }
        public DateTime? SiOrgExecDate { get; set; }
        public string PrSrlNum { get; set; }
        public string SerialNum { get; set; }
        public string DelMemoPad { get; set; }
        public string UadModuleId { get; set; }
        public string UadModuleKey { get; set; }
        public DateTime? ReversalDate { get; set; }
        public DateTime? ReversalValueDate { get; set; }
        public string PttmEventType { get; set; }
        public string ProxyAcid { get; set; }
        public string TodEntityType { get; set; }
        public string TodEntityId { get; set; }
        public decimal? PrincipalPortionAmt { get; set; }
        public string TfEntitySolId { get; set; }
        public string TranParticular2 { get; set; }
        public string TranParticularCode { get; set; }
        public string TrStatus { get; set; }
        public string SvsTranId { get; set; }
        public string CrncyHolChkDoneFlg { get; set; }
        public string ReferralId { get; set; }
        public string PartyCode { get; set; }
        public DateTime? GlDate { get; set; }
        public string BkdtTranFlg { get; set; }
        public string BankId { get; set; }
        public string ImplCashPartTranFlg { get; set; }
        public string PtranChrgExistsFlg { get; set; }
        public string MudPoolBalBuildFlg { get; set; }
        public string GlSegmentString { get; set; }
        public string SysPartTranCode { get; set; }
        public string UserPartTranCode { get; set; }
        public string TranFreeCode1 { get; set; }
        public string TranFreeCode2 { get; set; }
    }
}
