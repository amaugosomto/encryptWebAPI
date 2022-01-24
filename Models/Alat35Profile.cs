using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat35Profile
    {
        public long Id { get; set; }
        public long? RegistrationId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Password { get; set; }
        public string ReferralCode { get; set; }
        public string ReferredBy { get; set; }
        public int? ProfileStatus { get; set; }
        public int? FailedLoginCount { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string NickName { get; set; }
        public DateTime? LastPasswordChanged { get; set; }
        public string ActiveSession { get; set; }
        public byte[] TransactionPin { get; set; }
        public string GcmregistrationId { get; set; }
        public DateTime? LastDateGcmupdated { get; set; }
        public bool? IsInCardControl { get; set; }
        public int? RegistrationChanelId { get; set; }
        public string DisplayPictureUrl { get; set; }
        public DateTime? DateReferralModified { get; set; }
        public bool? ReferralModified { get; set; }
        public bool? IsFromWemaMobile { get; set; }
        public string WmuserName { get; set; }
        public int? BadgeId { get; set; }
        public long? PointBalance { get; set; }
        public DateTime? BadgeAwardDate { get; set; }
        public DateTime? LastPointUpdate { get; set; }
        public long? RedeemablePoint { get; set; }
        public DateTime? LastRedeemablePointUpdate { get; set; }
        public bool? IsfromWemaMobileAuthorised { get; set; }
        public bool? IsBackOfficeSync { get; set; }
        public DateTime? DateSync { get; set; }
        public bool? AddressVerificationCompleted { get; set; }
        public bool? IsCreatedViaSlaryLending { get; set; }
        public bool? IsCreatedViaSalaryAcctOpening { get; set; }
    }
}
