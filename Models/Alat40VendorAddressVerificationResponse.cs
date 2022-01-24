using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40VendorAddressVerificationResponse
    {
        public Guid? Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string VerificationAddress { get; set; }
        public string VisitDate { get; set; }
        public string VendorId { get; set; }
        public bool? AddressExist { get; set; }
        public bool? AddressResidential { get; set; }
        public bool? CustomerResident { get; set; }
        public bool? CustomerKnown { get; set; }
        public string MetWith { get; set; }
        public string EaseOfLocation { get; set; }
        public string Comments { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string VisitTime { get; set; }
        public string PersonMetOthers { get; set; }
        public string NameOfPersonMet { get; set; }
        public string VisitFeedback { get; set; }
        public string AddressImage { get; set; }
        public DateTime? DateCreated { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
