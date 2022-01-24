using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class Alat40CustomerDocument
    {
        public Guid? CustomerDocumentationId { get; set; }
        public string DocumentIdentityType { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string CustomerName { get; set; }
        public string FileName { get; set; }
        public string IssueDate { get; set; }
        public string PlaceOfIssue { get; set; }
        public string ExpiryDate { get; set; }
        public string Code { get; set; }
        public string Cif { get; set; }
        public string Extension { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsOnboarding { get; set; }
        public bool? IsConvergence { get; set; }
        public bool? IsReactivation { get; set; }
        public bool? TreatedByVerifier { get; set; }
        public DateTime? DateTreatedByVerifier { get; set; }
        public bool? TreatedByApprover { get; set; }
        public DateTime? DateTreatedByApprover { get; set; }
        public string UploadReason { get; set; }
        public int? ApproverStatus { get; set; }
        public string Bvn { get; set; }
        public int? VerifierStatus { get; set; }
        public string Uri { get; set; }
        public string Base64Image { get; set; }
        public string Assignmentid { get; set; }
        public string AccountNumber { get; set; }
        public string EmployerName { get; set; }
        public string StatementReviewType { get; set; }
        public string BankId { get; set; }
        public string VerifierId { get; set; }
        public string AuthorizerId { get; set; }
    }
}
