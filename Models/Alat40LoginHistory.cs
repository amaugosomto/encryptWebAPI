using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40LoginHistory
    {
        public Guid? Id { get; set; }
        public DateTime? DateLoggedIn { get; set; }
        public string DeviceName { get; set; }
        public string DeviceOs { get; set; }
        public string DeviceImei { get; set; }
        public string GeoLatitude { get; set; }
        public string GeoLongitude { get; set; }
        public DateTime? GeoTimeStamp { get; set; }
        public Guid? ProfileId { get; set; }
    }
}
