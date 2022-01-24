using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class CcsmsSla
    {
        public string ComplaintCategory { get; set; }
        public string SubCategory { get; set; }
        public string ResolvingUnItDepartment { get; set; }
        public string CurrentSla { get; set; }
        public string NewSla { get; set; }
        public string CbnSla { get; set; }
        public string Code { get; set; }
        public string StakeholderSDebate { get; set; }
        public double? DevSla { get; set; }
    }
}
