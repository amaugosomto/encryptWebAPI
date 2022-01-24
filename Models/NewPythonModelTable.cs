using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewPythonModelTable
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public byte[] Model { get; set; }
        public double? Version { get; set; }
        public string Author { get; set; }
        public string ModelTitle { get; set; }
        public DateTime? GenerationTime { get; set; }
    }
}
