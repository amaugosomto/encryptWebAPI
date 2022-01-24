using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35FirstFailedTran
    {
        public string Accountnumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public long? RowNum { get; set; }
    }
}
