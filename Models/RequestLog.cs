using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RequestLog
    {
        public int Id { get; set; }
        public string RequestTime { get; set; }
        public string RequestLabel { get; set; }
    }
}
