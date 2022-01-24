using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class FinEit
    {
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? NrmlInterestAmountCr { get; set; }
    }
}
