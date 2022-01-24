using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RrReturnedCustomer
    {
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferralCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Cif { get; set; }
        public int? InterbankTransactionCount { get; set; }
        public int? TransactionCount { get; set; }
        public decimal? TransactionCharge { get; set; }
        public DateTime? DateTimeActivated { get; set; }
        public bool? HasBeenRewarded { get; set; }
        public bool? HasJoinedEarnOntheGo { get; set; }
        public bool? HasQualifiedForReward { get; set; }
        public DateTime? DateTimeJoinedEotg { get; set; }
        public DateTime? DateTimeQualifiedForReward { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime? DateTimeRewarded { get; set; }
    }
}
