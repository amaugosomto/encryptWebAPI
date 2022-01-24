using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Gamtable
    {
        public string Acid { get; set; }
        public string DelFlg { get; set; }
        public string AcctClsFlg { get; set; }
        public string AcctOwnership { get; set; }
        public string Foracid { get; set; }
        public string AcctName { get; set; }
        public string GlSubHeadCode { get; set; }
        public DateTime? AcctOpnDate { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string FrezCode { get; set; }
        public string FrezReasonCode { get; set; }
        public DateTime? AcctClsDate { get; set; }
        public decimal? ClrBalAmt { get; set; }
        public string NairaBalance { get; set; }
        public string YstdBalNaireqv { get; set; }
        public string TwoDaysBalNaireqv { get; set; }
        public decimal? SanctLim { get; set; }
        public decimal? CumDrAmt { get; set; }
        public decimal? CumCrAmt { get; set; }
        public DateTime? LastTranDate { get; set; }
        public string IntPaidFlg { get; set; }
        public string IntCollFlg { get; set; }
        public DateTime? LastAnyTranDate { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public decimal? FxCumDrAmt { get; set; }
        public decimal? FxCumCrAmt { get; set; }
        public string AcctCrncyCode { get; set; }
        public decimal? LienAmt { get; set; }
        public string AcctClassificationFlg { get; set; }
        public DateTime? MinValueDate { get; set; }
        public string AcctMgrUserId { get; set; }
        public string SchmType { get; set; }
        public DateTime? LastFrezDate { get; set; }
        public DateTime? LastUnfrezDate { get; set; }
        public decimal? BalOnFrezDate { get; set; }
        public string CifId { get; set; }
        public string ChannelId { get; set; }
        public DateTime? LastTranDateCr { get; set; }
        public DateTime? LastTranDateDr { get; set; }
        public string LastTranIdCr { get; set; }
        public string LastTranIdDr { get; set; }
    }
}
