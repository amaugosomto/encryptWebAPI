using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class IncentiveTarget
    {
        public string SolId { get; set; }
        public short? AcquisitionMonthlyTarget { get; set; }
        public short? Acqusition10Percent { get; set; }
        public short? ReactivationMonthlyTarget { get; set; }
        public short? Reactivation10Percent { get; set; }
        public int? TransactionCountMonthlyTarget { get; set; }
        public int? TransactionCount10Percent { get; set; }
        public short? ChanelMigrationMonthlyTarget { get; set; }
        public short? ChannelMigration10Percent { get; set; }
        public short? QualifyingCustomersMonthlyTarget { get; set; }
        public short? QualifyingCustomers10Percent { get; set; }
    }
}
