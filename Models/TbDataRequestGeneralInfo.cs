using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class TbDataRequestGeneralInfo
    {
        public string CifId { get; set; }
        public string SolId { get; set; }
        public string AcctOwnership { get; set; }
        public string AccountClosed { get; set; }
        public string AccountDeleted { get; set; }
        public string SolDesc { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public DateTime? DateOpened { get; set; }
        public string SchmCode { get; set; }
        public string Product { get; set; }
        public string AccountStatus { get; set; }
        public string PrevAcctStatus { get; set; }
        public DateTime? AcctStatusDate { get; set; }
        public string Restriction { get; set; }
        public string Reason { get; set; }
        public DateTime? LastTranDate { get; set; }
        public string Currency { get; set; }
        public decimal? CurrBal { get; set; }
        public string CurrNairaBal { get; set; }
        public string YstdBalNairEqv { get; set; }
        public string TwoDaysBalNairEqv { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
