using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RrTransactionLog
    {
        public Guid? Id { get; set; }
        public string Cif { get; set; }
        public string TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public int? TransactionStatus { get; set; }
        public string SourceAccountNumber { get; set; }
        public string SourceAccountName { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
