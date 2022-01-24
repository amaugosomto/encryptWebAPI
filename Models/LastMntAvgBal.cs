using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class LastMntAvgBal
    {
        public string Foracid { get; set; }
        public double? AverageBal { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
