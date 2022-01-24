using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbDownloadsAuditTrail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? UserId { get; set; }
        public string Filters { get; set; }
        public string Page { get; set; }
        public DateTime? Date { get; set; }
    }
}
