using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40Virtualdollarcard
    {
        public Guid? Id { get; set; }
        public string Cif { get; set; }
        public string FirstDebitAccountNumber { get; set; }
        public decimal? FirstAmount { get; set; }
        public string VirtualCardAlias { get; set; }
        public int? VirtualCardStatus { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string DeletedDate { get; set; }
        public bool? IsPinAuthenticated { get; set; }
        public bool? IsDeleted { get; set; }
        public string FlwId { get; set; }
        public string FlwAccountId { get; set; }
        public string FlwCardLast4Digit { get; set; }
        public bool? HasReadTermAndCondition { get; set; }
        public string CardName { get; set; }
        public string PhoneNumber { get; set; }
        public string ChannelId { get; set; }
        public long? CustomerId { get; set; }
        public long? VirtualRepoId { get; set; }
    }
}
