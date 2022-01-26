using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.DTO
{
    public class DataToSendDTO
    {
        public string key1_enc { get; set; }
    }
    public class DataToReceiveDTO
    {
        public string key1_enc_dec { get; set; }
    }
    public class PcAccounts1BDTO
    {
        public string AccountId { get; set; }
        public string AccountIdEncrypted { get; set; }
    }
}
