using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class GoalLiquidation
    {
        public string CifId { get; set; }
        public string Foracid { get; set; }
        public string GoalName { get; set; }
        public string Name { get; set; }
        public string SolId { get; set; }
        public string Branch { get; set; }
        public string SchmCode { get; set; }
        public string SchmDesc { get; set; }
        public string AcctClsFlg { get; set; }
        public DateTime? AcctClsDate { get; set; }
        public string StaffId { get; set; }
        public decimal? LiquidatedAmt { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Currency { get; set; }
        public DateTime? Datebooked { get; set; }
    }
}
