using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40Account
    {
        public Guid? Id { get; set; }
        public string AccountName { get; set; }
        public string AccountShortName { get; set; }
        public string StaffId { get; set; }
        public string BranchCode { get; set; }
        public string ChannelId { get; set; }
        public string DateOfOpening { get; set; }
        public string CifId { get; set; }
        public string SchemeCode { get; set; }
        public string GlCode { get; set; }
        public string CurrencyCode { get; set; }
        public string AccountNumber { get; set; }
        public string FreeCode4 { get; set; }
        public string ManagerId { get; set; }
    }
}
