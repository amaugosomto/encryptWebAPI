﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class VolManagerChgIssued
    {
        public string SolId { get; set; }
        public string SolDesc { get; set; }
        public string Count { get; set; }
        public string Volume { get; set; }
        public string YearMonth { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
    }
}
