using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class OleDbDestination
    {
        public long? PostTranCustId { get; set; }
        public string TerminalId { get; set; }
        public string PosTerminalType { get; set; }
        public string Pan { get; set; }
        public string SourceNodeName { get; set; }
        public string CardAcceptorNameLoc { get; set; }
        public string CardProduct { get; set; }
    }
}
