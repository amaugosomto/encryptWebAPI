using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class GamtableStageUpdate
    {
        public string DelFlg { get; set; }
        public string AcctClsFlg { get; set; }
        public string AcctOwnership { get; set; }
        public string Foracid { get; set; }
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
        public decimal? CumDrAmt { get; set; }
        public decimal? CumCrAmt { get; set; }
        public DateTime? LastTranDate { get; set; }
        public DateTime? LastAnyTranDate { get; set; }
        public string AcctMgrUserId { get; set; }
        public DateTime? LastTranDateCr { get; set; }
        public DateTime? LastTranDateDr { get; set; }
        public string LastTranIdCr { get; set; }
        public string LastTranIdDr { get; set; }
        public DateTime? LastUnfrezDate { get; set; }
        public DateTime? LastFrezDate { get; set; }
    }
}
