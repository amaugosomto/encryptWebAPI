using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CustomerCluster1
    {
        public string Cif { get; set; }
        public string SourceAccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Emailaddress { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationAccountNumber { get; set; }
        public string DestinationBank { get; set; }
        public int? Tcount { get; set; }
        public decimal? SumAmount { get; set; }
        public string Name { get; set; }
        public decimal? TotalTransactionVolume { get; set; }
    }
}
