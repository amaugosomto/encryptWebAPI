using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class AfbCustomer
    {
        public long? AccountSettingsId { get; set; }
        public string Cif { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string BranchCode { get; set; }
        public bool? AllowSingleDebit { get; set; }
        public bool? AllowBulkDebit { get; set; }
        public bool? AllowInterBankDebit { get; set; }
        public bool? AllowStatementDownload { get; set; }
        public bool? AllowMultipleSignOn { get; set; }
        public decimal? TransactionLimit { get; set; }
        public int? DebitAuthenticationLevel { get; set; }
        public int? ChequeConfirmationLevel { get; set; }
        public int? SingleVerifierLevel { get; set; }
        public int? SingleApproverLevel { get; set; }
        public int? BulkVerifierLevel { get; set; }
        public int? BulkApproverLevel { get; set; }
        public int? BillVerifierLevel { get; set; }
        public int? BillApprovalLevel { get; set; }
        public bool? IsEditMode { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? LastApproval { get; set; }
        public string Status { get; set; }
        public string SchemeCode { get; set; }
    }
}
