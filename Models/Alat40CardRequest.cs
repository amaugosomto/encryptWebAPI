using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40CardRequest
    {
        public Guid? CustomerId { get; set; }
        public long? CustomerFormerAlatId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Cif { get; set; }
        public string Fullname { get; set; }
        public Guid? ChannelId { get; set; }
        public string NameOnCard { get; set; }
        public string PaymentAccountNumber { get; set; }
        public string DeliveryOption { get; set; }
        public string City { get; set; }
        public string CompoundName { get; set; }
        public string Lga { get; set; }
        public string Lcda { get; set; }
        public string Apartment { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public string StreetAddress { get; set; }
        public string NearestBustop { get; set; }
        public int? BranchId { get; set; }
        public DateTime? RequestDate { get; set; }
        public bool? IsDebitSuccess { get; set; }
        public string TransactionResponse { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? RequestStatusId { get; set; }
        public string TrackingId { get; set; }
        public string CurrentTrackingStatus { get; set; }
        public bool? IsCurrentCard { get; set; }
        public bool? IsActivated { get; set; }
        public DateTime? DateActivated { get; set; }
        public DateTime? DateDispatched { get; set; }
        public DateTime? DateDelivered { get; set; }
        public string Base64StringLabel { get; set; }
        public int? CardRequestCategoryId { get; set; }
        public long? StudentRequestId { get; set; }
        public DateTime? DatePrinted { get; set; }
        public bool? DeliverToAlternative { get; set; }
        public string AlternativeName { get; set; }
        public string AlternativePhone { get; set; }
        public bool? IsSameAsContact { get; set; }
        public DateTime? PreferredDate { get; set; }
        public bool? IsSentForProcessing { get; set; }
        public bool? IsEmpCard { get; set; }
        public string CardRequestReference { get; set; }
        public string Cardkey { get; set; }
        public string State { get; set; }
    }
}
