using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40VirtualCardActivitylog
    {
        public int? Id { get; set; }
        public string Cif { get; set; }
        public Guid? VirtualCardId { get; set; }
        public byte? VirtualCardOperation { get; set; }
        public string DateRequested { get; set; }
        public string FlutterwaveResponse { get; set; }
    }
}
