using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class RetailAcctOfficerDetail
    {
        public string StaffId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCategory { get; set; }
        public string JobTitle { get; set; }
        public DateTime? DateOfEngagement { get; set; }
    }
}
