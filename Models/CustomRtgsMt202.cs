using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CustomRtgsMt202
    {
        public DateTime? ValueDate { get; set; }
        public string SendersAcct { get; set; }
        public string SendersName { get; set; }
        public string RefNum { get; set; }
        public string CrncyCode { get; set; }
        public decimal? TranAmt { get; set; }
        public string TranCode { get; set; }
        public string SendingBankSwiftId { get; set; }
        public string SendingBankAcctNum { get; set; }
        public string ChqNum { get; set; }
        public DateTime? ChqDate { get; set; }
        public string EventChrgeId { get; set; }
        public string ChrgAcctId { get; set; }
        public string MsgPriority { get; set; }
        public string MsgType { get; set; }
        public string BenBankSwiftId { get; set; }
        public string BenBankAcctNum { get; set; }
        public string BenBankShortName { get; set; }
        public string SenderRecverInfo { get; set; }
        public string ReserveCredit { get; set; }
        public string CoinDenom { get; set; }
        public string NoteDenom { get; set; }
        public string ReserveDebit { get; set; }
        public string Oid { get; set; }
        public string EarliestTime { get; set; }
        public string LastTime { get; set; }
        public string RejectTime { get; set; }
        public string PstdFlg { get; set; }
        public string RcreUserId { get; set; }
        public DateTime? RcreTime { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string VerFlg { get; set; }
        public string VerUserId { get; set; }
        public DateTime? VerTime { get; set; }
        public string DelFlg { get; set; }
        public string DelUserId { get; set; }
        public DateTime? DelTime { get; set; }
        public string BankId { get; set; }
    }
}
