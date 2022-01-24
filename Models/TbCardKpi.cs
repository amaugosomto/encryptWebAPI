using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbCardKpi
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Sol { get; set; }
        public string JulyDecFullTarget { get; set; }
        public string Zone { get; set; }
    }
}
