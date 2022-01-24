using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class UssdtransactionLog
    {
        public long? Id { get; set; }
        public int? Transactiontype { get; set; }
        public int? Transactionstatus { get; set; }
        public string Responsecode { get; set; }
        public decimal? Amount { get; set; }
        public string Sourceaccountnumber { get; set; }
        public string Soleid { get; set; }
    }
}
