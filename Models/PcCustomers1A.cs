using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class PcCustomers1A
    {
        public int? IssuerNr { get; set; }
        public string CustomerId { get; set; }
        public string NationalIdNr { get; set; }
        public string C1Title { get; set; }
        public string C1FirstName { get; set; }
        public string C1Initials { get; set; }
        public string C1LastName { get; set; }
        public string C1NameOnCard { get; set; }
        public string C2Title { get; set; }
        public string C2FirstName { get; set; }
        public string C2Initials { get; set; }
        public string C2LastName { get; set; }
        public string C2NameOnCard { get; set; }
        public string C3Title { get; set; }
        public string C3FirstName { get; set; }
        public string C3Initials { get; set; }
        public string C3LastName { get; set; }
        public string C3NameOnCard { get; set; }
        public string TelNr { get; set; }
        public string MobileNr { get; set; }
        public string FaxNr { get; set; }
        public string EmailAddress { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalCity { get; set; }
        public string PostalRegion { get; set; }
        public string PostalCode { get; set; }
        public string PostalCountry { get; set; }
        public string OtherAddress1 { get; set; }
        public string OtherAddress2 { get; set; }
        public string OtherCity { get; set; }
        public string OtherRegion { get; set; }
        public string OtherPostalCode { get; set; }
        public string OtherCountry { get; set; }
        public string DateOfBirth { get; set; }
        public string CompanyName { get; set; }
        public string PreferredLang { get; set; }
        public int? Vip { get; set; }
        public DateTime? VipLapseDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string ExtendedFields { get; set; }
        public string NationalIdNrEncrypted { get; set; }
    }
}
