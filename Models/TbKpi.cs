﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbKpi
    {
        public int Id { get; set; }
        public string Zone { get; set; }
        public string Branch { get; set; }
        public int? Sol { get; set; }
        public int? JuneActual { get; set; }
        public int? Fy2021 { get; set; }
    }
}
