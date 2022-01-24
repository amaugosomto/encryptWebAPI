using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Tph
    {
        public string Acid { get; set; }
        public string SrlNum { get; set; }
        public string DelFlg { get; set; }
        public decimal? PartCloseAmt { get; set; }
        public DateTime? PartCloseDate { get; set; }
        public decimal? PreClsPenaltyFee { get; set; }
        public decimal? AdjustedIntAmt { get; set; }
        public decimal? AdjustedTdsAmt { get; set; }
        public decimal? AdjustedProvAmt { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public DateTime? ClsValueDate { get; set; }
        public decimal? TsCnt { get; set; }
        public decimal? PartCloseInterestRate { get; set; }
        public string ClosureType { get; set; }
        public string PreClsIntTblCode { get; set; }
        public string TranId { get; set; }
        public decimal? ContractedRoi { get; set; }
        public decimal? EffectiveRoi { get; set; }
        public decimal? NormalRoi { get; set; }
        public decimal? PenalRoi { get; set; }
        public decimal? RepaymentAmt { get; set; }
        public string CollectPenalIntFlg { get; set; }
        public string PenalIntForFullPerdFlg { get; set; }
        public string RenSrlNum { get; set; }
        public string TphCrncyCode { get; set; }
        public DateTime? GlDate { get; set; }
        public string BankId { get; set; }
        public string ClsrPurposeFlg { get; set; }
        public decimal? PastPdCycleAdjAmt { get; set; }
        public decimal? CurrPdCycleAdjAmt { get; set; }
        public decimal? PartClsPenaltyAmt { get; set; }
        public decimal? TotProfAmtAfterPartCls { get; set; }
    }
}
