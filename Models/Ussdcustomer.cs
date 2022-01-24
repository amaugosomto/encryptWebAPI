using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Ussdcustomer
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNetwork { get; set; }
        public string Channels { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string Status { get; set; }
        public string LastActivity { get; set; }
        public string SoleId { get; set; }
        public string AccountSchemeCode { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsBlocked { get; set; }
        public string OnUssd { get; set; }
        public string PrimaryAccountNumber { get; set; }
    }
}
