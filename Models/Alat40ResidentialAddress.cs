using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40ResidentialAddress
    {
        public Guid? Id { get; set; }
        public Guid? CustomerId { get; set; }
        public string Cif { get; set; }
        public string BuildingNumber { get; set; }
        public string Apartment { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public string Lcda { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Landmark { get; set; }
        public string AdditionalInformation { get; set; }
        public string Country { get; set; }
        public string FullAddress { get; set; }
        public int? Status { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
    }
}
