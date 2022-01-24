using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40Profile
    {
        public Guid? Id { get; set; }
        public string Email { get; set; }
        public string Cif { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsFromWemaMobile { get; set; }
        public string ChangedPassword { get; set; }
        public string DateDeactivated { get; set; }
        public string LastLogin { get; set; }
        public string DateActivated { get; set; }
        public int? FailedLoginCount { get; set; }
        public string PhoneNumber { get; set; }
        public string ReferralBy { get; set; }
        public string ReferralCode { get; set; }
        public bool? IsPinSet { get; set; }
        public string Bvn { get; set; }
        public string BvnPhoneNumber { get; set; }
        public string Dob { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool? IsBvnLinked { get; set; }
        public bool? IsContactDetailsFilled { get; set; }
        public bool? IsExistingCustomer { get; set; }
        public bool? IsNextOfKinRecordFilled { get; set; }
        public bool? IsPersonalInfoFilled { get; set; }
        public string FinacleEmail { get; set; }
        public string FinaclePhoneNumber { get; set; }
        public string Sex { get; set; }
        public bool? HasInactiveAccount { get; set; }
        public bool? HasRejectedLoan { get; set; }
        public bool? IsAccountGenerated { get; set; }
        public bool? IsLoanCustomer { get; set; }
        public bool? IsResidentialAddressFilled { get; set; }
        public bool? IsPassportUploaded { get; set; }
        public bool? IsSignatureUploaded { get; set; }
        public bool? IsPassportApproved { get; set; }
        public bool? IsSignaturApproved { get; set; }
        public bool? IsTaxInfoProvided { get; set; }
        public bool? IsIdcardUploaded { get; set; }
        public bool? IsIdcardApproved { get; set; }
        public bool? IsResidentialAddressApproved { get; set; }
        public int? Kycstatus { get; set; }
        public long? CustomerIdformerAlat { get; set; }
        public bool? IsAccountVerified { get; set; }
        public string LastDateGcmupdated { get; set; }
        public string WmuserName { get; set; }
        public bool? IsPasswordUpdated { get; set; }
        public string DateAccepted { get; set; }
        public string Response { get; set; }
        public int? HasInactiveAccounts { get; set; }
    }
}
