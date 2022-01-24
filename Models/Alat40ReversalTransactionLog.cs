using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40ReversalTransactionLog
    {
        public string TransactionType { get; set; }
        public int? TransactionStatus { get; set; }
        public string Cif { get; set; }
        public decimal? Amount { get; set; }
        public string ReversalTransactionResponse { get; set; }
        public string TransactionStan { get; set; }
        public string OriginalTransactionDateTime { get; set; }
        public string PlatformReference { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string ChannelId { get; set; }
        public string ReversalTransactionRequest { get; set; }
    }
}
