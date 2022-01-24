using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class PcCards1A
    {
        public int? IssuerNr { get; set; }
        public string Pan { get; set; }
        public string SeqNr { get; set; }
        public string CardProgram { get; set; }
        public string DefaultAccountType { get; set; }
        public int? CardStatus { get; set; }
        public int? CardCustomState { get; set; }
        public string ExpiryDate { get; set; }
        public string HoldRspCode { get; set; }
        public string Track2Value { get; set; }
        public int? Track2ValueOffset { get; set; }
        public int? PvkiOrPinLength { get; set; }
        public string PvvOrPinOffset { get; set; }
        public string Pvv2OrPin2Offset { get; set; }
        public string ValidationDataQuestion { get; set; }
        public string ValidationData { get; set; }
        public string CardholderRspInfo { get; set; }
        public int? MailerDestination { get; set; }
        public string DiscretionaryData { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? DateActivated { get; set; }
        public string IssuerReference { get; set; }
        public string BranchCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public string CustomerId { get; set; }
        public int? BatchNr { get; set; }
        public int? CompanyCard { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? Pvki2OrPin2Length { get; set; }
        public string ExtendedFields { get; set; }
        public string ExpiryDay { get; set; }
        public string FromDate { get; set; }
        public string FromDay { get; set; }
        public string ContactlessDiscData { get; set; }
        public int? DcvvKeyIndex { get; set; }
        public string PanEncrypted { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
    }
}
