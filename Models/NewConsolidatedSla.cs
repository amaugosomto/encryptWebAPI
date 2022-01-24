using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class NewConsolidatedSla
    {
        public string Rownames { get; set; }
        public string ComplaintCategory { get; set; }
        public string Subcategory { get; set; }
        public string ResolvingUnItdepartment { get; set; }
        public string CurrentSla { get; set; }
        public string NewSla { get; set; }
        public string Cbnsla { get; set; }
        public string Code { get; set; }
        public string Stakeholdersdebate { get; set; }
        public double? DevSla { get; set; }
    }
}
