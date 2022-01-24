﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class PostTran
    {
        public long? PostTranId { get; set; }
        public long? PostTranCustId { get; set; }
        public int? SettleEntityId { get; set; }
        public int? BatchNr { get; set; }
        public long? PrevPostTranId { get; set; }
        public long? NextPostTranId { get; set; }
        public string SinkNodeName { get; set; }
        public decimal? TranPostilionOriginated { get; set; }
        public decimal? TranCompleted { get; set; }
        public string MessageType { get; set; }
        public string TranType { get; set; }
        public long? TranNr { get; set; }
        public string SystemTraceAuditNr { get; set; }
        public string RspCodeReq { get; set; }
        public string RspCodeRsp { get; set; }
        public string AbortRspCode { get; set; }
        public string AuthIdRsp { get; set; }
        public decimal? AuthType { get; set; }
        public decimal? AuthReason { get; set; }
        public string RetentionData { get; set; }
        public string AcquiringInstIdCode { get; set; }
        public string MessageReasonCode { get; set; }
        public string SponsorBank { get; set; }
        public string RetrievalReferenceNr { get; set; }
        public DateTime? DatetimeTranGmt { get; set; }
        public DateTime? DatetimeTranLocal { get; set; }
        public DateTime? DatetimeReq { get; set; }
        public DateTime? DatetimeRsp { get; set; }
        public DateTime? RealtimeBusinessDate { get; set; }
        public DateTime? ReconBusinessDate { get; set; }
        public string FromAccountType { get; set; }
        public string ToAccountType { get; set; }
        public string FromAccountId { get; set; }
        public string ToAccountId { get; set; }
        public decimal? TranAmountReq { get; set; }
        public decimal? TranAmountRsp { get; set; }
        public decimal? SettleAmountImpact { get; set; }
        public decimal? TranCashReq { get; set; }
        public decimal? TranCashRsp { get; set; }
        public string TranCurrencyCode { get; set; }
        public decimal? TranTranFeeReq { get; set; }
        public decimal? TranTranFeeRsp { get; set; }
        public string TranTranFeeCurrencyCode { get; set; }
        public decimal? TranProcFeeReq { get; set; }
        public decimal? TranProcFeeRsp { get; set; }
        public string TranProcFeeCurrencyCode { get; set; }
        public decimal? SettleAmountReq { get; set; }
        public decimal? SettleAmountRsp { get; set; }
        public decimal? SettleCashReq { get; set; }
        public decimal? SettleCashRsp { get; set; }
        public decimal? SettleTranFeeReq { get; set; }
        public decimal? SettleTranFeeRsp { get; set; }
        public decimal? SettleProcFeeReq { get; set; }
        public decimal? SettleProcFeeRsp { get; set; }
        public string SettleCurrencyCode { get; set; }
        public string IccDataReq { get; set; }
        public string IccDataRsp { get; set; }
        public string PosEntryMode { get; set; }
        public string PosConditionCode { get; set; }
        public string AdditionalRspData { get; set; }
        public string StructuredDataReq { get; set; }
        public string StructuredDataRsp { get; set; }
        public string TranReversed { get; set; }
        public decimal? PrevTranApproved { get; set; }
        public string IssuerNetworkId { get; set; }
        public string AcquirerNetworkId { get; set; }
        public string ExtendedTranType { get; set; }
        public string UcafData { get; set; }
        public string FromAccountTypeQualifier { get; set; }
        public string ToAccountTypeQualifier { get; set; }
        public string BankDetails { get; set; }
        public string Payee { get; set; }
        public string CardVerificationResult { get; set; }
        public int? OnlineSystemId { get; set; }
        public int? ParticipantId { get; set; }
        public int? OppParticipantId { get; set; }
        public string ReceivingInstIdCode { get; set; }
        public int? RoutingType { get; set; }
        public string PtPosOperatingEnvironment { get; set; }
        public string PtPosCardInputMode { get; set; }
        public string PtPosCardholderAuthMethod { get; set; }
        public string PtPosPinCaptureAbility { get; set; }
        public string PtPosTerminalOperator { get; set; }
        public string SourceNodeKey { get; set; }
        public int? ProcOnlineSystemId { get; set; }
        public int? FromAccountIdCs { get; set; }
        public int? ToAccountIdCs { get; set; }
        public string PosGeographicData { get; set; }
    }
}
