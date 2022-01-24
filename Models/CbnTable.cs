using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CbnTable
    {
        public string Volume { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string NoOfTransactions { get; set; }
        public string TranYear { get; set; }
        public string TranMonth { get; set; }
        public string Report { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
