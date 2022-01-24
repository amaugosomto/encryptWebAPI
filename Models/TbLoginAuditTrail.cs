using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbLoginAuditTrail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public long? UserId { get; set; }
    }
}
