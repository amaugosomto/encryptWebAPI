using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CustomerCluster
    {
        public string CifId { get; set; }
        public string SourceAccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string DestinationAccountName { get; set; }
        public double? DestinationAccountNumber { get; set; }
        public string DestinationBank { get; set; }
        public int? TransactionCount { get; set; }
        public int? SumAmount { get; set; }
        public string ResidenceState { get; set; }
        public int? TotalTransactionVolume { get; set; }
        public string TransfersToPaycom { get; set; }
        public DateTime? RunDate { get; set; }
    }
}
