using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbFiveForFiveReactivationLeaderBoard
    {
        public string Yr { get; set; }
        public string Mnth { get; set; }
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string Zone { get; set; }
        public int? Total { get; set; }
        public int? Fy2021 { get; set; }
        public int? JuneActual { get; set; }
        public string Region { get; set; }
        public string Measure { get; set; }
        public int? ActualJune { get; set; }
    }
}
