using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TropsBond
    {
        public decimal? DealNo { get; set; }
        public string CpartyId { get; set; }
        public string DaysToMaturity { get; set; }
        public string Subtype { get; set; }
        public string DealIdentifier { get; set; }
        public string Yield { get; set; }
        public DateTime? DealDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContractRate { get; set; }
        public string PrincipalAmount { get; set; }
        public string Currency { get; set; }
        public string BuyOrSell { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string BondType { get; set; }
    }
}
