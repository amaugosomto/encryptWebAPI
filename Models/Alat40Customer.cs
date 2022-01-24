using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40Customer
    {
        public string ChannelId { get; set; }
        public string CustomerProfileUsername { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string Cif { get; set; }
        public bool? IsAccountGenerationSuccessful { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; }
        public string Bvn { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public string BranchId { get; set; }
        public string SchemeCode { get; set; }
        public bool? IsExistingCustomer { get; set; }
        public string ProfileId { get; set; }
        public bool? IsEligibleForTierThree { get; set; }
        public bool? IsEligibleForTierTwo { get; set; }
        public string ApFlyerId { get; set; }
        public string BvnAddress { get; set; }
        public DateTime? Dob { get; set; }
        public string GeneratedAccountCurrency { get; set; }
        public string MiddleName { get; set; }
        public bool? IsWallet { get; set; }
        public string Nationality { get; set; }
        public string ReferalCode { get; set; }
        public bool? IsMigrated { get; set; }
        public bool? IsSignatureApproved { get; set; }
        public bool? IsSelfieApproved { get; set; }
        public bool? IsIdcardApproved { get; set; }
        public bool? IsResidentialAddressApproved { get; set; }
        public Guid? Id { get; set; }
    }
}
