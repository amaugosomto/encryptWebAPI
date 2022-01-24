using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TropsFx
    {
        public decimal? DealNo { get; set; }
        public string NearRate { get; set; }
        public string FarAmt { get; set; }
        public string NearAmt { get; set; }
        public string FarRate { get; set; }
        public string Ccy2 { get; set; }
        public string Ccy1 { get; set; }
        public string Mrs { get; set; }
        public string CpartyId { get; set; }
        public string Subtype { get; set; }
        public DateTime? DealDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContractRate { get; set; }
        public string Currency { get; set; }
        public string DealType { get; set; }
        public string FxType { get; set; }
    }
}
