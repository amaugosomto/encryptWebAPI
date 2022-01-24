using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RmodelTable2
    {
        public byte[] Model { get; set; }
        public string Modelname { get; set; }
        public string Modeltype { get; set; }
        public string Modeldescription { get; set; }
        public double? Modelversion { get; set; }
        public string Author { get; set; }
        public DateTime? Insertdate { get; set; }
    }
}
