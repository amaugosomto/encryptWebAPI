using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CustomRtgsMt103
    {
        public string InitBrSort { get; set; }
        public DateTime? CaptureDate { get; set; }
        public string SendingBankSwiftId { get; set; }
        public string SendingBankAcctNum { get; set; }
        public string TranCode { get; set; }
        public string SendersAcct { get; set; }
        public string SendersName { get; set; }
        public string SendersAddr { get; set; }
        public string ChqNum { get; set; }
        public DateTime? ChqDate { get; set; }
        public string SenderRecverInfo { get; set; }
        public string MsgPriority { get; set; }
        public string MsgType { get; set; }
        public string RefNum { get; set; }
        public string BenBankSwiftId { get; set; }
        public string BenBankShortName { get; set; }
        public string BenBankAcctNum { get; set; }
        public string BenName { get; set; }
        public string BenForacid { get; set; }
        public string BenAddr { get; set; }
        public decimal? TranAmt { get; set; }
        public string PstdFlg { get; set; }
        public DateTime? ValueDate { get; set; }
        public string ChrgBearer { get; set; }
        public string ChrgAcctId { get; set; }
        public string EventChrgeId { get; set; }
        public string TranDetail { get; set; }
        public string VerFlg { get; set; }
        public string DelFlg { get; set; }
        public string TranRmks { get; set; }
        public string Comments { get; set; }
        public DateTime? RcreTime { get; set; }
        public string RcreUserId { get; set; }
        public string LchgUserId { get; set; }
        public DateTime? LchgTime { get; set; }
        public string BankId { get; set; }
    }
}
