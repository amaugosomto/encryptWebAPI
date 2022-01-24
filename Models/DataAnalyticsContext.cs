using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class DataAnalyticsContext : DbContext
    {
        public DataAnalyticsContext()
        {
        }

        public DataAnalyticsContext(DbContextOptions<DataAnalyticsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveAlatPlatformUser> ActiveAlatPlatformUsers { get; set; }
        public virtual DbSet<ActiveNotTransacting> ActiveNotTransactings { get; set; }
        public virtual DbSet<AfbCustomer> AfbCustomers { get; set; }
        public virtual DbSet<AirtimeBackup> AirtimeBackups { get; set; }
        public virtual DbSet<Alat35Account> Alat35Accounts { get; set; }
        public virtual DbSet<Alat35AccountReactivation> Alat35AccountReactivations { get; set; }
        public virtual DbSet<Alat35DigitalLoan> Alat35DigitalLoans { get; set; }
        public virtual DbSet<Alat35FirstFailedTran> Alat35FirstFailedTrans { get; set; }
        public virtual DbSet<Alat35Profile> Alat35Profiles { get; set; }
        public virtual DbSet<Alat35TransactionLog> Alat35TransactionLogs { get; set; }
        public virtual DbSet<Alat35TransactionType> Alat35TransactionTypes { get; set; }
        public virtual DbSet<Alat40Account> Alat40Accounts { get; set; }
        public virtual DbSet<Alat40AccountReactivation> Alat40AccountReactivations { get; set; }
        public virtual DbSet<Alat40AddressVerificationActivity> Alat40AddressVerificationActivitys { get; set; }
        public virtual DbSet<Alat40Airtime> Alat40Airtimes { get; set; }
        public virtual DbSet<Alat40BillsPayment> Alat40BillsPayments { get; set; }
        public virtual DbSet<Alat40CardRequest> Alat40CardRequests { get; set; }
        public virtual DbSet<Alat40Customer> Alat40Customers { get; set; }
        public virtual DbSet<Alat40CustomerDocument> Alat40CustomerDocuments { get; set; }
        public virtual DbSet<Alat40CustomerInformation> Alat40CustomerInformations { get; set; }
        public virtual DbSet<Alat40Datum> Alat40Data { get; set; }
        public virtual DbSet<Alat40DigitalLoan> Alat40DigitalLoans { get; set; }
        public virtual DbSet<Alat40LoanManagement> Alat40LoanManagements { get; set; }
        public virtual DbSet<Alat40LoginHistory> Alat40LoginHistories { get; set; }
        public virtual DbSet<Alat40Profile> Alat40Profiles { get; set; }
        public virtual DbSet<Alat40ReactivationActivity> Alat40ReactivationActivitys { get; set; }
        public virtual DbSet<Alat40ReactivationRequest> Alat40ReactivationRequests { get; set; }
        public virtual DbSet<Alat40RemitaPaymentsTransaction> Alat40RemitaPaymentsTransactions { get; set; }
        public virtual DbSet<Alat40ResidentialAddress> Alat40ResidentialAddresses { get; set; }
        public virtual DbSet<Alat40ReversalTransactionLog> Alat40ReversalTransactionLogs { get; set; }
        public virtual DbSet<Alat40SettlementTransactionLog> Alat40SettlementTransactionLogs { get; set; }
        public virtual DbSet<Alat40TransactionLog> Alat40TransactionLogs { get; set; }
        public virtual DbSet<Alat40VendorAddressVerificationResponse> Alat40VendorAddressVerificationResponses { get; set; }
        public virtual DbSet<Alat40VirtualCardActivitylog> Alat40VirtualCardActivitylogs { get; set; }
        public virtual DbSet<Alat40VirtualDollarCardFundMovementLog> Alat40VirtualDollarCardFundMovementLogs { get; set; }
        public virtual DbSet<Alat40Virtualdollarcard> Alat40Virtualdollarcards { get; set; }
        public virtual DbSet<AlatTran> AlatTrans { get; set; }
        public virtual DbSet<AnalyticsUser> AnalyticsUsers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AuditTable> AuditTables { get; set; }
        public virtual DbSet<AvgBal6mnt> AvgBal6mnts { get; set; }
        public virtual DbSet<CardableActive> CardableActives { get; set; }
        public virtual DbSet<CbnTable> CbnTables { get; set; }
        public virtual DbSet<CcbankCheque> CcbankCheques { get; set; }
        public virtual DbSet<CcbankNeft> CcbankNefts { get; set; }
        public virtual DbSet<CcsmsSla> CcsmsSlas { get; set; }
        public virtual DbSet<ChurnCustomerDatum> ChurnCustomerData { get; set; }
        public virtual DbSet<ChurnDatum> ChurnData { get; set; }
        public virtual DbSet<ChurnPrediction2> ChurnPrediction2s { get; set; }
        public virtual DbSet<ChurnPredictionBkup> ChurnPredictionBkups { get; set; }
        public virtual DbSet<ClvDatum> ClvData { get; set; }
        public virtual DbSet<ClvPrediction> ClvPredictions { get; set; }
        public virtual DbSet<ClvPredictionTable> ClvPredictionTables { get; set; }
        public virtual DbSet<ConsolidatedCard> ConsolidatedCards { get; set; }
        public virtual DbSet<CrmuserAccount> CrmuserAccounts { get; set; }
        public virtual DbSet<CrmuserAccountsUpdateStg> CrmuserAccountsUpdateStgs { get; set; }
        public virtual DbSet<CustomRtgsMt103> CustomRtgsMt103s { get; set; }
        public virtual DbSet<CustomRtgsMt202> CustomRtgsMt202s { get; set; }
        public virtual DbSet<CustomerChurnNewDatum> CustomerChurnNewData { get; set; }
        public virtual DbSet<CustomerCluster> CustomerClusters { get; set; }
        public virtual DbSet<CustomerCluster1> CustomerClusters1 { get; set; }
        public virtual DbSet<CustomerProfitability> CustomerProfitabilities { get; set; }
        public virtual DbSet<Customercluster2> Customerclusters2 { get; set; }
        public virtual DbSet<Customerclusters2> Customerclusters2s { get; set; }
        public virtual DbSet<CustomersProfile> CustomersProfiles { get; set; }
        public virtual DbSet<DataRequestUser> DataRequestUsers { get; set; }
        public virtual DbSet<Dd3portalUser> Dd3portalUsers { get; set; }
        public virtual DbSet<Demographic> Demographics { get; set; }
        public virtual DbSet<DigitallendingPrediction> DigitallendingPredictions { get; set; }
        public virtual DbSet<DigitallendingTest> DigitallendingTests { get; set; }
        public virtual DbSet<DimDate> DimDates { get; set; }
        public virtual DbSet<FeeIncome> FeeIncomes { get; set; }
        public virtual DbSet<FinDtt> FinDtts { get; set; }
        public virtual DbSet<FinEit> FinEits { get; set; }
        public virtual DbSet<FinTam> FinTams { get; set; }
        public virtual DbSet<FinUpr> FinUprs { get; set; }
        public virtual DbSet<FormatedPhoneNo> FormatedPhoneNos { get; set; }
        public virtual DbSet<Gamtable> Gamtables { get; set; }
        public virtual DbSet<GamtableStageUpdate> GamtableStageUpdates { get; set; }
        public virtual DbSet<GetAccountManager> GetAccountManagers { get; set; }
        public virtual DbSet<GoalLiquidation> GoalLiquidations { get; set; }
        public virtual DbSet<Gsptable> Gsptables { get; set; }
        public virtual DbSet<Htdaggregate> Htdaggregates { get; set; }
        public virtual DbSet<Htdstat> Htdstats { get; set; }
        public virtual DbSet<Htdtable> Htdtables { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InactiveBankwide> InactiveBankwides { get; set; }
        public virtual DbSet<Incentive1> Incentive1s { get; set; }
        public virtual DbSet<IncentiveCustTran> IncentiveCustTrans { get; set; }
        public virtual DbSet<IncentiveCustomer> IncentiveCustomers { get; set; }
        public virtual DbSet<IncentiveReactivated> IncentiveReactivateds { get; set; }
        public virtual DbSet<IncentiveTarget> IncentiveTargets { get; set; }
        public virtual DbSet<InitiatingBranch> InitiatingBranches { get; set; }
        public virtual DbSet<InitiatingBranchCcsm> InitiatingBranchCcsms { get; set; }
        public virtual DbSet<LastMntAvgBal> LastMntAvgBals { get; set; }
        public virtual DbSet<LoanPdo> LoanPdos { get; set; }
        public virtual DbSet<ManagerChgIssued> ManagerChgIssueds { get; set; }
        public virtual DbSet<MasterData2> MasterData2s { get; set; }
        public virtual DbSet<MasterTable> MasterTables { get; set; }
        public virtual DbSet<Mno> Mnos { get; set; }
        public virtual DbSet<NewChurnPrediction> NewChurnPredictions { get; set; }
        public virtual DbSet<NewChurnPrediction2> NewChurnPrediction2s { get; set; }
        public virtual DbSet<NewClvDatum> NewClvData { get; set; }
        public virtual DbSet<NewConsolidatedSla> NewConsolidatedSlas { get; set; }
        public virtual DbSet<NewPartner> NewPartners { get; set; }
        public virtual DbSet<NewProductRecommendationData> NewProductRecommendationDatas { get; set; }
        public virtual DbSet<NewProductRecommendationDatum> NewProductRecommendationData { get; set; }
        public virtual DbSet<NewPythonModelTable> NewPythonModelTables { get; set; }
        public virtual DbSet<NewRecommendationPrediction> NewRecommendationPredictions { get; set; }
        public virtual DbSet<NewTbWebAppCustomerCluster> NewTbWebAppCustomerClusters { get; set; }
        public virtual DbSet<NewTbWebAppCustomerReport> NewTbWebAppCustomerReports { get; set; }
        public virtual DbSet<NibssOutpaymentRequest> NibssOutpaymentRequests { get; set; }
        public virtual DbSet<NullValue> NullValues { get; set; }
        public virtual DbSet<OleDbDestination> OleDbDestinations { get; set; }
        public virtual DbSet<PartnersGam> PartnersGams { get; set; }
        public virtual DbSet<PcAccounts1B> PcAccounts1Bs { get; set; }
        public virtual DbSet<PcCardAccounts1A> PcCardAccounts1As { get; set; }
        public virtual DbSet<PcCards1A> PcCards1As { get; set; }
        public virtual DbSet<PcCustomers1A> PcCustomers1As { get; set; }
        public virtual DbSet<PostTran> PostTrans { get; set; }
        public virtual DbSet<PostTranCust> PostTranCusts { get; set; }
        public virtual DbSet<ProductRecommendationDatum> ProductRecommendationData { get; set; }
        public virtual DbSet<ReactivatedInactiveDormant> ReactivatedInactiveDormants { get; set; }
        public virtual DbSet<ReactivatedViaInflow> ReactivatedViaInflows { get; set; }
        public virtual DbSet<ReactivationFinacle> ReactivationFinacles { get; set; }
        public virtual DbSet<RecommendationPrediction> RecommendationPredictions { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<RestrictedBankwide> RestrictedBankwides { get; set; }
        public virtual DbSet<RetailAcctOfficerDetail> RetailAcctOfficerDetails { get; set; }
        public virtual DbSet<RetailBulkReactivate> RetailBulkReactivates { get; set; }
        public virtual DbSet<RetailCluster> RetailClusters { get; set; }
        public virtual DbSet<RevPayEbill> RevPayEbills { get; set; }
        public virtual DbSet<RmodelTable2> RmodelTable2s { get; set; }
        public virtual DbSet<Ror> Rors { get; set; }
        public virtual DbSet<RrNoTran> RrNoTrans { get; set; }
        public virtual DbSet<RrNoTran2> RrNoTran2s { get; set; }
        public virtual DbSet<RrReturnedCustomer> RrReturnedCustomers { get; set; }
        public virtual DbSet<RrTargetedCustomer> RrTargetedCustomers { get; set; }
        public virtual DbSet<RrTransactionLog> RrTransactionLogs { get; set; }
        public virtual DbSet<SalaryRequest> SalaryRequests { get; set; }
        public virtual DbSet<SaleZonesRegion> SaleZonesRegions { get; set; }
        public virtual DbSet<SchmCodeT4r> SchmCodeT4rs { get; set; }
        public virtual DbSet<Segmentation> Segmentations { get; set; }
        public virtual DbSet<SmtCamStaged> SmtCamStageds { get; set; }
        public virtual DbSet<SmtCamTable> SmtCamTables { get; set; }
        public virtual DbSet<SolTran> SolTrans { get; set; }
        public virtual DbSet<SolTranDb> SolTranDbs { get; set; }
        public virtual DbSet<SrcUssdcustomer> SrcUssdcustomers { get; set; }
        public virtual DbSet<StampDutyTranDet> StampDutyTranDets { get; set; }
        public virtual DbSet<StampDutyTranHist> StampDutyTranHists { get; set; }
        public virtual DbSet<StatusMonitoring> StatusMonitorings { get; set; }
        public virtual DbSet<T4r5f5> T4r5f5s { get; set; }
        public virtual DbSet<T4r5f5Unqualified> T4r5f5Unqualifieds { get; set; }
        public virtual DbSet<TbAdminPortalCustomerMigToDigitalChannel> TbAdminPortalCustomerMigToDigitalChannels { get; set; }
        public virtual DbSet<TbAdminPortalNtbdigitalCustomersCount> TbAdminPortalNtbdigitalCustomersCounts { get; set; }
        public virtual DbSet<TbAdminPortalTransactingDigitalCustomer> TbAdminPortalTransactingDigitalCustomers { get; set; }
        public virtual DbSet<TbAdminPortalTransactingDigitalCustomerCount> TbAdminPortalTransactingDigitalCustomerCounts { get; set; }
        public virtual DbSet<TbAdminPortalTransactingResult> TbAdminPortalTransactingResults { get; set; }
        public virtual DbSet<TbAdminPortalTransactionsDigitalPlatform> TbAdminPortalTransactionsDigitalPlatforms { get; set; }
        public virtual DbSet<TbCardKpi> TbCardKpis { get; set; }
        public virtual DbSet<TbDataRequestDownloadsAuditTrail> TbDataRequestDownloadsAuditTrails { get; set; }
        public virtual DbSet<TbDataRequestGeneralInfo> TbDataRequestGeneralInfos { get; set; }
        public virtual DbSet<TbDataRequestHtd> TbDataRequestHtds { get; set; }
        public virtual DbSet<TbDataRequestLoginAuditTrail> TbDataRequestLoginAuditTrails { get; set; }
        public virtual DbSet<TbDd3portalDownloadsAuditTrail> TbDd3portalDownloadsAuditTrails { get; set; }
        public virtual DbSet<TbDd3portalLoginAuditTrail> TbDd3portalLoginAuditTrails { get; set; }
        public virtual DbSet<TbDownloadsAuditTrail> TbDownloadsAuditTrails { get; set; }
        public virtual DbSet<TbFiveForFiveActiveNotTransacting> TbFiveForFiveActiveNotTransactings { get; set; }
        public virtual DbSet<TbFiveForFiveDownloadsAuditTrail> TbFiveForFiveDownloadsAuditTrails { get; set; }
        public virtual DbSet<TbFiveForFiveInactiveAccount> TbFiveForFiveInactiveAccounts { get; set; }
        public virtual DbSet<TbFiveForFiveLoginAuditTrail> TbFiveForFiveLoginAuditTrails { get; set; }
        public virtual DbSet<TbFiveForFiveReactivation> TbFiveForFiveReactivations { get; set; }
        public virtual DbSet<TbFiveForFiveReactivationLeaderBoard> TbFiveForFiveReactivationLeaderBoards { get; set; }
        public virtual DbSet<TbFiveForFiveRestrictedAccount> TbFiveForFiveRestrictedAccounts { get; set; }
        public virtual DbSet<TbFiveForFiveT4rqualifiedAccount> TbFiveForFiveT4rqualifiedAccounts { get; set; }
        public virtual DbSet<TbKpi> TbKpis { get; set; }
        public virtual DbSet<TbLoginAuditTrail> TbLoginAuditTrails { get; set; }
        public virtual DbSet<TbReactivationKpi> TbReactivationKpis { get; set; }
        public virtual DbSet<TbWebAppCustomer> TbWebAppCustomers { get; set; }
        public virtual DbSet<TbWebAppCustomerCluster> TbWebAppCustomerClusters { get; set; }
        public virtual DbSet<TbWebAppCustomerReport> TbWebAppCustomerReports { get; set; }
        public virtual DbSet<TemitopePnt> TemitopePnts { get; set; }
        public virtual DbSet<TestReactivation> TestReactivations { get; set; }
        public virtual DbSet<TestRor> TestRors { get; set; }
        public virtual DbSet<TmpGam> TmpGams { get; set; }
        public virtual DbSet<ToyinSal> ToyinSals { get; set; }
        public virtual DbSet<Tph> Tphs { get; set; }
        public virtual DbSet<TransactingBranch5f5> TransactingBranch5f5s { get; set; }
        public virtual DbSet<TransactionLogBackup> TransactionLogBackups { get; set; }
        public virtual DbSet<TropsBond> TropsBonds { get; set; }
        public virtual DbSet<TropsFx> TropsFxes { get; set; }
        public virtual DbSet<TropsTbill> TropsTbills { get; set; }
        public virtual DbSet<Ussdcustomer> Ussdcustomers { get; set; }
        public virtual DbSet<UssdtranDetail> UssdtranDetails { get; set; }
        public virtual DbSet<UssdtransactionLog> UssdtransactionLogs { get; set; }
        public virtual DbSet<VolCustomerStopOrder> VolCustomerStopOrders { get; set; }
        public virtual DbSet<VolFormm> VolFormms { get; set; }
        public virtual DbSet<VolGetChequeForClearing> VolGetChequeForClearings { get; set; }
        public virtual DbSet<VolInvestmentBooked> VolInvestmentBookeds { get; set; }
        public virtual DbSet<VolManagerChgIssued> VolManagerChgIssueds { get; set; }
        public virtual DbSet<VolRegion> VolRegions { get; set; }
        public virtual DbSet<VwAdminPortalTransactingResult> VwAdminPortalTransactingResults { get; set; }
        public virtual DbSet<VwAtmNou> VwAtmNous { get; set; }
        public virtual DbSet<VwAtmOnU> VwAtmOnUs { get; set; }
        public virtual DbSet<VwAtmRou> VwAtmRous { get; set; }
        public virtual DbSet<VwFinEchannel> VwFinEchannels { get; set; }
        public virtual DbSet<VwPosNou> VwPosNous { get; set; }
        public virtual DbSet<VwPosOnU> VwPosOnUs { get; set; }
        public virtual DbSet<VwWebAll> VwWebAlls { get; set; }
        public virtual DbSet<WtaTurn> WtaTurns { get; set; }
        public virtual DbSet<_5for5User> _5for5Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.27.7.10;Database=DataAnalytics;Trusted_Connection=false;User ID=cmdm;Password=DataTe@m4");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActiveAlatPlatformUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Active_Alat_PlatformUsers");

                entity.Property(e => e.ActiveAlatUsers).HasColumnName("Active_Alat_Users");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_date");

                entity.Property(e => e.TotalAlatUsers).HasColumnName("Total_Alat_Users");
            });

            modelBuilder.Entity<ActiveNotTransacting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Active_Not_Transacting");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.RunDate).HasColumnType("date");
            });

            modelBuilder.Entity<AfbCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Afb_Customers");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastApproval).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.SchemeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TransactionLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AirtimeBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Airtime_backup");

                entity.Property(e => e.AirtimeRequestStatus).HasColumnName("airtimeRequestStatus");

                entity.Property(e => e.AirtimeTransactionDate)
                    .HasMaxLength(27)
                    .HasColumnName("_airtimeTransactionDate");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AuthenticationType).HasColumnName("authenticationType");

                entity.Property(e => e.ChannelId).HasMaxLength(100);

                entity.Property(e => e.ClientTransactionReference).HasMaxLength(255);

                entity.Property(e => e.DebitaccountNumberValue)
                    .HasMaxLength(50)
                    .HasColumnName("DebitaccountNumber_Value");

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.PhoneNumberValue).HasColumnName("phoneNumber_Value");

                entity.Property(e => e.ResponseStatus).HasMaxLength(50);

                entity.Property(e => e.TransactionReference)
                    .HasMaxLength(200)
                    .HasColumnName("transactionReference");

                entity.Property(e => e.TransactionStan).HasMaxLength(100);

                entity.Property(e => e.TransferReference).HasMaxLength(100);

                entity.Property(e => e.VendCode)
                    .HasMaxLength(50)
                    .HasColumnName("vendCode");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(50)
                    .HasColumnName("vendorId");
            });

            modelBuilder.Entity<Alat35Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_3.5_Accounts");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyPndstatus)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ApplyPNDStatus");

                entity.Property(e => e.Currency)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateRemmapped).HasColumnType("datetime");

                entity.Property(e => e.DateRequested).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GlsubHeadCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GLSubHeadCode");

                entity.Property(e => e.SchemeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeType)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alat35AccountReactivation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_3.5_AccountReactivation");

                entity.Property(e => e.AccountsToReactivate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ReactivationResponseMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alat35DigitalLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_3.5_DigitalLoan");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AmountOffered).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AmountRequested).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreditAccount)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DebitAccount)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DebitBankId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Employer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FailureReason).IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.InterestAccrued).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastInterestExecutionDate).HasColumnType("date");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.LoanAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyRepaymentAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NextLoanRepaymentReminderDate).HasColumnType("datetime");

                entity.Property(e => e.OutStandingAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("phonenumber");

                entity.Property(e => e.ScheduledPaymentArchive).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusRemarks).IsUnicode(false);

                entity.Property(e => e.TotalInterestAccrued).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Alat35FirstFailedTran>(entity =>
            {
                entity.HasKey(e => e.Accountnumber)
                    .HasName("PK__ALAT_3.5__1EF5CD1890D052B1");

                entity.ToTable("ALAT_3.5_first_failed_tran");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNUMBER");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RowNum).HasColumnName("row_num");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alat35Profile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_3.5_Profiles");

                entity.Property(e => e.ActiveSession)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BadgeAwardDate).HasColumnType("datetime");

                entity.Property(e => e.DateReferralModified).HasColumnType("datetime");

                entity.Property(e => e.DateSync).HasColumnType("datetime");

                entity.Property(e => e.DisplayPictureUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GcmregistrationId)
                    .IsUnicode(false)
                    .HasColumnName("GCMRegistrationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateGcmupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("LastDateGCMUpdated");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChanged).HasColumnType("datetime");

                entity.Property(e => e.LastPointUpdate).HasColumnType("datetime");

                entity.Property(e => e.LastRedeemablePointUpdate).HasColumnType("datetime");

                entity.Property(e => e.NickName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WmuserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WMUserName");
            });

            modelBuilder.Entity<Alat35TransactionLog>(entity =>
            {
                entity.ToTable("ALAT_3.5_TransactionLog");

                entity.HasIndex(e => new { e.SourceAccountNumber, e.TransactionDate, e.TransactionStatus }, "idx_TranLog_SourceAccountNumber_Status_date");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.C24originalTransactionDatetime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C24OriginalTransactionDatetime");

                entity.Property(e => e.ChannelType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerProfileId).HasColumnName("CustomerProfileID");

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alat35TransactionType>(entity =>
            {
                entity.ToTable("ALAT_3.5_TransactionType");

                entity.HasIndex(e => new { e.TranType, e.Id }, "idx_TranType_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alat40Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Accounts");

                entity.Property(e => e.CifId).HasColumnName("CifID");
            });

            modelBuilder.Entity<Alat40AccountReactivation>(entity =>
            {
                entity.ToTable("ALAT_4.0_AccountReactivation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).HasMaxLength(10);

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .HasColumnName("CIF");

                entity.Property(e => e.DateCreated).HasMaxLength(27);

                entity.Property(e => e.DateReactivated).HasMaxLength(27);

                entity.Property(e => e.ReferredBy).HasMaxLength(10);
            });

            modelBuilder.Entity<Alat40AddressVerificationActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_AddressVerificationActivitys");
            });

            modelBuilder.Entity<Alat40Airtime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Airtime");

                entity.Property(e => e.AirtimeRequestStatus).HasColumnName("airtimeRequestStatus");

                entity.Property(e => e.AirtimeTransactionDate)
                    .HasMaxLength(27)
                    .HasColumnName("_airtimeTransactionDate");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AuthenticationType).HasColumnName("authenticationType");

                entity.Property(e => e.BiometricPolicy).HasMaxLength(50);

                entity.Property(e => e.BiometricToken).HasMaxLength(50);

                entity.Property(e => e.CallBackUrl).HasMaxLength(400);

                entity.Property(e => e.ChannelId).HasMaxLength(100);

                entity.Property(e => e.ClientTransactionReference).HasMaxLength(50);

                entity.Property(e => e.DebitaccountNumberValue)
                    .HasMaxLength(20)
                    .HasColumnName("DebitaccountNumber_Value");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.PhoneNumberValue).HasColumnName("phoneNumber_Value");

                entity.Property(e => e.ProcessingStage).HasMaxLength(15);

                entity.Property(e => e.ResponseStatus).HasMaxLength(50);

                entity.Property(e => e.TransactionReference)
                    .HasMaxLength(50)
                    .HasColumnName("transactionReference");

                entity.Property(e => e.TransactionStan).HasMaxLength(50);

                entity.Property(e => e.TransferReference).HasMaxLength(50);

                entity.Property(e => e.VendCode)
                    .HasMaxLength(20)
                    .HasColumnName("vendCode");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(5)
                    .HasColumnName("vendorId");
            });

            modelBuilder.Entity<Alat40BillsPayment>(entity =>
            {
                entity.ToTable("ALAT_4.0_BillsPayment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.ClientTransactionRef).IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIdentifier).IsUnicode(false);

                entity.Property(e => e.CustomerPhoneNumber).IsUnicode(false);

                entity.Property(e => e.GlobalAccount).IsUnicode(false);

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransferReference).IsUnicode(false);

                entity.Property(e => e.Vendor).IsUnicode(false);
            });

            modelBuilder.Entity<Alat40CardRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_CardRequest");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Alat40Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Customers");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.ApFlyerId).HasColumnName("ApFlyerID");

                entity.Property(e => e.Bvn).HasMaxLength(11);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .HasColumnName("CIF");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(450);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IsIdcardApproved).HasColumnName("IsIDCardApproved");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasMaxLength(50);

                entity.Property(e => e.SchemeCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Alat40CustomerDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_CustomerDocuments");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.Assignmentid).HasMaxLength(200);

                entity.Property(e => e.AuthorizerId).HasMaxLength(50);

                entity.Property(e => e.BankId).HasMaxLength(10);

                entity.Property(e => e.Bvn).HasMaxLength(20);

                entity.Property(e => e.Cif).HasMaxLength(20);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsConvergence).HasColumnName("isConvergence");

                entity.Property(e => e.IsOnboarding).HasColumnName("isOnboarding");

                entity.Property(e => e.IsReactivation).HasColumnName("isReactivation");

                entity.Property(e => e.StatementReviewType).HasMaxLength(15);

                entity.Property(e => e.VerifierId).HasMaxLength(50);
            });

            modelBuilder.Entity<Alat40CustomerInformation>(entity =>
            {
                entity.ToTable("ALAT_4.0_CustomerInformation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdditionalInformation).HasMaxLength(200);

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.AddressLine1).HasMaxLength(200);

                entity.Property(e => e.AddressLine2).HasMaxLength(200);

                entity.Property(e => e.AddressLine3).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasMaxLength(6);

                entity.Property(e => e.Cif)
                    .HasMaxLength(100)
                    .HasColumnName("CIF");

                entity.Property(e => e.Cifnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CIFNumber");

                entity.Property(e => e.CountryCode).HasMaxLength(6);

                entity.Property(e => e.CustomerInformationEmail).HasColumnName("CustomerInformation_Email");

                entity.Property(e => e.CustomerInformationGender).HasColumnName("CustomerInformation_Gender");

                entity.Property(e => e.CustomerInformationState).HasColumnName("CustomerInformation_State");

                entity.Property(e => e.DateOfBirth).HasMaxLength(27);

                entity.Property(e => e.Dob)
                    .HasMaxLength(27)
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(2);

                entity.Property(e => e.HouseNumber).HasMaxLength(20);

                entity.Property(e => e.LinkedBvnDate).HasMaxLength(27);

                entity.Property(e => e.MinorToMajorDate).HasMaxLength(27);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NokCity).HasColumnName("NOK_City");

                entity.Property(e => e.NokCountry).HasColumnName("NOK_Country");

                entity.Property(e => e.NokFirstname).HasColumnName("NOK_Firstname");

                entity.Property(e => e.NokIsSameAsCustomer).HasColumnName("NOK_IsSameAsCustomer");

                entity.Property(e => e.NokLandMark).HasColumnName("NOK_LandMark");

                entity.Property(e => e.NokNokbvn).HasColumnName("NOK_NOKBVN");

                entity.Property(e => e.NokPlaceOfBirth).HasColumnName("NOK_PlaceOfBirth");

                entity.Property(e => e.NokState).HasColumnName("NOK_State");

                entity.Property(e => e.Othernames).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Prefix).HasMaxLength(6);

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.Property(e => e.RelationshipCode).HasMaxLength(100);

                entity.Property(e => e.RelationshipOpeningDate).HasMaxLength(27);

                entity.Property(e => e.ResidentialAddressApartment).HasColumnName("ResidentialAddress_Apartment");

                entity.Property(e => e.ResidentialAddressCity).HasColumnName("ResidentialAddress_City");

                entity.Property(e => e.ResidentialAddressCountry).HasColumnName("ResidentialAddress_Country");

                entity.Property(e => e.ResidentialAddressFullAddress).HasColumnName("ResidentialAddress_FullAddress");

                entity.Property(e => e.ResidentialAddressIsMailAddress).HasColumnName("ResidentialAddress_IsMailAddress");

                entity.Property(e => e.ResidentialAddressLcda).HasColumnName("ResidentialAddress_LCDA");

                entity.Property(e => e.ResidentialAddressLga).HasColumnName("ResidentialAddress_LGA");

                entity.Property(e => e.ResidentialAddressMailingAddress).HasColumnName("ResidentialAddress_MailingAddress");

                entity.Property(e => e.ResidentialAddressMailingCity).HasColumnName("ResidentialAddress_MailingCity");

                entity.Property(e => e.ResidentialAddressMailingCountry).HasColumnName("ResidentialAddress_MailingCountry");

                entity.Property(e => e.ResidentialAddressMailingState).HasColumnName("ResidentialAddress_MailingState");

                entity.Property(e => e.ResidentialAddressNearestLandmark).HasColumnName("ResidentialAddress_NearestLandmark");

                entity.Property(e => e.ResidentialAddressTown).HasColumnName("ResidentialAddress_Town");

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.StreetName).HasMaxLength(50);

                entity.Property(e => e.StreetNumber).HasMaxLength(10);

                entity.Property(e => e.Subscriber).HasMaxLength(6);

                entity.Property(e => e.Surname).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(10);

                entity.Property(e => e.VerificationStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<Alat40Datum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Data");

                entity.Property(e => e.AirtimeRequestStatus).HasColumnName("airtimeRequestStatus");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AuthenticationType).HasColumnName("authenticationType");

                entity.Property(e => e.BiometricPolicy).HasMaxLength(100);

                entity.Property(e => e.BiometricToken).HasMaxLength(50);

                entity.Property(e => e.CallBackUrl).HasMaxLength(400);

                entity.Property(e => e.ChannelId).HasMaxLength(100);

                entity.Property(e => e.ClientTransactionReference).HasMaxLength(50);

                entity.Property(e => e.CreditAccount).HasMaxLength(15);

                entity.Property(e => e.DateTimeCreated).HasMaxLength(27);

                entity.Property(e => e.DebitAccountNumberValue)
                    .HasMaxLength(20)
                    .HasColumnName("DebitAccountNumber_Value");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");

                entity.Property(e => e.PhoneNumberValue)
                    .HasMaxLength(20)
                    .HasColumnName("phoneNumber_Value");

                entity.Property(e => e.ProcessingStage).HasMaxLength(15);

                entity.Property(e => e.TransactionReference).HasMaxLength(50);

                entity.Property(e => e.TransactionStan).HasMaxLength(50);

                entity.Property(e => e.TransferReference).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("vendorId");
            });

            modelBuilder.Entity<Alat40DigitalLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_DigitalLoan");

                entity.Property(e => e.AmountOffered).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AmountRequested).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AverageMonthlyIncome).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AverageMonthlySalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedDate).HasMaxLength(27);

                entity.Property(e => e.CreditCheckInstallmentAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DueDate).HasMaxLength(27);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gsiacceptance).HasColumnName("GSIAcceptance");

                entity.Property(e => e.LastUpdated).HasMaxLength(27);

                entity.Property(e => e.MonthlyRepaymentAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StartDate).HasMaxLength(27);

                entity.Property(e => e.TermsAndConditionAcceptedDate).HasMaxLength(27);

                entity.Property(e => e.TotalInterestAccrued).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Alat40LoanManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_LoanManagement");

                entity.Property(e => e.AccountNumberCredited).HasMaxLength(20);

                entity.Property(e => e.AlatAccountNumber).HasMaxLength(20);

                entity.Property(e => e.CallBackRequestId).HasMaxLength(100);

                entity.Property(e => e.ChannelId).HasMaxLength(20);

                entity.Property(e => e.Cif).HasMaxLength(20);

                entity.Property(e => e.DeviceLoanReferenceId).HasMaxLength(200);

                entity.Property(e => e.EquityAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EquityDebitAccount).HasMaxLength(20);

                entity.Property(e => e.LoanAccountNumber).HasMaxLength(20);
            });

            modelBuilder.Entity<Alat40LoginHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_LoginHistory");
            });

            modelBuilder.Entity<Alat40Profile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Profiles");

                entity.Property(e => e.ChangedPassword).HasMaxLength(27);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .HasColumnName("CIF");

                entity.Property(e => e.CustomerIdformerAlat).HasColumnName("CustomerIDFormerAlat");

                entity.Property(e => e.DateAccepted).HasMaxLength(27);

                entity.Property(e => e.DateActivated).HasMaxLength(27);

                entity.Property(e => e.DateDeactivated).HasMaxLength(27);

                entity.Property(e => e.Dob)
                    .HasMaxLength(27)
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.IsIdcardApproved).HasColumnName("IsIDCardApproved");

                entity.Property(e => e.IsIdcardUploaded).HasColumnName("IsIDCardUploaded");

                entity.Property(e => e.Kycstatus).HasColumnName("KYCStatus");

                entity.Property(e => e.LastDateGcmupdated)
                    .HasMaxLength(27)
                    .HasColumnName("LastDateGCMUpdated");

                entity.Property(e => e.LastLogin).HasMaxLength(27);

                entity.Property(e => e.Response).HasMaxLength(300);

                entity.Property(e => e.WmuserName)
                    .HasMaxLength(100)
                    .HasColumnName("WMUserName");
            });

            modelBuilder.Entity<Alat40ReactivationActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_ReactivationActivitys");

                entity.Property(e => e.Cif).HasColumnName("CIF");
            });

            modelBuilder.Entity<Alat40ReactivationRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_ReactivationRequests");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.ReactivationId).HasColumnName("ReactivationID");
            });

            modelBuilder.Entity<Alat40RemitaPaymentsTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_RemitaPaymentsTransactions");

                entity.Property(e => e.Charge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.TransAmount).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Alat40ResidentialAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_ResidentialAddress");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.Cif)
                    .HasMaxLength(15)
                    .HasColumnName("CIF");
            });

            modelBuilder.Entity<Alat40ReversalTransactionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_ReversalTransactionLog");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ChannelId).HasMaxLength(50);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .HasColumnName("CIF");

                entity.Property(e => e.PlatformReference).HasMaxLength(50);

                entity.Property(e => e.TransactionStan).HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<Alat40SettlementTransactionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_SettlementTransactionLog");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DigitalBankControllerSelector).HasColumnName("digitalBankControllerSelector");

                entity.Property(e => e.PlatformReference).HasMaxLength(100);
            });

            modelBuilder.Entity<Alat40TransactionLog>(entity =>
            {
                entity.ToTable("ALAT_4.0_TransactionLog");

                entity.HasIndex(e => e.TransactionType, "idx_TranType");

                entity.HasIndex(e => new { e.TransactionDate, e.TransactionStatus, e.SourceAccountNumber }, "idx_Trandate_St_acct");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CallBackUrl).IsUnicode(false);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.ClientTransactionRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrelationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTransactionDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(20);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionStan).HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferTransactionResponse).IsUnicode(false);
            });

            modelBuilder.Entity<Alat40VendorAddressVerificationResponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_VendorAddressVerificationResponses");
            });

            modelBuilder.Entity<Alat40VirtualCardActivitylog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_VirtualCardActivitylog");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.DateRequested).HasMaxLength(27);

                entity.Property(e => e.VirtualCardOperation).HasColumnName("virtualCardOperation");
            });

            modelBuilder.Entity<Alat40VirtualDollarCardFundMovementLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_VirtualDollarCardFundMovementLog");

                entity.Property(e => e.Charge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DateRequested).HasMaxLength(27);

                entity.Property(e => e.ForeignCurrencyAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LocalCurrencyAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentReference).HasColumnName("paymentReference");

                entity.Property(e => e.TotalDebitAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedDate).HasMaxLength(27);
            });

            modelBuilder.Entity<Alat40Virtualdollarcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALAT_4.0_Virtualdollarcards");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.CreatedDate).HasMaxLength(27);

                entity.Property(e => e.DeletedDate).HasMaxLength(27);

                entity.Property(e => e.FirstAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedDate).HasMaxLength(27);

                entity.Property(e => e.VirtualRepoId).HasColumnName("VIrtualRepoId");
            });

            modelBuilder.Entity<AlatTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alat_tran");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.SumTamt).HasColumnName("SUM(TAMT)");

                entity.Property(e => e.SumTcnt).HasColumnName("SUM(TCNT)");
            });

            modelBuilder.Entity<AnalyticsUser>(entity =>
            {
                entity.ToTable("AnalyticsUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(256);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsRegionalHead).HasColumnName("isRegionalHead");

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.ProfiledDate).HasColumnType("datetime");

                entity.Property(e => e.Region).HasMaxLength(256);

                entity.Property(e => e.SentProfiledMail).HasColumnName("sentProfiledMail");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zone).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Branch).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Region).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zone).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AuditTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuditTABLE");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AUDIT_DATE");

                entity.Property(e => e.AuditSolId)
                    .HasMaxLength(8)
                    .HasColumnName("AUDIT_SOL_ID");

                entity.Property(e => e.AuthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AUTH_DATE");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(15)
                    .HasColumnName("AUTH_ID");

                entity.Property(e => e.FuncCode)
                    .HasMaxLength(1)
                    .HasColumnName("FUNC_CODE");

                entity.Property(e => e.GlSubHeadCode)
                    .HasMaxLength(5)
                    .HasColumnName("GL_SUB_HEAD_CODE");

                entity.Property(e => e.InitSolId)
                    .HasMaxLength(8)
                    .HasColumnName("INIT_SOL_ID");

                entity.Property(e => e.ModifiedFieldsData)
                    .HasMaxLength(240)
                    .HasColumnName("MODIFIED_FIELDS_DATA");

                entity.Property(e => e.RefNum)
                    .HasMaxLength(15)
                    .HasColumnName("REF_NUM");

                entity.Property(e => e.Rmks)
                    .HasMaxLength(100)
                    .HasColumnName("RMKS");

                entity.Property(e => e.TableKey)
                    .HasMaxLength(100)
                    .HasColumnName("TABLE_KEY");

                entity.Property(e => e.TableName)
                    .HasMaxLength(12)
                    .HasColumnName("TABLE_NAME");
            });

            modelBuilder.Entity<AvgBal6mnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Avg_bal_6mnt");

                entity.HasIndex(e => e.Foracid, "idx_foracid");

                entity.Property(e => e.AvgBal6mnt1).HasColumnName("Avg_bal_6mnt");

                entity.Property(e => e.Foracid).HasMaxLength(50);
            });

            modelBuilder.Entity<CardableActive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cardable_active");

                entity.Property(e => e.CardedActiveAccounts).HasColumnName("Carded_Active_Accounts");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_date");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Zones)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CbnTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cbn_table");

                entity.Property(e => e.NoOfTransactions)
                    .HasMaxLength(38)
                    .HasColumnName("NO_OF_TRANSACTIONS");

                entity.Property(e => e.Report).HasMaxLength(17);

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TranMonth)
                    .HasMaxLength(36)
                    .HasColumnName("TRAN_MONTH");

                entity.Property(e => e.TranYear)
                    .HasMaxLength(38)
                    .HasColumnName("TRAN_YEAR");

                entity.Property(e => e.Volume)
                    .HasMaxLength(38)
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<CcbankCheque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCBANK_CHEQUE");

                entity.Property(e => e.BankDesc)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("BANK_DESC");

                entity.Property(e => e.BranchDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_DESC");

                entity.Property(e => e.CalcAmount)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("CALC_AMOUNT");

                entity.Property(e => e.ChequeId).HasColumnName("CHEQUE_ID");

                entity.Property(e => e.InOut)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IN_OUT");

                entity.Property(e => e.ProcessingDt).HasColumnName("PROCESSING_DT");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DESC");
            });

            modelBuilder.Entity<CcbankNeft>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCBANK_NEFT");

                entity.Property(e => e.BankDesc)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("BANK_DESC");

                entity.Property(e => e.BranchDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_DESC");

                entity.Property(e => e.CalcAmount)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("CALC_AMOUNT");

                entity.Property(e => e.InOut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("IN_OUT");

                entity.Property(e => e.NeftId).HasColumnName("NEFT_ID");

                entity.Property(e => e.ProcessingDt).HasColumnName("PROCESSING_DT");
            });

            modelBuilder.Entity<CcsmsSla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCSMS_SLA");

                entity.Property(e => e.CbnSla)
                    .HasMaxLength(255)
                    .HasColumnName("CBN SLA");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("Code ");

                entity.Property(e => e.ComplaintCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Complaint Category");

                entity.Property(e => e.CurrentSla)
                    .HasMaxLength(255)
                    .HasColumnName("Current SLA");

                entity.Property(e => e.DevSla).HasColumnName("Dev SLA");

                entity.Property(e => e.NewSla)
                    .HasMaxLength(255)
                    .HasColumnName("New SLA");

                entity.Property(e => e.ResolvingUnItDepartment)
                    .HasMaxLength(255)
                    .HasColumnName("Resolving UnIT DEPARTMENT");

                entity.Property(e => e.StakeholderSDebate)
                    .HasMaxLength(255)
                    .HasColumnName("Stakeholder's debate");

                entity.Property(e => e.SubCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Sub-category");
            });

            modelBuilder.Entity<ChurnCustomerDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("churn_customer_data");

                entity.Property(e => e.AccountPerCustomer).HasColumnName("account_per_customer");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("acct_opn_date");

                entity.Property(e => e.AcctYear).HasColumnName("Acct_year");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("acid");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("age_grp");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CrTranCnt).HasColumnName("cr_tran_cnt");

                entity.Property(e => e.Currentbal)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("currentbal");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(80)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DaySinceLastTran).HasColumnName("Day_Since_last_tran");

                entity.Property(e => e.DrTranCnt).HasColumnName("dr_tran_cnt");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IsAlatCustomer).HasColumnName("Is_Alat_Customer");

                entity.Property(e => e.IsBvnSupplied).HasColumnName("Is_BVN_Supplied");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("last_tran_date");

                entity.Property(e => e.RowNum).HasColumnName("Row_Num");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("sol_id");
            });

            modelBuilder.Entity<ChurnDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Churn_Data");

                entity.Property(e => e.AccountPerCustomer).HasColumnName("Account_Per_Customer");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("ACCT_opn_Date");

                entity.Property(e => e.AcctYear).HasColumnName("ACCT_Year");

                entity.Property(e => e.Acid).HasMaxLength(100);

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Grp");

                entity.Property(e => e.AverageBalance).HasColumnName("Average_Balance");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CrTranCnt).HasColumnName("CR_Tran_Cnt");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.DaySinceLastTran).HasColumnName("Day_Since_Last_Tran");

                entity.Property(e => e.DrTranCnt).HasColumnName("Dr_Tran_Cnt");

                entity.Property(e => e.Foracid).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.IsAlatCustomer).HasColumnName("Is_Alat_Customer");

                entity.Property(e => e.IsBvnSupplied).HasColumnName("Is_BVN_Supplied");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.RowNum).HasColumnName("Row_Num");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(100)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.SolId)
                    .HasMaxLength(100)
                    .HasColumnName("Sol_id");
            });

            modelBuilder.Entity<ChurnPrediction2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Churn_Prediction2");

                entity.HasIndex(e => new { e.Foracid, e.CifId }, "idx_acct_cif");

                entity.HasIndex(e => e.Segment, "idx_seg");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("acct_opn_date");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CurrentBalance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(100)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("last_tran_date");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_date");

                entity.Property(e => e.Segment)
                    .HasMaxLength(100)
                    .HasColumnName("segment");

                entity.Property(e => e.SolId)
                    .HasMaxLength(5)
                    .HasColumnName("sol_id");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.Tenor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ChurnPredictionBkup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Churn_Prediction_bkup");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("acct_opn_date");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CurrentBalance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(100)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("last_tran_date");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_date");

                entity.Property(e => e.Segment)
                    .HasMaxLength(100)
                    .HasColumnName("segment");

                entity.Property(e => e.SolId)
                    .HasMaxLength(5)
                    .HasColumnName("sol_id");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.Tenor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ClvDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLV_Data");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("age_grp");

                entity.Property(e => e.AvgBal).HasColumnName("AVG_BAL");

                entity.Property(e => e.CifId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CountOfTranLast180days).HasColumnName("count_of_tran_last_180days");

                entity.Property(e => e.CountOfTranLast365days).HasColumnName("count_of_tran_last_365days");

                entity.Property(e => e.CountOfTranLast90days).HasColumnName("count_of_tran_last_90days");

                entity.Property(e => e.CreditinflowLast180days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("creditinflow_last_180days");

                entity.Property(e => e.CreditinflowLast365days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("creditinflow_last_365days");

                entity.Property(e => e.CreditinflowLast90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("creditinflow_last_90days");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DaysSinceLastTran).HasColumnName("Days_Since_Last_Tran");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("employment_status");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("marital_status");

                entity.Property(e => e.NoOfAccts).HasColumnName("No of Accts");

                entity.Property(e => e.NorthBank).HasColumnName("North Bank");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("occupation");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Phone_no");

                entity.Property(e => e.SegmentationClass)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Segmentation_Class");

                entity.Property(e => e.SouthSouth).HasColumnName("South South");

                entity.Property(e => e.SouthWest).HasColumnName("South West");

                entity.Property(e => e.Staff)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("staff");

                entity.Property(e => e.Subsegment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueBranch).HasColumnName("Unique Branch");
            });

            modelBuilder.Entity<ClvPrediction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLV_Prediction");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.AvgBalance).HasColumnName("AVG_Balance");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.Clusters).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NoOfAccounts)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("No_of_Accounts");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_date");
            });

            modelBuilder.Entity<ClvPredictionTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLV_PredictionTable");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.AverageBalance).HasColumnName("Average_Balance");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.NoAccount).HasColumnName("No_Account");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.RunTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_Time");
            });

            modelBuilder.Entity<ConsolidatedCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("consolidated_cards");

                entity.HasIndex(e => new { e.AccountNumber, e.CifId, e.SchmCode }, "idx_acct_no");

                entity.HasIndex(e => new { e.AcctOpnDate, e.DateIssued }, "idx_date");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(50)
                    .HasColumnName("Acct_mgr_User_id");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(100)
                    .HasColumnName("Acct_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("Acct_Opn_Date");

                entity.Property(e => e.Balance).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.DateActivated).HasColumnType("date");

                entity.Property(e => e.DateIssued).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(50)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Schm_Desc");
            });

            modelBuilder.Entity<CrmuserAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRMUSER_Accounts");

                entity.HasIndex(e => new { e.Orgkey, e.Bvn, e.Email }, "idx_crmacct");

                entity.Property(e => e.Accountid)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Bocreatedby)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("BOCREATEDBY");

                entity.Property(e => e.Bodatecreated)
                    .HasColumnType("date")
                    .HasColumnName("BODATECREATED");

                entity.Property(e => e.Bodatemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("BODATEMODIFIED");

                entity.Property(e => e.Bomodifiedby)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("BOMODIFIEDBY");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(220)
                    .HasColumnName("BVN");

                entity.Property(e => e.Createduserid)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("CREATEDUSERID");

                entity.Property(e => e.CustDob)
                    .HasColumnType("date")
                    .HasColumnName("CUST_DOB");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(80)
                    .HasColumnName("CUST_FIRST_NAME");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("CUST_LAST_NAME");

                entity.Property(e => e.CustMiddleName)
                    .HasMaxLength(80)
                    .HasColumnName("CUST_MIDDLE_NAME");

                entity.Property(e => e.CustTypeCode)
                    .HasMaxLength(5)
                    .HasColumnName("CUST_TYPE_CODE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Iscorprep)
                    .HasMaxLength(1)
                    .HasColumnName("ISCORPREP");

                entity.Property(e => e.Isebankingenabled)
                    .HasMaxLength(1)
                    .HasColumnName("ISEBANKINGENABLED");

                entity.Property(e => e.Issmsbankingenabled)
                    .HasMaxLength(1)
                    .HasColumnName("ISSMSBANKINGENABLED");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .HasColumnName("OCCUPATION");

                entity.Property(e => e.Orgkey)
                    .HasMaxLength(50)
                    .HasColumnName("ORGKEY");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.PrimarySolId)
                    .HasMaxLength(8)
                    .HasColumnName("PRIMARY_SOL_ID");

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .HasColumnName("SECTOR");

                entity.Property(e => e.SegmentationClass)
                    .HasMaxLength(100)
                    .HasColumnName("SEGMENTATION_CLASS");

                entity.Property(e => e.Staffflag)
                    .HasMaxLength(25)
                    .HasColumnName("STAFFFLAG");

                entity.Property(e => e.Subsector)
                    .HasMaxLength(50)
                    .HasColumnName("SUBSECTOR");

                entity.Property(e => e.Subsegment)
                    .HasMaxLength(50)
                    .HasColumnName("SUBSEGMENT");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(100)
                    .HasColumnName("UNIQUEID");
            });

            modelBuilder.Entity<CrmuserAccountsUpdateStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRMUSER_Accounts_UpdateStg");

                entity.Property(e => e.Accountid)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Bodatemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("BODATEMODIFIED");

                entity.Property(e => e.Bomodifiedby)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("BOMODIFIEDBY");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(220)
                    .HasColumnName("BVN");

                entity.Property(e => e.CustDob)
                    .HasColumnType("date")
                    .HasColumnName("CUST_DOB");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(80)
                    .HasColumnName("CUST_FIRST_NAME");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("CUST_LAST_NAME");

                entity.Property(e => e.CustMiddleName)
                    .HasMaxLength(80)
                    .HasColumnName("CUST_MIDDLE_NAME");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .HasColumnName("OCCUPATION");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.PrimarySolId)
                    .HasMaxLength(8)
                    .HasColumnName("PRIMARY_SOL_ID");

                entity.Property(e => e.SegmentationClass)
                    .HasMaxLength(100)
                    .HasColumnName("SEGMENTATION_CLASS");

                entity.Property(e => e.Staffflag)
                    .HasMaxLength(25)
                    .HasColumnName("STAFFFLAG");

                entity.Property(e => e.Subsegment)
                    .HasMaxLength(50)
                    .HasColumnName("SUBSEGMENT");
            });

            modelBuilder.Entity<CustomRtgsMt103>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSTOM.RTGS_MT103 ");

                entity.Property(e => e.BankId)
                    .HasMaxLength(8)
                    .HasColumnName("BANK_ID");

                entity.Property(e => e.BenAddr)
                    .HasMaxLength(200)
                    .HasColumnName("BEN_ADDR");

                entity.Property(e => e.BenBankAcctNum)
                    .HasMaxLength(16)
                    .HasColumnName("BEN_BANK_ACCT_NUM");

                entity.Property(e => e.BenBankShortName)
                    .HasMaxLength(10)
                    .HasColumnName("BEN_BANK_SHORT_NAME");

                entity.Property(e => e.BenBankSwiftId)
                    .HasMaxLength(12)
                    .HasColumnName("BEN_BANK_SWIFT_ID");

                entity.Property(e => e.BenForacid)
                    .HasMaxLength(20)
                    .HasColumnName("BEN_FORACID");

                entity.Property(e => e.BenName)
                    .HasMaxLength(80)
                    .HasColumnName("BEN_NAME");

                entity.Property(e => e.CaptureDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CAPTURE_DATE");

                entity.Property(e => e.ChqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHQ_DATE");

                entity.Property(e => e.ChqNum)
                    .HasMaxLength(13)
                    .HasColumnName("CHQ_NUM");

                entity.Property(e => e.ChrgAcctId)
                    .HasMaxLength(16)
                    .HasColumnName("CHRG_ACCT_ID");

                entity.Property(e => e.ChrgBearer)
                    .HasMaxLength(8)
                    .HasColumnName("CHRG_BEARER");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.EventChrgeId)
                    .HasMaxLength(16)
                    .HasColumnName("EVENT_CHRGE_ID");

                entity.Property(e => e.InitBrSort)
                    .HasMaxLength(15)
                    .HasColumnName("INIT_BR_SORT");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.MsgPriority)
                    .HasMaxLength(10)
                    .HasColumnName("MSG_PRIORITY");

                entity.Property(e => e.MsgType)
                    .HasMaxLength(10)
                    .HasColumnName("MSG_TYPE");

                entity.Property(e => e.PstdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PSTD_FLG");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.RefNum)
                    .HasMaxLength(20)
                    .HasColumnName("REF_NUM");

                entity.Property(e => e.SenderRecverInfo)
                    .HasMaxLength(200)
                    .HasColumnName("SENDER_RECVER_INFO");

                entity.Property(e => e.SendersAcct)
                    .HasMaxLength(20)
                    .HasColumnName("SENDERS_ACCT");

                entity.Property(e => e.SendersAddr)
                    .HasMaxLength(200)
                    .HasColumnName("SENDERS_ADDR");

                entity.Property(e => e.SendersName)
                    .HasMaxLength(80)
                    .HasColumnName("SENDERS_NAME");

                entity.Property(e => e.SendingBankAcctNum)
                    .HasMaxLength(16)
                    .HasColumnName("SENDING_BANK_ACCT_NUM");

                entity.Property(e => e.SendingBankSwiftId)
                    .HasMaxLength(12)
                    .HasColumnName("SENDING_BANK_SWIFT_ID");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("TRAN_AMT");

                entity.Property(e => e.TranCode)
                    .HasMaxLength(10)
                    .HasColumnName("TRAN_CODE");

                entity.Property(e => e.TranDetail)
                    .HasMaxLength(200)
                    .HasColumnName("TRAN_DETAIL");

                entity.Property(e => e.TranRmks)
                    .HasMaxLength(30)
                    .HasColumnName("TRAN_RMKS");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");

                entity.Property(e => e.VerFlg)
                    .HasMaxLength(1)
                    .HasColumnName("VER_FLG");
            });

            modelBuilder.Entity<CustomRtgsMt202>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSTOM.RTGS_MT202");

                entity.Property(e => e.BankId)
                    .HasMaxLength(8)
                    .HasColumnName("BANK_ID");

                entity.Property(e => e.BenBankAcctNum)
                    .HasMaxLength(16)
                    .HasColumnName("BEN_BANK_ACCT_NUM");

                entity.Property(e => e.BenBankShortName)
                    .HasMaxLength(10)
                    .HasColumnName("BEN_BANK_SHORT_NAME");

                entity.Property(e => e.BenBankSwiftId)
                    .HasMaxLength(12)
                    .HasColumnName("BEN_BANK_SWIFT_ID");

                entity.Property(e => e.ChqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHQ_DATE");

                entity.Property(e => e.ChqNum)
                    .HasMaxLength(16)
                    .HasColumnName("CHQ_NUM");

                entity.Property(e => e.ChrgAcctId)
                    .HasMaxLength(20)
                    .HasColumnName("CHRG_ACCT_ID");

                entity.Property(e => e.CoinDenom)
                    .HasMaxLength(40)
                    .HasColumnName("COIN_DENOM");

                entity.Property(e => e.CrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("CRNCY_CODE");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.DelTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DEL_TIME");

                entity.Property(e => e.DelUserId)
                    .HasMaxLength(15)
                    .HasColumnName("DEL_USER_ID");

                entity.Property(e => e.EarliestTime)
                    .HasMaxLength(5)
                    .HasColumnName("EARLIEST_TIME");

                entity.Property(e => e.EventChrgeId)
                    .HasMaxLength(16)
                    .HasColumnName("EVENT_CHRGE_ID");

                entity.Property(e => e.LastTime)
                    .HasMaxLength(5)
                    .HasColumnName("LAST_TIME");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.MsgPriority)
                    .HasMaxLength(10)
                    .HasColumnName("MSG_PRIORITY");

                entity.Property(e => e.MsgType)
                    .HasMaxLength(10)
                    .HasColumnName("MSG_TYPE");

                entity.Property(e => e.NoteDenom)
                    .HasMaxLength(40)
                    .HasColumnName("NOTE_DENOM");

                entity.Property(e => e.Oid)
                    .HasMaxLength(40)
                    .HasColumnName("OID");

                entity.Property(e => e.PstdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PSTD_FLG");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.RefNum)
                    .HasMaxLength(20)
                    .HasColumnName("REF_NUM");

                entity.Property(e => e.RejectTime)
                    .HasMaxLength(5)
                    .HasColumnName("REJECT_TIME");

                entity.Property(e => e.ReserveCredit)
                    .HasMaxLength(210)
                    .HasColumnName("RESERVE_CREDIT");

                entity.Property(e => e.ReserveDebit)
                    .HasMaxLength(210)
                    .HasColumnName("RESERVE_DEBIT");

                entity.Property(e => e.SenderRecverInfo)
                    .HasMaxLength(200)
                    .HasColumnName("SENDER_RECVER_INFO");

                entity.Property(e => e.SendersAcct)
                    .HasMaxLength(20)
                    .HasColumnName("SENDERS_ACCT");

                entity.Property(e => e.SendersName)
                    .HasMaxLength(80)
                    .HasColumnName("SENDERS_NAME");

                entity.Property(e => e.SendingBankAcctNum)
                    .HasMaxLength(16)
                    .HasColumnName("SENDING_BANK_ACCT_NUM");

                entity.Property(e => e.SendingBankSwiftId)
                    .HasMaxLength(12)
                    .HasColumnName("SENDING_BANK_SWIFT_ID");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("TRAN_AMT");

                entity.Property(e => e.TranCode)
                    .HasMaxLength(10)
                    .HasColumnName("TRAN_CODE");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");

                entity.Property(e => e.VerFlg)
                    .HasMaxLength(1)
                    .HasColumnName("VER_FLG");

                entity.Property(e => e.VerTime)
                    .HasColumnType("datetime")
                    .HasColumnName("VER_TIME");

                entity.Property(e => e.VerUserId)
                    .HasMaxLength(15)
                    .HasColumnName("VER_USER_ID");
            });

            modelBuilder.Entity<CustomerChurnNewDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Churn_New_Data");

                entity.Property(e => e.AccountPerCustomer).HasColumnName("Account_Per_Customer");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpenDate)
                    .HasColumnType("date")
                    .HasColumnName("Acct_open_date");

                entity.Property(e => e.AcctYear).HasColumnName("Acct_Year");

                entity.Property(e => e.Acid)
                    .HasMaxLength(100)
                    .HasColumnName("acid");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CrTranCnt).HasColumnName("Cr_Tran_Cnt");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.DaysSinceLastTran).HasColumnName("Days_Since_Last_Tran");

                entity.Property(e => e.DrTranCnt).HasColumnName("Dr_Tran_Cnt");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(100)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .HasColumnName("gender");

                entity.Property(e => e.IsAlatCustomer).HasColumnName("Is_Alat_Customer");

                entity.Property(e => e.IsBvnSupplied).HasColumnName("Is_BVN_supplied");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.RowNum).HasColumnName("Row_Num");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(100)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.SolId)
                    .HasMaxLength(100)
                    .HasColumnName("sol_id");
            });

            modelBuilder.Entity<CustomerCluster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Clusters");

                entity.Property(e => e.CifId)
                    .HasMaxLength(20)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.DestinationBank).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ResidenceState)
                    .HasMaxLength(100)
                    .HasColumnName("Residence_State");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_Date");

                entity.Property(e => e.SumAmount).HasColumnName("Sum_Amount");

                entity.Property(e => e.TotalTransactionVolume).HasColumnName("Total_Transaction_Volume");

                entity.Property(e => e.TransfersToPaycom)
                    .HasMaxLength(5)
                    .HasColumnName("Transfers_to_paycom");
            });

            modelBuilder.Entity<CustomerCluster1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerCluster");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SourceAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SumAmount)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Sum_Amount");

                entity.Property(e => e.Tcount).HasColumnName("TCount");

                entity.Property(e => e.TotalTransactionVolume)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Total_Transaction_Volume");
            });

            modelBuilder.Entity<CustomerProfitability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Profitability");

                entity.HasIndex(e => new { e.RunDate, e.Acid, e.CifId }, "idx_acid_date_cif");

                entity.HasIndex(e => e.Foracid, "idx_foracid");

                entity.Property(e => e.Acid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACID");

                entity.Property(e => e.AverageBal).HasColumnName("AVERAGE_BAL");

                entity.Property(e => e.CifId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FORACID");

                entity.Property(e => e.IncomeOnLr).HasColumnName("Income on LR ");

                entity.Property(e => e.IntExp).HasColumnName("INT_EXP");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");
            });

            modelBuilder.Entity<Customercluster2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customerclusters");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthName).HasMaxLength(30);

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(30);

                entity.Property(e => e.SumAmount)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Sum_Amount");

                entity.Property(e => e.Tcount).HasColumnName("TCount");

                entity.Property(e => e.TotalTransactionVolume)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Total_Transaction_Volume");
            });

            modelBuilder.Entity<Customerclusters2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customerclusters2");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(80)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthName).HasMaxLength(30);

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(30);

                entity.Property(e => e.SumAmount)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Sum_Amount");

                entity.Property(e => e.Tcount).HasColumnName("TCount");

                entity.Property(e => e.TotalTransactionVolume)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Total_Transaction_Volume");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomersProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers_Profile");

                entity.Property(e => e.Acid).HasMaxLength(100);

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.Alat)
                    .HasMaxLength(100)
                    .HasColumnName("ALAT");

                entity.Property(e => e.AlatGoals)
                    .HasMaxLength(100)
                    .HasColumnName("ALAT_GOALS");

                entity.Property(e => e.BusinessAccount)
                    .HasMaxLength(100)
                    .HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards)
                    .HasMaxLength(100)
                    .HasColumnName("CARDS");

                entity.Property(e => e.ChurnStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Churn_Status");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CreditCardAccount)
                    .HasMaxLength(100)
                    .HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount)
                    .HasMaxLength(100)
                    .HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CurrentProduct).HasColumnName("Current_Product");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(1000)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.DomiciliaryAccount)
                    .HasMaxLength(100)
                    .HasColumnName("DOMICILIARY_ACCOUNT");

                entity.Property(e => e.Foracid).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan)
                    .HasMaxLength(100)
                    .HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan)
                    .HasMaxLength(100)
                    .HasColumnName("LOAN");

                entity.Property(e => e.Mortgage)
                    .HasMaxLength(100)
                    .HasColumnName("MORTGAGE");

                entity.Property(e => e.NoAccount).HasColumnName("No_Account");

                entity.Property(e => e.SavingsAccount)
                    .HasMaxLength(100)
                    .HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.Segmentation).HasMaxLength(100);

                entity.Property(e => e.TermDeposit)
                    .HasMaxLength(100)
                    .HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.Ussd)
                    .HasMaxLength(100)
                    .HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure)
                    .HasMaxLength(100)
                    .HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<DataRequestUser>(entity =>
            {
                entity.ToTable("DataRequestUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(256);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsRegionalHead).HasColumnName("isRegionalHead");

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.ProfiledDate).HasColumnType("datetime");

                entity.Property(e => e.Region).HasMaxLength(256);

                entity.Property(e => e.SentProfiledMail).HasColumnName("sentProfiledMail");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zone).HasMaxLength(256);
            });

            modelBuilder.Entity<Dd3portalUser>(entity =>
            {
                entity.ToTable("DD3PortalUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(256);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsRegionalHead).HasColumnName("isRegionalHead");

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.ProfiledDate).HasColumnType("datetime");

                entity.Property(e => e.Region).HasMaxLength(256);

                entity.Property(e => e.SentProfiledMail).HasColumnName("sentProfiledMail");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zone).HasMaxLength(256);
            });

            modelBuilder.Entity<Demographic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Demographic");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Bocreatedby).HasColumnName("BOCREATEDBY");

                entity.Property(e => e.Bodatecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("BODATECREATED");

                entity.Property(e => e.Bodatemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("BODATEMODIFIED");

                entity.Property(e => e.Bomodifiedby).HasColumnName("BOMODIFIEDBY");

                entity.Property(e => e.Bvn)
                    .IsUnicode(false)
                    .HasColumnName("BVN");

                entity.Property(e => e.Createduserid).HasColumnName("CREATEDUSERID");

                entity.Property(e => e.CustDob)
                    .HasColumnType("date")
                    .HasColumnName("CUST_DOB");

                entity.Property(e => e.CustFirstName)
                    .IsUnicode(false)
                    .HasColumnName("CUST_FIRST_NAME");

                entity.Property(e => e.CustLastName)
                    .IsUnicode(false)
                    .HasColumnName("CUST_LAST_NAME");

                entity.Property(e => e.CustMiddleName)
                    .IsUnicode(false)
                    .HasColumnName("CUST_MIDDLE_NAME");

                entity.Property(e => e.CustTypeCode)
                    .IsUnicode(false)
                    .HasColumnName("CUST_TYPE_CODE");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EmploymentStatus)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYMENT_STATUS");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Iscorprep)
                    .IsUnicode(false)
                    .HasColumnName("ISCORPREP");

                entity.Property(e => e.Isebankingenabled)
                    .IsUnicode(false)
                    .HasColumnName("ISEBANKINGENABLED");

                entity.Property(e => e.Issmsbankingenabled)
                    .IsUnicode(false)
                    .HasColumnName("ISSMSBANKINGENABLED");

                entity.Property(e => e.MaritalStatus)
                    .IsUnicode(false)
                    .HasColumnName("MARITAL_STATUS");

                entity.Property(e => e.Occupation)
                    .IsUnicode(false)
                    .HasColumnName("OCCUPATION");

                entity.Property(e => e.Orgkey)
                    .IsUnicode(false)
                    .HasColumnName("ORGKEY");

                entity.Property(e => e.PhoneNo)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.PrimarySolId)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_SOL_ID");

                entity.Property(e => e.Religion)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION");

                entity.Property(e => e.Sector)
                    .IsUnicode(false)
                    .HasColumnName("SECTOR");

                entity.Property(e => e.SegmentationClass)
                    .IsUnicode(false)
                    .HasColumnName("SEGMENTATION_CLASS");

                entity.Property(e => e.Staffflag)
                    .IsUnicode(false)
                    .HasColumnName("STAFFFLAG");

                entity.Property(e => e.Subsector)
                    .IsUnicode(false)
                    .HasColumnName("SUBSECTOR");

                entity.Property(e => e.Subsegment)
                    .IsUnicode(false)
                    .HasColumnName("SUBSEGMENT");

                entity.Property(e => e.Uniqueid)
                    .IsUnicode(false)
                    .HasColumnName("UNIQUEID");
            });

            modelBuilder.Entity<DigitallendingPrediction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Digitallending_Prediction");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Experience).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Netincome).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Purpose).HasMaxLength(100);

                entity.Property(e => e.TenorMonth)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Tenor_Month");
            });

            modelBuilder.Entity<DigitallendingTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Digitallending_test");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Amountrequested).HasColumnName("amountrequested");

                entity.Property(e => e.Cif)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.LoanPurpose).HasColumnName("loan_purpose");

                entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Netincome).HasColumnName("netincome");

                entity.Property(e => e.TenorMonth).HasColumnName("tenor_month");
            });

            modelBuilder.Entity<DimDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dim_date");

                entity.Property(e => e.BbgWeekInMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_WEEK_IN_MONTH");

                entity.Property(e => e.BbgWk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_WK");

                entity.Property(e => e.CalendarHalfYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_HALF_YEAR");

                entity.Property(e => e.CalendarQuarter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_QUARTER");

                entity.Property(e => e.CalendarYearHalfYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_YEAR_HALF_YEAR");

                entity.Property(e => e.CalendarYearMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_YEAR_MONTH");

                entity.Property(e => e.CalendarYearQuarter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALENDAR_YEAR_QUARTER");

                entity.Property(e => e.DayInMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAY_IN_MONTH");

                entity.Property(e => e.DayInYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAY_IN_YEAR");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAY_NAME");

                entity.Property(e => e.DayShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAY_SHORT_NAME");

                entity.Property(e => e.DisplayDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_DATE");

                entity.Property(e => e.DwDateKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DW_DATE_KEY");

                entity.Property(e => e.DwEndDatetime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DW_END_DATETIME");

                entity.Property(e => e.DwStartDatetime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DW_START_DATETIME");

                entity.Property(e => e.DwStatusFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DW_STATUS_FLAG");

                entity.Property(e => e.FinancialHalfYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINANCIAL_HALF_YEAR");

                entity.Property(e => e.FinancialQuarter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINANCIAL_QUARTER");

                entity.Property(e => e.FinancialYearHalfYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINANCIAL_YEAR_HALF_YEAR");

                entity.Property(e => e.FinancialYearMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINANCIAL_YEAR_MONTH");

                entity.Property(e => e.FinancialYearQuarter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FINANCIAL_YEAR_QUARTER");

                entity.Property(e => e.FullDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_DATE");

                entity.Property(e => e.HolidayIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_INDICATOR");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_NAME");

                entity.Property(e => e.LastDayInMonthIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_DAY_IN_MONTH_INDICATOR");

                entity.Property(e => e.MonthName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MONTH_NAME");

                entity.Property(e => e.MonthNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MONTH_NUMBER");

                entity.Property(e => e.MonthShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MONTH_SHORT_NAME");

                entity.Property(e => e.OrdinalWorkingDays)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ordinal_working_days");

                entity.Property(e => e.PKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_key");

                entity.Property(e => e.WeekInYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEEK_IN_YEAR");

                entity.Property(e => e.WeekInYearOpcom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEEK_IN_YEAR_OPCOM");

                entity.Property(e => e.WeekendIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEEKEND_INDICATOR");

                entity.Property(e => e.Weekinmonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("weekinmonth");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YEAR");

                entity.Property(e => e.YearWeek)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_WEEK");
            });

            modelBuilder.Entity<FeeIncome>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeeIncome");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.FeeIncome1)
                    .HasColumnType("decimal(30, 2)")
                    .HasColumnName("FEE_INCOME");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");
            });

            modelBuilder.Entity<FinDtt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_DTT");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.FlowCode)
                    .HasMaxLength(2)
                    .HasColumnName("FLOW_CODE");

                entity.Property(e => e.PartTranSrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("PART_TRAN_SRL_NUM");

                entity.Property(e => e.PartTranType)
                    .HasMaxLength(1)
                    .HasColumnName("PART_TRAN_TYPE");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("TRAN_AMT");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRAN_DATE");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("TRAN_ID");

                entity.Property(e => e.TranParticulars)
                    .HasMaxLength(50)
                    .HasColumnName("TRAN_PARTICULARS");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");
            });

            modelBuilder.Entity<FinEit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_EIT");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(12)
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(5)
                    .HasColumnName("ENTITY_TYPE");

                entity.Property(e => e.InterestRate)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("INTEREST_RATE");

                entity.Property(e => e.NrmlInterestAmountCr)
                    .HasColumnType("numeric(22, 6)")
                    .HasColumnName("NRML_INTEREST_AMOUNT_CR");
            });

            modelBuilder.Entity<FinTam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_TAM");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.DepositAmount)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("DEPOSIT_AMOUNT");

                entity.Property(e => e.DepositPeriodDays)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("DEPOSIT_PERIOD_DAYS");

                entity.Property(e => e.MaturityAmount)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("MATURITY_AMOUNT");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MATURITY_DATE");

                entity.Property(e => e.RepaymentAcid)
                    .HasMaxLength(11)
                    .HasColumnName("REPAYMENT_ACID");
            });

            modelBuilder.Entity<FinUpr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fin_UPR");

                entity.Property(e => e.AppLangCode)
                    .HasMaxLength(10)
                    .HasColumnName("APP_LANG_CODE");

                entity.Property(e => e.AuthUserId)
                    .HasMaxLength(15)
                    .HasColumnName("AUTH_USER_ID");

                entity.Property(e => e.DefaultTermId)
                    .HasMaxLength(15)
                    .HasColumnName("DEFAULT_TERM_ID");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.EnableInqAuditFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ENABLE_INQ_AUDIT_FLG");

                entity.Property(e => e.EntityCreFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ENTITY_CRE_FLG");

                entity.Property(e => e.FreeCode1)
                    .HasMaxLength(5)
                    .HasColumnName("FREE_CODE1");

                entity.Property(e => e.HomeBankId)
                    .HasMaxLength(8)
                    .HasColumnName("HOME_BANK_ID");

                entity.Property(e => e.InqAuditEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INQ_AUDIT_END_DATE");

                entity.Property(e => e.InqAuditStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INQ_AUDIT_START_DATE");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.MultiBankUserProfileId)
                    .HasMaxLength(15)
                    .HasColumnName("MULTI_BANK_USER_PROFILE_ID");

                entity.Property(e => e.NewUserFlg)
                    .HasMaxLength(1)
                    .HasColumnName("NEW_USER_FLG");

                entity.Property(e => e.ProxyPostAllwd)
                    .HasMaxLength(1)
                    .HasColumnName("PROXY_POST_ALLWD");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.RelationshipManagerFlg)
                    .HasMaxLength(1)
                    .HasColumnName("RELATIONSHIP_MANAGER_FLG");

                entity.Property(e => e.RemoteAccessFlg)
                    .HasMaxLength(1)
                    .HasColumnName("REMOTE_ACCESS_FLG");

                entity.Property(e => e.Rmtliteralflg)
                    .HasMaxLength(1)
                    .HasColumnName("RMTLITERALFLG");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(15)
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TotModTimes)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TOT_MOD_TIMES");

                entity.Property(e => e.TsCnt)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TS_CNT");

                entity.Property(e => e.UserAcctExpyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_ACCT_EXPY_DATE");

                entity.Property(e => e.UserApplName)
                    .HasMaxLength(2)
                    .HasColumnName("USER_APPL_NAME");

                entity.Property(e => e.UserDisabledFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_DISABLED_FROM_DATE");

                entity.Property(e => e.UserDisabledUptoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_DISABLED_UPTO_DATE");

                entity.Property(e => e.UserEmpId)
                    .HasMaxLength(10)
                    .HasColumnName("USER_EMP_ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(15)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.UserLoggedOnFlg)
                    .HasMaxLength(1)
                    .HasColumnName("USER_LOGGED_ON_FLG");

                entity.Property(e => e.UserLoginTimeHigh)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_LOGIN_TIME_HIGH");

                entity.Property(e => e.UserLoginTimeLow)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_LOGIN_TIME_LOW");

                entity.Property(e => e.UserMaxInactiveTime)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("USER_MAX_INACTIVE_TIME");

                entity.Property(e => e.UserPw)
                    .HasMaxLength(70)
                    .HasColumnName("USER_PW")
                    .IsFixedLength(true);

                entity.Property(e => e.UserPwExpyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_PW_EXPY_DATE");

                entity.Property(e => e.UserSolTenor)
                    .HasMaxLength(1)
                    .HasColumnName("USER_SOL_TENOR");

                entity.Property(e => e.UserSvsGrpName)
                    .HasMaxLength(50)
                    .HasColumnName("USER_SVS_GRP_NAME");

                entity.Property(e => e.UserTempWorkClass)
                    .HasMaxLength(3)
                    .HasColumnName("USER_TEMP_WORK_CLASS");

                entity.Property(e => e.UserTmpWrkClassEffUpto)
                    .HasColumnType("datetime")
                    .HasColumnName("USER_TMP_WRK_CLASS_EFF_UPTO");

                entity.Property(e => e.UserWorkClass)
                    .HasMaxLength(3)
                    .HasColumnName("USER_WORK_CLASS");

                entity.Property(e => e.ViewScheduledRptFlg)
                    .HasMaxLength(1)
                    .HasColumnName("VIEW_SCHEDULED_RPT_FLG");

                entity.Property(e => e.VirtualFlg)
                    .HasMaxLength(1)
                    .HasColumnName("VIRTUAL_FLG");
            });

            modelBuilder.Entity<FormatedPhoneNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("formated_Phone_no");

                entity.Property(e => e.CifId)
                    .HasMaxLength(15)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(40)
                    .HasColumnName("phone_no");
            });

            modelBuilder.Entity<Gamtable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAMTABLE");

                entity.HasIndex(e => new { e.SchmCode, e.SchmDesc, e.SolId }, "NonClusteredIndex-20210119-085244");

                entity.HasIndex(e => e.Foracid, "idx_foracid");

                entity.Property(e => e.AcctClassificationFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLASSIFICATION_FLG");

                entity.Property(e => e.AcctClsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_CLS_DATE");

                entity.Property(e => e.AcctClsFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLS_FLG");

                entity.Property(e => e.AcctCrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("ACCT_CRNCY_CODE");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.AcctOwnership)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_OWNERSHIP");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.BalOnFrezDate)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("BAL_ON_FREZ_DATE");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(5)
                    .HasColumnName("CHANNEL_ID");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.ClrBalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CLR_BAL_AMT");

                entity.Property(e => e.CumCrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_CR_AMT");

                entity.Property(e => e.CumDrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_DR_AMT");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.FrezCode)
                    .HasMaxLength(1)
                    .HasColumnName("FREZ_CODE");

                entity.Property(e => e.FrezReasonCode)
                    .HasMaxLength(5)
                    .HasColumnName("FREZ_REASON_CODE");

                entity.Property(e => e.FxCumCrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("FX_CUM_CR_AMT");

                entity.Property(e => e.FxCumDrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("FX_CUM_DR_AMT");

                entity.Property(e => e.GlSubHeadCode)
                    .HasMaxLength(5)
                    .HasColumnName("GL_SUB_HEAD_CODE");

                entity.Property(e => e.IntCollFlg)
                    .HasMaxLength(1)
                    .HasColumnName("INT_COLL_FLG");

                entity.Property(e => e.IntPaidFlg)
                    .HasMaxLength(1)
                    .HasColumnName("INT_PAID_FLG");

                entity.Property(e => e.LastAnyTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_ANY_TRAN_DATE");

                entity.Property(e => e.LastFrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_FREZ_DATE");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE");

                entity.Property(e => e.LastTranDateCr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_CR");

                entity.Property(e => e.LastTranDateDr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_DR");

                entity.Property(e => e.LastTranIdCr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_CR");

                entity.Property(e => e.LastTranIdDr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_DR");

                entity.Property(e => e.LastUnfrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_UNFREZ_DATE");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.LienAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("LIEN_AMT");

                entity.Property(e => e.MinValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MIN_VALUE_DATE");

                entity.Property(e => e.NairaBalance)
                    .HasMaxLength(38)
                    .HasColumnName("NAIRA_BALANCE");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.SanctLim)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("SANCT_LIM");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SchmType)
                    .HasMaxLength(3)
                    .HasColumnName("SCHM_TYPE");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TwoDaysBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("TWO_DAYS_BAL_NAIREQV");

                entity.Property(e => e.YstdBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("YSTD_BAL_NAIREQV");
            });

            modelBuilder.Entity<GamtableStageUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GAMTABLE_STAGE_UPDATE");

                entity.Property(e => e.AcctClsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_CLS_DATE");

                entity.Property(e => e.AcctClsFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLS_FLG");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctOwnership)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_OWNERSHIP");

                entity.Property(e => e.ClrBalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CLR_BAL_AMT");

                entity.Property(e => e.CumCrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_CR_AMT");

                entity.Property(e => e.CumDrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_DR_AMT");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.FrezCode)
                    .HasMaxLength(1)
                    .HasColumnName("FREZ_CODE");

                entity.Property(e => e.FrezReasonCode)
                    .HasMaxLength(5)
                    .HasColumnName("FREZ_REASON_CODE");

                entity.Property(e => e.LastAnyTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_ANY_TRAN_DATE");

                entity.Property(e => e.LastFrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_FREZ_DATE");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE");

                entity.Property(e => e.LastTranDateCr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_CR");

                entity.Property(e => e.LastTranDateDr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_DR");

                entity.Property(e => e.LastTranIdCr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_CR");

                entity.Property(e => e.LastTranIdDr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_DR");

                entity.Property(e => e.LastUnfrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_UNFREZ_DATE");

                entity.Property(e => e.NairaBalance)
                    .HasMaxLength(38)
                    .HasColumnName("NAIRA_BALANCE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TwoDaysBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("TWO_DAYS_BAL_NAIREQV");

                entity.Property(e => e.YstdBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("YSTD_BAL_NAIREQV");
            });

            modelBuilder.Entity<GetAccountManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Get_Account_Manager");

                entity.Property(e => e.Alt1EmpName)
                    .HasMaxLength(40)
                    .HasColumnName("ALT1_EMP_NAME");

                entity.Property(e => e.Alt1EmpShortName)
                    .HasMaxLength(10)
                    .HasColumnName("ALT1_EMP_SHORT_NAME");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.EmpDesig)
                    .HasMaxLength(5)
                    .HasColumnName("EMP_DESIG");

                entity.Property(e => e.EmpEmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EMP_EMAIL_ID");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EMP_ID");

                entity.Property(e => e.EmpIntls)
                    .HasMaxLength(5)
                    .HasColumnName("EMP_INTLS");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpShortName)
                    .HasMaxLength(10)
                    .HasColumnName("EMP_SHORT_NAME");

                entity.Property(e => e.EmpSignPowerAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("EMP_SIGN_POWER_AMT");

                entity.Property(e => e.EmpSignPowerNum)
                    .HasColumnType("numeric(9, 0)")
                    .HasColumnName("EMP_SIGN_POWER_NUM");

                entity.Property(e => e.EmpStat)
                    .HasMaxLength(2)
                    .HasColumnName("EMP_STAT");

                entity.Property(e => e.EntityCreFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ENTITY_CRE_FLG");

                entity.Property(e => e.IsHeadTeller)
                    .HasMaxLength(1)
                    .HasColumnName("IS_HEAD_TELLER");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TotModTimes)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TOT_MOD_TIMES");

                entity.Property(e => e.TsCnt)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TS_CNT");
            });

            modelBuilder.Entity<GoalLiquidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Goal_Liquidation");

                entity.Property(e => e.AcctClsDate)
                    .HasColumnType("date")
                    .HasColumnName("ACCT_CLS_DATE");

                entity.Property(e => e.AcctClsFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLS_FLG");

                entity.Property(e => e.Branch)
                    .HasMaxLength(132)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Datebooked)
                    .HasColumnType("date")
                    .HasColumnName("DATEBOOKED");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.GoalName)
                    .HasMaxLength(80)
                    .HasColumnName("GOAL_NAME");

                entity.Property(e => e.LiquidatedAmt)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("LIQUIDATED_AMT");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(15)
                    .HasColumnName("STAFF_ID");
            });

            modelBuilder.Entity<Gsptable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GSPTABLE");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SchmType)
                    .HasMaxLength(3)
                    .HasColumnName("SCHM_TYPE");
            });

            modelBuilder.Entity<Htdaggregate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTDAggregate");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.CrCnt)
                    .HasMaxLength(38)
                    .HasColumnName("CR_CNT");

                entity.Property(e => e.CrVol)
                    .HasMaxLength(38)
                    .HasColumnName("CR_VOL");

                entity.Property(e => e.DrCnt)
                    .HasMaxLength(38)
                    .HasColumnName("DR_CNT");

                entity.Property(e => e.DrVol)
                    .HasMaxLength(38)
                    .HasColumnName("DR_VOL");
            });

            modelBuilder.Entity<Htdstat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTDStats");

                entity.Property(e => e.Acid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("acid");

                entity.Property(e => e.CifId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CountOfDrTranLast180days).HasColumnName("count_of_Dr_tran_last_180days");

                entity.Property(e => e.CountOfDrTranLast90days).HasColumnName("count_of_Dr_tran_last_90days");

                entity.Property(e => e.CountOfTranLast180days).HasColumnName("count_of_tran_last_180days");

                entity.Property(e => e.CountOfTranLast90days).HasColumnName("count_of_tran_last_90days");

                entity.Property(e => e.CountOfTranLastDay365days).HasColumnName("count_of_tran_last_day365days");

                entity.Property(e => e.CreditInflowLast180days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_180days");

                entity.Property(e => e.CreditInflowLast265days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_265days");

                entity.Property(e => e.CreditInflowLast90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_90days");

                entity.Property(e => e.DebitOutflowLast180days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("DebitOutflow_last_180days");

                entity.Property(e => e.DebitOutflowLast90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("DebitOutflow_last_90days");
            });

            modelBuilder.Entity<Htdtable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTDTABLE");

                entity.HasIndex(e => e.TranDate, "NonClusteredIndex-20201215-122121");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.AmtReservationInd)
                    .HasMaxLength(1)
                    .HasColumnName("AMT_RESERVATION_IND");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(6)
                    .HasColumnName("BANK_CODE");

                entity.Property(e => e.BankId)
                    .HasMaxLength(8)
                    .HasColumnName("BANK_ID");

                entity.Property(e => e.BkdtTranFlg)
                    .HasMaxLength(1)
                    .HasColumnName("BKDT_TRAN_FLG");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(6)
                    .HasColumnName("BR_CODE");

                entity.Property(e => e.CrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("CRNCY_CODE");

                entity.Property(e => e.CrncyHolChkDoneFlg)
                    .HasMaxLength(1)
                    .HasColumnName("CRNCY_HOL_CHK_DONE_FLG");

                entity.Property(e => e.CustId)
                    .HasMaxLength(9)
                    .HasColumnName("CUST_ID");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.DelMemoPad)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_MEMO_PAD");

                entity.Property(e => e.DthInitSolId)
                    .HasMaxLength(8)
                    .HasColumnName("DTH_INIT_SOL_ID");

                entity.Property(e => e.EabfabUpdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("EABFAB_UPD_FLG");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTRY_DATE");

                entity.Property(e => e.EntryUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ENTRY_USER_ID");

                entity.Property(e => e.FxTranAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("FX_TRAN_AMT");

                entity.Property(e => e.GlDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GL_DATE");

                entity.Property(e => e.GlSegmentString)
                    .HasMaxLength(50)
                    .HasColumnName("GL_SEGMENT_STRING");

                entity.Property(e => e.GlSubHeadCode)
                    .HasMaxLength(5)
                    .HasColumnName("GL_SUB_HEAD_CODE");

                entity.Property(e => e.GstUpdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("GST_UPD_FLG");

                entity.Property(e => e.ImplCashPartTranFlg)
                    .HasMaxLength(1)
                    .HasColumnName("IMPL_CASH_PART_TRAN_FLG");

                entity.Property(e => e.InstrmntAlpha)
                    .HasMaxLength(6)
                    .HasColumnName("INSTRMNT_ALPHA");

                entity.Property(e => e.InstrmntDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INSTRMNT_DATE");

                entity.Property(e => e.InstrmntNum)
                    .HasMaxLength(16)
                    .HasColumnName("INSTRMNT_NUM");

                entity.Property(e => e.InstrmntType)
                    .HasMaxLength(5)
                    .HasColumnName("INSTRMNT_TYPE");

                entity.Property(e => e.IsoFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ISO_FLG");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.LiftLienFlg)
                    .HasMaxLength(1)
                    .HasColumnName("LIFT_LIEN_FLG");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(3)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.MudPoolBalBuildFlg)
                    .HasMaxLength(1)
                    .HasColumnName("MUD_POOL_BAL_BUILD_FLG");

                entity.Property(e => e.NavigationFlg)
                    .HasMaxLength(1)
                    .HasColumnName("NAVIGATION_FLG");

                entity.Property(e => e.PartTranSrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("PART_TRAN_SRL_NUM");

                entity.Property(e => e.PartTranType)
                    .HasMaxLength(1)
                    .HasColumnName("PART_TRAN_TYPE");

                entity.Property(e => e.PartyCode)
                    .HasMaxLength(9)
                    .HasColumnName("PARTY_CODE");

                entity.Property(e => e.PrSrlNum)
                    .HasMaxLength(9)
                    .HasColumnName("PR_SRL_NUM");

                entity.Property(e => e.PrincipalPortionAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PRINCIPAL_PORTION_AMT");

                entity.Property(e => e.PrntAdvcInd)
                    .HasMaxLength(1)
                    .HasColumnName("PRNT_ADVC_IND");

                entity.Property(e => e.ProxyAcid)
                    .HasMaxLength(11)
                    .HasColumnName("PROXY_ACID");

                entity.Property(e => e.ProxyPostInd)
                    .HasMaxLength(1)
                    .HasColumnName("PROXY_POST_IND");

                entity.Property(e => e.PstdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PSTD_DATE");

                entity.Property(e => e.PstdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PSTD_FLG");

                entity.Property(e => e.PstdUserId)
                    .HasMaxLength(15)
                    .HasColumnName("PSTD_USER_ID");

                entity.Property(e => e.PtranChrgExistsFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PTRAN_CHRG_EXISTS_FLG");

                entity.Property(e => e.PttmEventType)
                    .HasMaxLength(5)
                    .HasColumnName("PTTM_EVENT_TYPE");

                entity.Property(e => e.Rate)
                    .HasColumnType("numeric(21, 10)")
                    .HasColumnName("RATE");

                entity.Property(e => e.RateCode)
                    .HasMaxLength(5)
                    .HasColumnName("RATE_CODE");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.RefAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("REF_AMT");

                entity.Property(e => e.RefCrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("REF_CRNCY_CODE");

                entity.Property(e => e.RefNum)
                    .HasMaxLength(20)
                    .HasColumnName("REF_NUM");

                entity.Property(e => e.ReferralId)
                    .HasMaxLength(12)
                    .HasColumnName("REFERRAL_ID");

                entity.Property(e => e.RegularizationAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("REGULARIZATION_AMT");

                entity.Property(e => e.ReservationAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("RESERVATION_AMT");

                entity.Property(e => e.RestrictModifyInd)
                    .HasMaxLength(1)
                    .HasColumnName("RESTRICT_MODIFY_IND");

                entity.Property(e => e.ReversalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REVERSAL_DATE");

                entity.Property(e => e.ReversalValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REVERSAL_VALUE_DATE");

                entity.Property(e => e.RptCode)
                    .HasMaxLength(5)
                    .HasColumnName("RPT_CODE");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(4)
                    .HasColumnName("SERIAL_NUM");

                entity.Property(e => e.SiOrgExecDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SI_ORG_EXEC_DATE");

                entity.Property(e => e.SiSrlNum)
                    .HasMaxLength(12)
                    .HasColumnName("SI_SRL_NUM");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.SvsTranId)
                    .HasMaxLength(25)
                    .HasColumnName("SVS_TRAN_ID");

                entity.Property(e => e.SysPartTranCode)
                    .HasMaxLength(10)
                    .HasColumnName("SYS_PART_TRAN_CODE");

                entity.Property(e => e.TfEntitySolId)
                    .HasMaxLength(8)
                    .HasColumnName("TF_ENTITY_SOL_ID");

                entity.Property(e => e.TodEntityId)
                    .HasMaxLength(50)
                    .HasColumnName("TOD_ENTITY_ID");

                entity.Property(e => e.TodEntityType)
                    .HasMaxLength(5)
                    .HasColumnName("TOD_ENTITY_TYPE");

                entity.Property(e => e.TrStatus)
                    .HasMaxLength(1)
                    .HasColumnName("TR_STATUS");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("TRAN_AMT");

                entity.Property(e => e.TranCrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("TRAN_CRNCY_CODE");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRAN_DATE");

                entity.Property(e => e.TranFreeCode1)
                    .HasMaxLength(5)
                    .HasColumnName("TRAN_FREE_CODE1");

                entity.Property(e => e.TranFreeCode2)
                    .HasMaxLength(5)
                    .HasColumnName("TRAN_FREE_CODE2");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("TRAN_ID");

                entity.Property(e => e.TranParticular)
                    .HasMaxLength(50)
                    .HasColumnName("TRAN_PARTICULAR");

                entity.Property(e => e.TranParticular2)
                    .HasMaxLength(50)
                    .HasColumnName("TRAN_PARTICULAR_2");

                entity.Property(e => e.TranParticularCode)
                    .HasMaxLength(5)
                    .HasColumnName("TRAN_PARTICULAR_CODE");

                entity.Property(e => e.TranRmks)
                    .HasMaxLength(30)
                    .HasColumnName("TRAN_RMKS");

                entity.Property(e => e.TranSubType)
                    .HasMaxLength(2)
                    .HasColumnName("TRAN_SUB_TYPE");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .HasColumnName("TRAN_TYPE");

                entity.Property(e => e.TreaRate)
                    .HasColumnType("numeric(21, 10)")
                    .HasColumnName("TREA_RATE");

                entity.Property(e => e.TreaRefNum)
                    .HasMaxLength(16)
                    .HasColumnName("TREA_REF_NUM");

                entity.Property(e => e.TsCnt)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TS_CNT");

                entity.Property(e => e.UadModuleId)
                    .HasMaxLength(6)
                    .HasColumnName("UAD_MODULE_ID");

                entity.Property(e => e.UadModuleKey)
                    .HasMaxLength(256)
                    .HasColumnName("UAD_MODULE_KEY");

                entity.Property(e => e.UserPartTranCode)
                    .HasMaxLength(10)
                    .HasColumnName("USER_PART_TRAN_CODE");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALUE_DATE");

                entity.Property(e => e.VfdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VFD_DATE");

                entity.Property(e => e.VfdUserId)
                    .HasMaxLength(15)
                    .HasColumnName("VFD_USER_ID");

                entity.Property(e => e.VoucherPrintFlg)
                    .HasMaxLength(1)
                    .HasColumnName("VOUCHER_PRINT_FLG");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<InactiveBankwide>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inactive_Bankwide");

                entity.HasIndex(e => e.RunDate, "date_");

                entity.HasIndex(e => new { e.AccountNumber, e.RunDate }, "idx_acct_no_date");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.RunDate).HasColumnType("date");

                entity.Property(e => e.StatusDuration)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Incentive1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("incentive1");

                entity.Property(e => e.AccountMgrId)
                    .HasMaxLength(15)
                    .HasColumnName("Account_Mgr_id");

                entity.Property(e => e.AccountNumber).HasMaxLength(16);

                entity.Property(e => e.AcctMgrName)
                    .HasMaxLength(40)
                    .HasColumnName("Acct_Mgr_Name");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.BranchName).HasMaxLength(132);

                entity.Property(e => e.BranchNo).HasMaxLength(8);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("Phone_no");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .HasColumnName("product");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Zone).HasMaxLength(14);
            });

            modelBuilder.Entity<IncentiveCustTran>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AirtimeCount).HasColumnName("Airtime_Count");

                entity.Property(e => e.AirtimeValue)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Airtime_Value");

                entity.Property(e => e.BillCount).HasColumnName("Bill_Count");

                entity.Property(e => e.BillValue)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Bill_Value");

                entity.Property(e => e.DataCount).HasColumnName("Data_Count");

                entity.Property(e => e.DataValue)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Data_Value");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.NipCount).HasColumnName("Nip_Count");

                entity.Property(e => e.NipValue)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Nip_Value");

                entity.Property(e => e.TotalValue)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Total_Value");
            });

            modelBuilder.Entity<IncentiveCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IncentiveCustomer");

                entity.Property(e => e.AcctMgrGroup)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Acct_Mgr_Group");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.BranchName).HasMaxLength(132);

                entity.Property(e => e.BranchNo).HasMaxLength(8);

                entity.Property(e => e.ClrBalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("clr_bal_amt");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.PhoneNo).HasMaxLength(25);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_Desc");
            });

            modelBuilder.Entity<IncentiveReactivated>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IncentiveReactivated");

                entity.Property(e => e.AccountMangerName).HasMaxLength(40);

                entity.Property(e => e.AcctMgrGroup)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Acct_mgr_group");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.BranchName).HasMaxLength(132);

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.ClrBalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("clr_bal_amt");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.ReactivationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Reactivation_Date");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("sol_id");
            });

            modelBuilder.Entity<IncentiveTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Incentive_Targets");

                entity.Property(e => e.AcquisitionMonthlyTarget).HasColumnName("Acquisition_monthly_target");

                entity.Property(e => e.Acqusition10Percent).HasColumnName("Acqusition_10_percent");

                entity.Property(e => e.ChanelMigrationMonthlyTarget).HasColumnName("Chanel_Migration_monthly_target");

                entity.Property(e => e.ChannelMigration10Percent).HasColumnName("Channel_Migration_10_percent");

                entity.Property(e => e.QualifyingCustomers10Percent).HasColumnName("Qualifying_customers_10_percent");

                entity.Property(e => e.QualifyingCustomersMonthlyTarget).HasColumnName("Qualifying_customers_monthly_target");

                entity.Property(e => e.Reactivation10Percent).HasColumnName("Reactivation_10_percent");

                entity.Property(e => e.ReactivationMonthlyTarget).HasColumnName("Reactivation_monthly_target");

                entity.Property(e => e.SolId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sol_id");

                entity.Property(e => e.TransactionCount10Percent).HasColumnName("Transaction_count_10_percent");

                entity.Property(e => e.TransactionCountMonthlyTarget).HasColumnName("Transaction_count_monthly_target");
            });

            modelBuilder.Entity<InitiatingBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Initiating_Branch");

                entity.Property(e => e.InitiatingBranch1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Initiating_Branch");

                entity.Property(e => e.Rownames)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rownames");

                entity.Property(e => e.Zone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ZONE");

                entity.Property(e => e.Zotl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ZOTL");
            });

            modelBuilder.Entity<InitiatingBranchCcsm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Initiating_Branch_CCSMS");

                entity.Property(e => e.InitiatingBranch)
                    .HasMaxLength(255)
                    .HasColumnName("Initiating_Branch");

                entity.Property(e => e.Zone)
                    .HasMaxLength(255)
                    .HasColumnName("ZONE");

                entity.Property(e => e.Zotl)
                    .HasMaxLength(255)
                    .HasColumnName("ZOTL");
            });

            modelBuilder.Entity<LastMntAvgBal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Last_mnt_avg_bal");

                entity.HasIndex(e => e.Foracid, "idx_foracid");

                entity.Property(e => e.AverageBal).HasColumnName("Average_bal");

                entity.Property(e => e.Foracid).HasMaxLength(50);

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");
            });

            modelBuilder.Entity<LoanPdo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoanPDO");

                entity.Property(e => e.AcctClsFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCT_CLS_FLG");

                entity.Property(e => e.CifId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.InterestDue)
                    .HasMaxLength(20)
                    .HasColumnName("INTEREST_DUE");

                entity.Property(e => e.LoanAccountNo)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_ACCOUNT_NO");

                entity.Property(e => e.LoanAcctBal)
                    .HasMaxLength(20)
                    .HasColumnName("LOAN_ACCT_BAL");

                entity.Property(e => e.LoanAcctName)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_ACCT_NAME");

                entity.Property(e => e.LoanAmount)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("LOAN_AMOUNT");

                entity.Property(e => e.OperAcctBal)
                    .HasMaxLength(20)
                    .HasColumnName("OPER_ACCT_BAL");

                entity.Property(e => e.OperAcctBrnId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OPER_ACCT_BRN_ID");

                entity.Property(e => e.OperAcctBrnName)
                    .HasMaxLength(528)
                    .IsUnicode(false)
                    .HasColumnName("OPER_ACCT_BRN_NAME");

                entity.Property(e => e.OperAcctLienAmt)
                    .HasMaxLength(20)
                    .HasColumnName("OPER_ACCT_LIEN_AMT");

                entity.Property(e => e.OperAcctName)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("OPER_ACCT_NAME");

                entity.Property(e => e.OperAcctNo)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("OPER_ACCT_NO");

                entity.Property(e => e.PrincipalDue)
                    .HasMaxLength(20)
                    .HasColumnName("PRINCIPAL_DUE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");
            });

            modelBuilder.Entity<ManagerChgIssued>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manager_Chg_Issued");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Volume)
                    .HasMaxLength(38)
                    .HasColumnName("VOLUME");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<MasterData2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("master_data2");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("Acct_Opn_Date");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("acid");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("age_grp");

                entity.Property(e => e.AlatUser)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Alat_user");

                entity.Property(e => e.BirthYear).HasColumnName("birth_year");

                entity.Property(e => e.Bvn)
                    .IsUnicode(false)
                    .HasColumnName("BVN");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CrTranCnt)
                    .HasMaxLength(38)
                    .HasColumnName("Cr_Tran_Cnt");

                entity.Property(e => e.CurrentBal)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CurrentBAL");

                entity.Property(e => e.CustFirstName)
                    .IsUnicode(false)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .IsUnicode(false)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.CustMiddleName)
                    .IsUnicode(false)
                    .HasColumnName("cust_middle_name");

                entity.Property(e => e.DrTranCnt)
                    .HasMaxLength(38)
                    .HasColumnName("Dr_Tran_Cnt");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EmploymentStatus)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYMENT_STATUS");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HasCards)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Has_Cards");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.MaritalStatus)
                    .IsUnicode(false)
                    .HasColumnName("MARITAL_STATUS");

                entity.Property(e => e.Occupation)
                    .IsUnicode(false)
                    .HasColumnName("OCCUPATION");

                entity.Property(e => e.OnUssd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("on_ussd");

                entity.Property(e => e.PhoneNo)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.RowNum).HasColumnName("Row_Num");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("Sol_ID");

                entity.Property(e => e.Staffflag)
                    .IsUnicode(false)
                    .HasColumnName("STAFFFLAG");
            });

            modelBuilder.Entity<MasterTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_Table");

                entity.HasIndex(e => new { e.Foracid, e.CifId, e.Acid }, "idx_acid_foracid_cif");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("Acct_Opn_Date");

                entity.Property(e => e.Acid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Age_Grp");

                entity.Property(e => e.AlatUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALAT_User");

                entity.Property(e => e.BirthYear)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Birth_Year");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BVN");

                entity.Property(e => e.CifId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CurrentBal).HasColumnType("money");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.CustMiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Middle_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Employment_Status");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HasCards)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Has_Cards");

                entity.Property(e => e.HasLoan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Has_Loan");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnAfb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("On_Afb");

                entity.Property(e => e.OnUssd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("On_USSD");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Phone_no");

                entity.Property(e => e.Religion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Schm_Desc");

                entity.Property(e => e.SegmentationClass)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Segmentation_Class");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sol_ID");

                entity.Property(e => e.Staff)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subsegment)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mno");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewChurnPrediction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Churn_Prediction");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Acct_open_date");

                entity.Property(e => e.Acid)
                    .HasMaxLength(100)
                    .HasColumnName("acid");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_group");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CrTranCntIn180Days)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cr_Tran_Cnt_in_180_days");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DaysSinceLastTran)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Days_since_last_Tran");

                entity.Property(e => e.DrTranCntIn180Days)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Dr_Tran_Cnt_in_180_Days");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(100)
                    .HasColumnName("foracid");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsAlatNumber)
                    .HasMaxLength(100)
                    .HasColumnName("Is_Alat_Number");

                entity.Property(e => e.IsBvnSupplied).HasColumnName("IS_BVN_Supplied");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_date");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(100)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.Segment).HasMaxLength(100);

                entity.Property(e => e.SolId)
                    .HasMaxLength(5)
                    .HasColumnName("sol_id");

                entity.Property(e => e.Tenor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<NewChurnPrediction2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Churn_Prediction2");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("date")
                    .HasColumnName("ACCT_opn_Date");

                entity.Property(e => e.Acid).HasMaxLength(100);

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CrTranCnt).HasColumnName("CR_Tran_Cnt");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.DaySinceLastTran).HasColumnName("Day_Since_Last_Tran");

                entity.Property(e => e.DrTranCnt).HasColumnName("Dr_Tran_Cnt");

                entity.Property(e => e.Foracid).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.IsAlatCustomer).HasColumnName("Is_Alat_Customer");

                entity.Property(e => e.IsBvnSupplied).HasColumnName("Is_BVN_Supplied");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_date");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(100)
                    .HasColumnName("Schm_Code");

                entity.Property(e => e.Segment).HasMaxLength(100);

                entity.Property(e => e.SolId)
                    .HasMaxLength(100)
                    .HasColumnName("Sol_id");
            });

            modelBuilder.Entity<NewClvDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_CLV_Data");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.AverageBalance).HasColumnName("Average_Balance");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("Cif_ID");

                entity.Property(e => e.CountOfTranLast180days).HasColumnName("Count_Of_Tran_Last_180Days");

                entity.Property(e => e.CountOfTranLast365days).HasColumnName("Count_Of_Tran_Last_365Days");

                entity.Property(e => e.CountOfTranLast90days).HasColumnName("Count_Of_Tran_Last_90Days");

                entity.Property(e => e.CreditinflowLast180days).HasColumnName("Creditinflow_Last_180Days");

                entity.Property(e => e.CreditinflowLast365days).HasColumnName("Creditinflow_Last_365Days");

                entity.Property(e => e.CreditinflowLast90days).HasColumnName("Creditinflow_Last_90Days");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.DaysSinceLastTran).HasColumnName("Days_Since_Last_Tran");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Employment_Status");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.NoOfAccounts).HasColumnName("No_Of_Accounts");

                entity.Property(e => e.NorthBank).HasColumnName("North_Bank");

                entity.Property(e => e.Occupation).HasMaxLength(100);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.SegmentationClass)
                    .HasMaxLength(100)
                    .HasColumnName("Segmentation_Class");

                entity.Property(e => e.SouthSouth).HasColumnName("South_South");

                entity.Property(e => e.SouthWest).HasColumnName("South_West");

                entity.Property(e => e.Staff).HasMaxLength(100);

                entity.Property(e => e.SubSegment).HasMaxLength(100);

                entity.Property(e => e.UnitBranch).HasColumnName("Unit_Branch");
            });

            modelBuilder.Entity<NewConsolidatedSla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEW_CONSOLIDATED_SLAs");

                entity.Property(e => e.Cbnsla)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CBNSLA");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentSla)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CurrentSLA");

                entity.Property(e => e.DevSla).HasColumnName("DevSLA");

                entity.Property(e => e.NewSla)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NewSLA");

                entity.Property(e => e.ResolvingUnItdepartment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ResolvingUnITDEPARTMENT");

                entity.Property(e => e.Rownames)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rownames");

                entity.Property(e => e.Stakeholdersdebate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subcategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewPartner>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("new_partners");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.PartTranType)
                    .HasMaxLength(1)
                    .HasColumnName("PART_TRAN_TYPE");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("TRAN_AMT");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRAN_DATE");
            });

            modelBuilder.Entity<NewProductRecommendationData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Product_Recommendation_Datas");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Grp");

                entity.Property(e => e.AlatGoals).HasColumnName("ALAT_GOALS");

                entity.Property(e => e.AlatUsers).HasColumnName("ALAT_USERS");

                entity.Property(e => e.BusinessAccount).HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards).HasColumnName("CARDS");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CreditCardAccount).HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount).HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_Type");

                entity.Property(e => e.DomiciliaryAccount).HasColumnName("DOMICILIARY_ACCOUNT");

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Employment_Status");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan).HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan).HasColumnName("LOAN");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.Mortgage).HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccount).HasColumnName("No_Of_Account");

                entity.Property(e => e.NorthBank).HasColumnName("North_Bank");

                entity.Property(e => e.Occupation).HasMaxLength(100);

                entity.Property(e => e.RowNum).HasColumnName("Row_Num");

                entity.Property(e => e.SavingsAccount).HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.SouthSouth).HasColumnName("South_South");

                entity.Property(e => e.SouthWest).HasColumnName("South_West");

                entity.Property(e => e.SubSegment).HasMaxLength(100);

                entity.Property(e => e.TermDepost).HasColumnName("TERM_DEPOST");

                entity.Property(e => e.UniqueBranch).HasColumnName("Unique_Branch");

                entity.Property(e => e.Ussd).HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure).HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<NewProductRecommendationDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Product_Recommendation_Data");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Grp");

                entity.Property(e => e.AlatGoals).HasColumnName("ALAT_GOALS");

                entity.Property(e => e.AlatUsers).HasColumnName("ALAT_USERS");

                entity.Property(e => e.BusinessAccount).HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards).HasColumnName("CARDS");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CreditCardAccount).HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount).HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_First_Name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Cust_Last_Name");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_Type");

                entity.Property(e => e.DomiciliaryAccount).HasColumnName("DOMICILIARY_ACCOUNT");

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Employment_Status");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan).HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan).HasColumnName("LOAN");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.Mortgage).HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccount).HasColumnName("No_Of_Account");

                entity.Property(e => e.NorthBank).HasColumnName("North_Bank");

                entity.Property(e => e.Occupation).HasMaxLength(100);

                entity.Property(e => e.SavingsAccount).HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.SouthSouth).HasColumnName("South_South");

                entity.Property(e => e.SouthWest).HasColumnName("South_West");

                entity.Property(e => e.SubSegment).HasMaxLength(100);

                entity.Property(e => e.TermDepost).HasColumnName("TERM_DEPOST");

                entity.Property(e => e.UniqueBranch).HasColumnName("Unique_Branch");

                entity.Property(e => e.Ussd).HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure).HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<NewPythonModelTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Python_Model_Table");

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.GenerationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Generation_Time");

                entity.Property(e => e.ModelId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Model_ID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(100)
                    .HasColumnName("Model_Name");

                entity.Property(e => e.ModelTitle)
                    .HasMaxLength(100)
                    .HasColumnName("Model_Title");
            });

            modelBuilder.Entity<NewRecommendationPrediction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Recommendation_Prediction");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.AlatGoals).HasColumnName("ALAT_GOALS");

                entity.Property(e => e.AlatUser).HasColumnName("ALAT_USER");

                entity.Property(e => e.BusinessAccount).HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards).HasColumnName("CARDS");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CreditCardAccount).HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount).HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DomicillaryAccount).HasColumnName("DOMICILLARY_ACCOUNT");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan).HasColumnName("HCM_LOAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Loan).HasColumnName("LOAN");

                entity.Property(e => e.Mortgage).HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccounts)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("No_of_Accounts");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_date");

                entity.Property(e => e.SavingsAccount).HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.TermDeposit).HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.UniqueBranch)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Unique_Branch");

                entity.Property(e => e.Ussd).HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure).HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<NewTbWebAppCustomerCluster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_tb_WebAppCustomerCluster");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Cif)
                    .HasMaxLength(100)
                    .HasColumnName("cif");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CustFisrtName)
                    .HasMaxLength(1000)
                    .HasColumnName("cust_fisrt_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DesitnationAccountNumber).HasMaxLength(100);

                entity.Property(e => e.DestinationAccountName).HasMaxLength(1000);

                entity.Property(e => e.DestinationBank).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Foracid)
                    .HasMaxLength(100)
                    .HasColumnName("foracid");

                entity.Property(e => e.MonthName).HasMaxLength(100);

                entity.Property(e => e.Orgkey)
                    .HasMaxLength(100)
                    .HasColumnName("ORGKey");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.Region).HasMaxLength(100);

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_Date");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(100)
                    .HasColumnName("Sol_id");

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(100);

                entity.Property(e => e.SumAmmount).HasColumnName("Sum_Ammount");

                entity.Property(e => e.TotalTransactionVolume).HasColumnName("Total_Transaction_Volume");

                entity.Property(e => e.Zone).HasMaxLength(100);
            });

            modelBuilder.Entity<NewTbWebAppCustomerReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_tb_WebAppCustomerReport");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Status");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.Alat)
                    .HasMaxLength(100)
                    .HasColumnName("ALAT");

                entity.Property(e => e.AlatGoalBasedLoan)
                    .HasMaxLength(100)
                    .HasColumnName("ALAT_GOAL_BASED_LOAN");

                entity.Property(e => e.AlatGoals)
                    .HasMaxLength(100)
                    .HasColumnName("ALAT_GOALS");

                entity.Property(e => e.Branch).HasMaxLength(100);

                entity.Property(e => e.BusinessAccount)
                    .HasMaxLength(100)
                    .HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards)
                    .HasMaxLength(100)
                    .HasColumnName("CARDS");

                entity.Property(e => e.ChurnStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Churn_Status");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CreditCardAccount)
                    .HasMaxLength(100)
                    .HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount)
                    .HasMaxLength(100)
                    .HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CurrentProduct).HasColumnName("Current_Product");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.DomicillaryAccount)
                    .HasMaxLength(100)
                    .HasColumnName("DOMICILLARY_ACCOUNT");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Foracid).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan)
                    .HasMaxLength(100)
                    .HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan)
                    .HasMaxLength(100)
                    .HasColumnName("LOAN");

                entity.Property(e => e.Morgage)
                    .HasMaxLength(100)
                    .HasColumnName("MORGAGE");

                entity.Property(e => e.NoOfAccounts).HasColumnName("No_Of_Accounts");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.Region).HasMaxLength(100);

                entity.Property(e => e.SavingsAccount)
                    .HasMaxLength(100)
                    .HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.Segmentation).HasMaxLength(100);

                entity.Property(e => e.SolId)
                    .HasMaxLength(100)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TermDeposit)
                    .HasMaxLength(100)
                    .HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.Ussd)
                    .HasMaxLength(100)
                    .HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure)
                    .HasMaxLength(100)
                    .HasColumnName("WEMA_TREASURE");

                entity.Property(e => e.Zone).HasMaxLength(100);
            });

            modelBuilder.Entity<NibssOutpaymentRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NibssOutpaymentRequest");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BatchStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BenAccountNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BenBankSortCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BenNarration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelRequestBatchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ErpIntegratorRequestId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NapsPaymentReference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTxnDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerAccountNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayerAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayerBankCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayerLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PayerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalTranId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReversalTranID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.Stan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxnStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NullValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Null_Values");

                entity.Property(e => e.Acid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("acid");

                entity.Property(e => e.CifId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CountOfDrTranLast180days).HasColumnName("count_of_Dr_tran_last_180days");

                entity.Property(e => e.CountOfDrTranLast90days).HasColumnName("count_of_Dr_tran_last_90days");

                entity.Property(e => e.CountOfTranLast180days).HasColumnName("count_of_tran_last_180days");

                entity.Property(e => e.CountOfTranLast90days).HasColumnName("count_of_tran_last_90days");

                entity.Property(e => e.CountOfTranLastDay365days).HasColumnName("count_of_tran_last_day365days");

                entity.Property(e => e.CreditInflowLast180days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_180days");

                entity.Property(e => e.CreditInflowLast265days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_265days");

                entity.Property(e => e.CreditInflowLast90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("CreditInflow_last_90days");

                entity.Property(e => e.DebitOutflowLast180days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("DebitOutflow_last_180days");

                entity.Property(e => e.DebitOutflowLast90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("DebitOutflow_last_90days");
            });

            modelBuilder.Entity<OleDbDestination>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLE DB Destination");

                entity.Property(e => e.CardAcceptorNameLoc)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("card_acceptor_name_loc");

                entity.Property(e => e.CardProduct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_product");

                entity.Property(e => e.Pan)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.PosTerminalType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("pos_terminal_type");

                entity.Property(e => e.PostTranCustId).HasColumnName("post_tran_cust_id");

                entity.Property(e => e.SourceNodeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("source_node_name");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("terminal_id");
            });

            modelBuilder.Entity<PartnersGam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partners_gam");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");
            });

            modelBuilder.Entity<PcAccounts1B>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("pc_accounts_1_B ");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("account_id");

                entity.Property(e => e.AccountIdEncrypted)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("account_id_encrypted");

                entity.Property(e => e.AccountNickname)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("account_nickname");

                entity.Property(e => e.AccountProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_product");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("account_type");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("currency_code");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("date_deleted");

                entity.Property(e => e.ExtendedFields)
                    .IsUnicode(false)
                    .HasColumnName("extended_fields");

                entity.Property(e => e.HoldRspCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("hold_rsp_code");

                entity.Property(e => e.IssuerNr).HasColumnName("issuer_nr");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated_date");

                entity.Property(e => e.LastUpdatedUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_updated_user");

                entity.Property(e => e.OverdraftLimit)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("overdraft_limit");

                entity.Property(e => e.Vip).HasColumnName("vip");

                entity.Property(e => e.VipLapseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("vip_lapse_date");
            });

            modelBuilder.Entity<PcCardAccounts1A>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pc_card_accounts_1_A");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("account_id");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("account_type");

                entity.Property(e => e.AccountTypeNominated)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("account_type_nominated");

                entity.Property(e => e.AccountTypeQualifier).HasColumnName("account_type_qualifier");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("date_deleted");

                entity.Property(e => e.IssuerNr).HasColumnName("issuer_nr");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated_date");

                entity.Property(e => e.LastUpdatedUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_updated_user");

                entity.Property(e => e.Pan)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.SeqNr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("seq_nr");
            });

            modelBuilder.Entity<PcCards1A>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pc_cards_1_A");

                entity.HasIndex(e => new { e.Pan, e.DateActivated, e.CustomerId, e.CardProgram }, "NonClusteredIndex-20201215-133229");

                entity.Property(e => e.BatchNr).HasColumnName("batch_nr");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("branch_code");

                entity.Property(e => e.CardCustomState).HasColumnName("card_custom_state");

                entity.Property(e => e.CardProgram)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_program");

                entity.Property(e => e.CardStatus).HasColumnName("card_status");

                entity.Property(e => e.CardholderRspInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardholder_rsp_info");

                entity.Property(e => e.CompanyCard).HasColumnName("company_card");

                entity.Property(e => e.ContactlessDiscData)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("contactless_disc_data");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.DateActivated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_activated");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("date_deleted");

                entity.Property(e => e.DateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("date_issued");

                entity.Property(e => e.DcvvKeyIndex).HasColumnName("dcvv_key_index");

                entity.Property(e => e.DefaultAccountType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("default_account_type");

                entity.Property(e => e.DiscretionaryData)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("discretionary_data");

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("expiry_date");

                entity.Property(e => e.ExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date_time");

                entity.Property(e => e.ExpiryDay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("expiry_day");

                entity.Property(e => e.ExtendedFields)
                    .IsUnicode(false)
                    .HasColumnName("extended_fields");

                entity.Property(e => e.FromDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("from_date");

                entity.Property(e => e.FromDay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("from_day");

                entity.Property(e => e.HoldRspCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("hold_rsp_code");

                entity.Property(e => e.IssuerNr).HasColumnName("issuer_nr");

                entity.Property(e => e.IssuerReference)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("issuer_reference");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated_date");

                entity.Property(e => e.LastUpdatedUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_updated_user");

                entity.Property(e => e.MailerDestination).HasColumnName("mailer_destination");

                entity.Property(e => e.Pan)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.PanEncrypted)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("pan_encrypted");

                entity.Property(e => e.Pvki2OrPin2Length).HasColumnName("pvki2_or_pin2_length");

                entity.Property(e => e.PvkiOrPinLength).HasColumnName("pvki_or_pin_length");

                entity.Property(e => e.Pvv2OrPin2Offset)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("pvv2_or_pin2_offset");

                entity.Property(e => e.PvvOrPinOffset)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("pvv_or_pin_offset");

                entity.Property(e => e.SeqNr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("seq_nr");

                entity.Property(e => e.Track2Value)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("track2_value");

                entity.Property(e => e.Track2ValueOffset).HasColumnName("track2_value_offset");

                entity.Property(e => e.ValidationData)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validation_data");

                entity.Property(e => e.ValidationDataQuestion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validation_data_question");
            });

            modelBuilder.Entity<PcCustomers1A>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pc_customers_1_A");

                entity.HasIndex(e => new { e.CustomerId, e.C1NameOnCard }, "NonClusteredIndex-20201215-133421");

                entity.Property(e => e.C1FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c1_first_name");

                entity.Property(e => e.C1Initials)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c1_initials");

                entity.Property(e => e.C1LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c1_last_name");

                entity.Property(e => e.C1NameOnCard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c1_name_on_card");

                entity.Property(e => e.C1Title)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c1_title");

                entity.Property(e => e.C2FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c2_first_name");

                entity.Property(e => e.C2Initials)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c2_initials");

                entity.Property(e => e.C2LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c2_last_name");

                entity.Property(e => e.C2NameOnCard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c2_name_on_card");

                entity.Property(e => e.C2Title)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c2_title");

                entity.Property(e => e.C3FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c3_first_name");

                entity.Property(e => e.C3Initials)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c3_initials");

                entity.Property(e => e.C3LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c3_last_name");

                entity.Property(e => e.C3NameOnCard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c3_name_on_card");

                entity.Property(e => e.C3Title)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("c3_title");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("date_deleted");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("email_address");

                entity.Property(e => e.ExtendedFields)
                    .IsUnicode(false)
                    .HasColumnName("extended_fields");

                entity.Property(e => e.FaxNr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fax_nr");

                entity.Property(e => e.IssuerNr).HasColumnName("issuer_nr");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated_date");

                entity.Property(e => e.LastUpdatedUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_updated_user");

                entity.Property(e => e.MobileNr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_nr");

                entity.Property(e => e.NationalIdNr)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("national_id_nr");

                entity.Property(e => e.NationalIdNrEncrypted)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("national_id_nr_encrypted");

                entity.Property(e => e.OtherAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("other_address_1");

                entity.Property(e => e.OtherAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("other_address_2");

                entity.Property(e => e.OtherCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("other_city");

                entity.Property(e => e.OtherCountry)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("other_country");

                entity.Property(e => e.OtherPostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("other_postal_code");

                entity.Property(e => e.OtherRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("other_region");

                entity.Property(e => e.PostalAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("postal_address_1");

                entity.Property(e => e.PostalAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("postal_address_2");

                entity.Property(e => e.PostalCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("postal_city");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postal_code");

                entity.Property(e => e.PostalCountry)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("postal_country");

                entity.Property(e => e.PostalRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postal_region");

                entity.Property(e => e.PreferredLang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("preferred_lang");

                entity.Property(e => e.TelNr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tel_nr");

                entity.Property(e => e.Vip).HasColumnName("vip");

                entity.Property(e => e.VipLapseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("vip_lapse_date");
            });

            modelBuilder.Entity<PostTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("post_tran");

                entity.HasIndex(e => new { e.PostTranId, e.DatetimeReq, e.TranPostilionOriginated }, "NonClusteredIndex-20201217-123357");

                entity.Property(e => e.AbortRspCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("abort_rsp_code");

                entity.Property(e => e.AcquirerNetworkId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("acquirer_network_id");

                entity.Property(e => e.AcquiringInstIdCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("acquiring_inst_id_code");

                entity.Property(e => e.AdditionalRspData)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("additional_rsp_data");

                entity.Property(e => e.AuthIdRsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("auth_id_rsp");

                entity.Property(e => e.AuthReason)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auth_reason");

                entity.Property(e => e.AuthType)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("auth_type");

                entity.Property(e => e.BankDetails)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("bank_details");

                entity.Property(e => e.BatchNr).HasColumnName("batch_nr");

                entity.Property(e => e.CardVerificationResult)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("card_verification_result");

                entity.Property(e => e.DatetimeReq)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_req");

                entity.Property(e => e.DatetimeRsp)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_rsp");

                entity.Property(e => e.DatetimeTranGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_tran_gmt");

                entity.Property(e => e.DatetimeTranLocal)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_tran_local");

                entity.Property(e => e.ExtendedTranType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extended_tran_type");

                entity.Property(e => e.FromAccountId)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("from_account_id");

                entity.Property(e => e.FromAccountIdCs).HasColumnName("from_account_id_cs");

                entity.Property(e => e.FromAccountType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("from_account_type");

                entity.Property(e => e.FromAccountTypeQualifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("from_account_type_qualifier");

                entity.Property(e => e.IccDataReq)
                    .IsUnicode(false)
                    .HasColumnName("icc_data_req");

                entity.Property(e => e.IccDataRsp)
                    .IsUnicode(false)
                    .HasColumnName("icc_data_rsp");

                entity.Property(e => e.IssuerNetworkId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("issuer_network_id");

                entity.Property(e => e.MessageReasonCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("message_reason_code");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("message_type");

                entity.Property(e => e.NextPostTranId).HasColumnName("next_post_tran_id");

                entity.Property(e => e.OnlineSystemId).HasColumnName("online_system_id");

                entity.Property(e => e.OppParticipantId).HasColumnName("opp_participant_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Payee)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("payee");

                entity.Property(e => e.PosConditionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("pos_condition_code");

                entity.Property(e => e.PosEntryMode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("pos_entry_mode");

                entity.Property(e => e.PosGeographicData)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("pos_geographic_data");

                entity.Property(e => e.PostTranCustId).HasColumnName("post_tran_cust_id");

                entity.Property(e => e.PostTranId).HasColumnName("post_tran_id");

                entity.Property(e => e.PrevPostTranId).HasColumnName("prev_post_tran_id");

                entity.Property(e => e.PrevTranApproved)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("prev_tran_approved");

                entity.Property(e => e.ProcOnlineSystemId).HasColumnName("proc_online_system_id");

                entity.Property(e => e.PtPosCardInputMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_card_input_mode");

                entity.Property(e => e.PtPosCardholderAuthMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_cardholder_auth_method");

                entity.Property(e => e.PtPosOperatingEnvironment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_operating_environment");

                entity.Property(e => e.PtPosPinCaptureAbility)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_pin_capture_ability");

                entity.Property(e => e.PtPosTerminalOperator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pt_pos_terminal_operator");

                entity.Property(e => e.RealtimeBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("realtime_business_date");

                entity.Property(e => e.ReceivingInstIdCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("receiving_inst_id_code");

                entity.Property(e => e.ReconBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recon_business_date");

                entity.Property(e => e.RetentionData)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("retention_data");

                entity.Property(e => e.RetrievalReferenceNr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("retrieval_reference_nr");

                entity.Property(e => e.RoutingType).HasColumnName("routing_type");

                entity.Property(e => e.RspCodeReq)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_req");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.SettleAmountImpact)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_impact");

                entity.Property(e => e.SettleAmountReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_req");

                entity.Property(e => e.SettleAmountRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_amount_rsp");

                entity.Property(e => e.SettleCashReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_cash_req");

                entity.Property(e => e.SettleCashRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_cash_rsp");

                entity.Property(e => e.SettleCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("settle_currency_code");

                entity.Property(e => e.SettleEntityId).HasColumnName("settle_entity_id");

                entity.Property(e => e.SettleProcFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_proc_fee_req");

                entity.Property(e => e.SettleProcFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_proc_fee_rsp");

                entity.Property(e => e.SettleTranFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_tran_fee_req");

                entity.Property(e => e.SettleTranFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("settle_tran_fee_rsp");

                entity.Property(e => e.SinkNodeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sink_node_name");

                entity.Property(e => e.SourceNodeKey)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("source_node_key");

                entity.Property(e => e.SponsorBank)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("sponsor_bank");

                entity.Property(e => e.StructuredDataReq)
                    .IsUnicode(false)
                    .HasColumnName("structured_data_req");

                entity.Property(e => e.StructuredDataRsp)
                    .IsUnicode(false)
                    .HasColumnName("structured_data_rsp");

                entity.Property(e => e.SystemTraceAuditNr)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("system_trace_audit_nr");

                entity.Property(e => e.ToAccountId)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("to_account_id");

                entity.Property(e => e.ToAccountIdCs).HasColumnName("to_account_id_cs");

                entity.Property(e => e.ToAccountType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("to_account_type");

                entity.Property(e => e.ToAccountTypeQualifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("to_account_type_qualifier");

                entity.Property(e => e.TranAmountReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_amount_req");

                entity.Property(e => e.TranAmountRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_amount_rsp");

                entity.Property(e => e.TranCashReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_cash_req");

                entity.Property(e => e.TranCashRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_cash_rsp");

                entity.Property(e => e.TranCompleted)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tran_completed");

                entity.Property(e => e.TranCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_currency_code");

                entity.Property(e => e.TranNr).HasColumnName("tran_nr");

                entity.Property(e => e.TranPostilionOriginated)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("tran_postilion_originated");

                entity.Property(e => e.TranProcFeeCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_proc_fee_currency_code");

                entity.Property(e => e.TranProcFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_proc_fee_req");

                entity.Property(e => e.TranProcFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_proc_fee_rsp");

                entity.Property(e => e.TranReversed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tran_reversed");

                entity.Property(e => e.TranTranFeeCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tran_tran_fee_currency_code");

                entity.Property(e => e.TranTranFeeReq)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_tran_fee_req");

                entity.Property(e => e.TranTranFeeRsp)
                    .HasColumnType("numeric(16, 0)")
                    .HasColumnName("tran_tran_fee_rsp");

                entity.Property(e => e.TranType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tran_type");

                entity.Property(e => e.UcafData)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("ucaf_data");
            });

            modelBuilder.Entity<PostTranCust>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("post_tran_cust");

                entity.HasIndex(e => new { e.PostTranCustId, e.Pan }, "NonClusteredIndex-20210321-205846");

                entity.Property(e => e.CardAcceptorNameLoc)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("card_acceptor_name_loc");

                entity.Property(e => e.CardProduct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_product");

                entity.Property(e => e.MerchantType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("merchant_type");

                entity.Property(e => e.Pan)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.PosTerminalType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("pos_terminal_type");

                entity.Property(e => e.PostTranCustId).HasColumnName("post_tran_cust_id");

                entity.Property(e => e.SourceNodeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("source_node_name");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("terminal_id");
            });

            modelBuilder.Entity<ProductRecommendationDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_recommendation_data");

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("age_grp");

                entity.Property(e => e.AlatGoals).HasColumnName("ALAT GOALS");

                entity.Property(e => e.AlatUser).HasColumnName("ALAT USER");

                entity.Property(e => e.BusinessAccount).HasColumnName("BUSINESS ACCOUNT");

                entity.Property(e => e.Cards).HasColumnName("CARDS");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CreditCardAccount).HasColumnName("CREDIT CARD ACCOUNT");

                entity.Property(e => e.CurrentAccount).HasColumnName("CURRENT ACCOUNT");

                entity.Property(e => e.CustFirstName)
                    .IsUnicode(false)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .IsUnicode(false)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Type");

                entity.Property(e => e.DomicliaryAccount).HasColumnName("DOMICLIARY ACCOUNT");

                entity.Property(e => e.EmploymentStatus)
                    .IsUnicode(false)
                    .HasColumnName("employment_status");

                entity.Property(e => e.Gender)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HcmLoan).HasColumnName("HCM LOAN");

                entity.Property(e => e.Loan).HasColumnName("LOAN");

                entity.Property(e => e.MaritalStatus)
                    .IsUnicode(false)
                    .HasColumnName("marital_status");

                entity.Property(e => e.Mortgage).HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccts).HasColumnName("No of Accts");

                entity.Property(e => e.NorthBank).HasColumnName("North Bank");

                entity.Property(e => e.Occupation)
                    .IsUnicode(false)
                    .HasColumnName("occupation");

                entity.Property(e => e.SavingsAccount).HasColumnName("SAVINGS ACCOUNT");

                entity.Property(e => e.SouthSouth).HasColumnName("South South");

                entity.Property(e => e.SouthWest).HasColumnName("South West");

                entity.Property(e => e.Staffflag)
                    .IsUnicode(false)
                    .HasColumnName("staffflag");

                entity.Property(e => e.Subsegment)
                    .IsUnicode(false)
                    .HasColumnName("subsegment");

                entity.Property(e => e.TermDepost).HasColumnName("TERM DEPOST");

                entity.Property(e => e.UniqueBranch).HasColumnName("Unique Branch");

                entity.Property(e => e.Ussd).HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure).HasColumnName("WEMA TREASURE");
            });

            modelBuilder.Entity<ReactivatedInactiveDormant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reactivated_inactive_dormant");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REGION");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_Date");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOL_DESC")
                    .IsFixedLength(true);

                entity.Property(e => e.Zone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<ReactivatedViaInflow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reactivated_via_Inflow");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.Balance)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.DateReactivatd)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_REACTIVATD");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .HasColumnName("DESCR");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Restricted).HasMaxLength(3);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<ReactivationFinacle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reactivation_finacle");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(80);

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.ReactivatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Reactivated_Date");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("sol_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<RecommendationPrediction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Recommendation_Prediction");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.AlatGoals).HasColumnName("ALAT_GOALS");

                entity.Property(e => e.AlatUser).HasColumnName("ALAT_USER");

                entity.Property(e => e.BusinessAccount).HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards).HasColumnName("CARDS");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CreditCardAccount).HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount).HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DomicillaryAccount).HasColumnName("DOMICILLARY_ACCOUNT");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan).HasColumnName("HCM_LOAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Loan).HasColumnName("LOAN");

                entity.Property(e => e.Mortgage).HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccounts)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("No_of_Accounts");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_date");

                entity.Property(e => e.SavingsAccount).HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.TermDeposit).HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.UniqueBranch)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Unique_Branch");

                entity.Property(e => e.Ussd).HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure).HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Request");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(528)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("BVN");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("FORACID");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE");

                entity.Property(e => e.Oct)
                    .HasMaxLength(20)
                    .HasColumnName("OCT");

                entity.Property(e => e.OctCrTurnover).HasColumnName("OCT_CR_TURNOVER");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PHONENO");

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP_MANAGER");
            });

            modelBuilder.Entity<RequestLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Request_Log");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RequestLabel)
                    .HasMaxLength(100)
                    .HasColumnName("request_label");

                entity.Property(e => e.RequestTime)
                    .HasMaxLength(100)
                    .HasColumnName("request_time");
            });

            modelBuilder.Entity<RestrictedBankwide>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Restricted_Bankwide");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.RunDate).HasColumnType("date");
            });

            modelBuilder.Entity<RetailAcctOfficerDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Retail_Acct_Officer_Details");

                entity.Property(e => e.DateOfEngagement)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE OF ENGAGEMENT");

                entity.Property(e => e.EmployeeCategory)
                    .HasMaxLength(255)
                    .HasColumnName("EMPLOYEE CATEGORY");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .HasColumnName("EMPLOYEE NAME");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("JOB TITLE");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(255)
                    .HasColumnName("STAFF ID");
            });

            modelBuilder.Entity<RetailBulkReactivate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("retail_bulk_reactivate");

                entity.Property(e => e.Foracid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("foracid");
            });

            modelBuilder.Entity<RetailCluster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Retail_Clusters");

                entity.HasIndex(e => e.SolId, "idx_sol")
                    .IsClustered();

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Cluster).HasMaxLength(255);

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<RevPayEbill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RevPay_Ebills");

                entity.Property(e => e.Income).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Report)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TranDate)
                    .HasColumnType("date")
                    .HasColumnName("tran_date");
            });

            modelBuilder.Entity<RmodelTable2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rmodel_table2");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.Modeldescription).HasColumnName("modeldescription");

                entity.Property(e => e.Modelname)
                    .HasMaxLength(100)
                    .HasColumnName("modelname");

                entity.Property(e => e.Modeltype)
                    .HasMaxLength(100)
                    .HasColumnName("modeltype");

                entity.Property(e => e.Modelversion).HasColumnName("modelversion");
            });

            modelBuilder.Entity<Ror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROR");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CifId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.DateActioned).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.ReferralCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Schm_Desc");
            });

            modelBuilder.Entity<RrNoTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RR_No_TRan");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_tran_date");
            });

            modelBuilder.Entity<RrNoTran2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RR_No_TRan2");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_tran_date");
            });

            modelBuilder.Entity<RrReturnedCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RR_ReturnedCustomers");

                entity.HasIndex(e => e.AccountNumber, "idx_acct_no");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.TransactionCharge).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RrTargetedCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RR_TargetedCustomers");

                entity.HasIndex(e => e.AccountNumber, "idx_AccountNumber");

                entity.Property(e => e.AccountNumber).HasMaxLength(100);

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.CurrentStatus).HasMaxLength(100);
            });

            modelBuilder.Entity<RrTransactionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RR_TransactionLog");

                entity.HasIndex(e => e.SourceAccountNumber, "idx_foracid");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<SalaryRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SalaryRequest");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(8)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(132)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Bvn)
                    .HasMaxLength(100)
                    .HasColumnName("BVN");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE");

                entity.Property(e => e.Oct)
                    .HasMaxLength(38)
                    .HasColumnName("OCT");

                entity.Property(e => e.OctCrTurnover)
                    .HasMaxLength(38)
                    .HasColumnName("OCT_CR_TURNOVER");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(25)
                    .HasColumnName("PHONENO");

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(15)
                    .HasColumnName("RELATIONSHIP_MANAGER");
            });

            modelBuilder.Entity<SaleZonesRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sale_Zones_Regions");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Directorate)
                    .HasMaxLength(255)
                    .HasColumnName("DIRECTORATE");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL ID");

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<SchmCodeT4r>(entity =>
            {
                entity.HasKey(e => e.SchmCode)
                    .HasName("PK__Schm_cod__9D4211339F832D8A");

                entity.ToTable("Schm_code_T4R");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("schm_code");
            });

            modelBuilder.Entity<Segmentation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("segmentation");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .HasColumnName("Account_Status")
                    .IsFixedLength(true);

                entity.Property(e => e.AgeGrp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("age_grp");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(160)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(50)
                    .HasColumnName("phoneno");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("sol_id");

                entity.Property(e => e.TotalCr).HasColumnName("Total_CR");

                entity.Property(e => e.TotalDr).HasColumnName("Total_DR");
            });

            modelBuilder.Entity<SmtCamStaged>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Smt_Cam_Staged");

                entity.Property(e => e.AcctStatus)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_STATUS");

                entity.Property(e => e.AcctStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_STATUS_DATE");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.PrevAcctStatus)
                    .HasMaxLength(1)
                    .HasColumnName("PREV_ACCT_STATUS");

                entity.Property(e => e.Source)
                    .HasMaxLength(3)
                    .HasColumnName("SOURCE");
            });

            modelBuilder.Entity<SmtCamTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Smt_CamTABLE");

                entity.Property(e => e.AcctStatus)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_STATUS");

                entity.Property(e => e.AcctStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_STATUS_DATE");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.PrevAcctStatus)
                    .HasMaxLength(1)
                    .HasColumnName("PREV_ACCT_STATUS");

                entity.Property(e => e.Source)
                    .HasMaxLength(3)
                    .HasColumnName("SOURCE");
            });

            modelBuilder.Entity<SolTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sol_tran");

                entity.Property(e => e.SolId)
                    .HasMaxLength(3)
                    .HasColumnName("SOL_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.SumAmt).HasColumnName("SUM_AMT");

                entity.Property(e => e.Tcount).HasColumnName("TCOUNT");
            });

            modelBuilder.Entity<SolTranDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sol_tran_db");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.SumAmt).HasColumnName("SUM_AMT");

                entity.Property(e => e.Tcount).HasColumnName("TCOUNT");
            });

            modelBuilder.Entity<SrcUssdcustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("src_USSDCustomers");

                entity.Property(e => e.CifId)
                    .HasMaxLength(20)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.DateRegistered).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasMaxLength(5);

                entity.Property(e => e.LastActivityDate).HasColumnType("date");

                entity.Property(e => e.MobileNetwork).HasMaxLength(20);

                entity.Property(e => e.OnUssd)
                    .HasMaxLength(5)
                    .HasColumnName("On_USSD");

                entity.Property(e => e.OnboardingChannels)
                    .HasMaxLength(30)
                    .HasColumnName("Onboarding_Channels");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Run_Date");

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<StampDutyTranDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STAMP_DUTY_TRAN_DET");

                entity.HasIndex(e => new { e.Acid, e.TranDate }, "NonClusteredIndex-20201215-123913");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.PartTranSrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("PART_TRAN_SRL_NUM");

                entity.Property(e => e.PrincipalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PRINCIPAL_AMT");

                entity.Property(e => e.ProcessedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSED_DATE");

                entity.Property(e => e.ProcessedFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PROCESSED_FLG");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRAN_DATE");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("TRAN_ID");
            });

            modelBuilder.Entity<StampDutyTranHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STAMP_DUTY_TRAN_HIST");

                entity.HasIndex(e => new { e.Acid, e.TranDate }, "NonClusteredIndex-20201215-114024");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.PartTranSrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("PART_TRAN_SRL_NUM");

                entity.Property(e => e.PrincipalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PRINCIPAL_AMT");

                entity.Property(e => e.ProcessedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PROCESSED_DATE");

                entity.Property(e => e.ProcessedFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PROCESSED_FLG");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRAN_DATE");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("TRAN_ID");
            });

            modelBuilder.Entity<StatusMonitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Status_Monitoring");

                entity.Property(e => e.Active)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("% Active");

                entity.Property(e => e.ActiveAlat).HasColumnName("Active_ALAT");

                entity.Property(e => e.ActiveBankwide).HasColumnName("Active_Bankwide");

                entity.Property(e => e.Dormant)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("% Dormant");

                entity.Property(e => e.DormantBankwide).HasColumnName("Dormant_Bankwide");

                entity.Property(e => e.Inactive)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("% Inactive");

                entity.Property(e => e.InactiveAlat).HasColumnName("Inactive_ALAT");

                entity.Property(e => e.InactiveBankwide).HasColumnName("Inactive_Bankwide");

                entity.Property(e => e.RestrictedAlat).HasColumnName("Restricted_ALAT");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_Date");
            });

            modelBuilder.Entity<T4r5f5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T4R_5F5");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.Branch)
                    .HasMaxLength(132)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Cif)
                    .HasMaxLength(25)
                    .HasColumnName("CIF");

                entity.Property(e => e.CrInflow)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CR_INFLOW");

                entity.Property(e => e.DebitCnt).HasColumnName("DEBIT_CNT");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EodBal)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("EOD_BAL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<T4r5f5Unqualified>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T4R_5F5_Unqualified");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.Branch)
                    .HasMaxLength(132)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.CrInflow)
                    .HasMaxLength(38)
                    .HasColumnName("CR_INFLOW");

                entity.Property(e => e.DebitCnt)
                    .HasMaxLength(38)
                    .HasColumnName("DEBIT_CNT");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EodBal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EOD_BAL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<TbAdminPortalCustomerMigToDigitalChannel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalCustomerMigToDigitalChannels");

                entity.Property(e => e.Accountsum).HasColumnName("accountsum");
            });

            modelBuilder.Entity<TbAdminPortalNtbdigitalCustomersCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalNTBDigitalCustomersCount");

                entity.Property(e => e.Dateofopening)
                    .HasColumnType("date")
                    .HasColumnName("dateofopening");
            });

            modelBuilder.Entity<TbAdminPortalTransactingDigitalCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalTransactingDigitalCustomers");

                entity.Property(e => e.Platform)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAdminPortalTransactingDigitalCustomerCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalTransactingDigitalCustomerCount");

                entity.Property(e => e.Accounts).HasColumnName("accounts");

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAdminPortalTransactingResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalTransactingResults");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.PartTranType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("part_tran_type");

                entity.Property(e => e.TranDate)
                    .HasColumnType("date")
                    .HasColumnName("tran_date");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 4)");
            });

            modelBuilder.Entity<TbAdminPortalTransactionsDigitalPlatform>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AdminPortalTransactionsDigitalPlatforms");

                entity.Property(e => e.Months).HasMaxLength(30);

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Years).HasColumnName("years");
            });

            modelBuilder.Entity<TbCardKpi>(entity =>
            {
                entity.ToTable("tb_CardKPIS");

                entity.Property(e => e.Branch).HasMaxLength(200);

                entity.Property(e => e.JulyDecFullTarget).HasMaxLength(200);

                entity.Property(e => e.Sol).HasMaxLength(200);

                entity.Property(e => e.Zone).HasMaxLength(200);
            });

            modelBuilder.Entity<TbDataRequestDownloadsAuditTrail>(entity =>
            {
                entity.ToTable("tb_DataRequestDownloadsAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Page).HasMaxLength(100);
            });

            modelBuilder.Entity<TbDataRequestGeneralInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_DataRequestGeneralInfo");

                entity.HasIndex(e => new { e.CifId, e.SolId, e.AccountName, e.AccountNo, e.SchmCode, e.Email }, "NonClusteredIndex-20211111-162043");

                entity.Property(e => e.AccountClosed)
                    .HasMaxLength(1)
                    .HasColumnName("Account_closed");

                entity.Property(e => e.AccountDeleted)
                    .HasMaxLength(1)
                    .HasColumnName("Account_Deleted");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(80)
                    .HasColumnName("Account_Name");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(16)
                    .HasColumnName("Account_No");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .HasColumnName("ACCOUNT_STATUS");

                entity.Property(e => e.AcctOwnership)
                    .HasMaxLength(1)
                    .HasColumnName("acct_ownership");

                entity.Property(e => e.AcctStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("acct_status_date");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("Cif_id");

                entity.Property(e => e.CurrBal).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.CurrNairaBal)
                    .HasMaxLength(38)
                    .HasColumnName("Curr_NairaBal");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DateOpened)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Opened");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_tran_date");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.PrevAcctStatus)
                    .HasMaxLength(1)
                    .HasColumnName("prev_acct_status");

                entity.Property(e => e.Product).HasMaxLength(100);

                entity.Property(e => e.Reason).HasMaxLength(5);

                entity.Property(e => e.Restriction).HasMaxLength(1);

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("Schm_code");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("Sol_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("Sol_id");

                entity.Property(e => e.TwoDaysBalNairEqv)
                    .HasMaxLength(38)
                    .HasColumnName("TwoDaysBalNairEQV");

                entity.Property(e => e.YstdBalNairEqv)
                    .HasMaxLength(38)
                    .HasColumnName("YstdBalNairEQV");
            });

            modelBuilder.Entity<TbDataRequestHtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_DataRequestHTD");

                entity.HasIndex(e => new { e.AccountNo, e.AcctName }, "NonClusteredIndex-20211110-133428");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(16)
                    .HasColumnName("Account_No");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.PartTranType)
                    .HasMaxLength(1)
                    .HasColumnName("part_tran_type");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("tran_amt");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tran_date");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("tran_id");

                entity.Property(e => e.TranParticular)
                    .HasMaxLength(50)
                    .HasColumnName("tran_particular");

                entity.Property(e => e.TranSubType)
                    .HasMaxLength(2)
                    .HasColumnName("tran_sub_type");

                entity.Property(e => e.ValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("value_date");
            });

            modelBuilder.Entity<TbDataRequestLoginAuditTrail>(entity =>
            {
                entity.ToTable("tb_DataRequestLoginAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TbDd3portalDownloadsAuditTrail>(entity =>
            {
                entity.ToTable("tb_DD3PortalDownloadsAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Page).HasMaxLength(100);
            });

            modelBuilder.Entity<TbDd3portalLoginAuditTrail>(entity =>
            {
                entity.ToTable("tb_DD3PortalLoginAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TbDownloadsAuditTrail>(entity =>
            {
                entity.ToTable("tb_DownloadsAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Page).HasMaxLength(100);
            });

            modelBuilder.Entity<TbFiveForFiveActiveNotTransacting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveActiveNotTransacting");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Balance).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Band)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<TbFiveForFiveDownloadsAuditTrail>(entity =>
            {
                entity.ToTable("tb_FiveForFiveDownloadsAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Page).HasMaxLength(100);
            });

            modelBuilder.Entity<TbFiveForFiveInactiveAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveInactiveAccounts");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Balance).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Band)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("date")
                    .HasColumnName("Last_Tran_Date");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<TbFiveForFiveLoginAuditTrail>(entity =>
            {
                entity.ToTable("tb_FiveForFiveLoginAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TbFiveForFiveReactivation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveReactivation");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.DateReactivated).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(80);

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("region");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("schm_code");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("schm_desc");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("sol_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Zone)
                    .HasMaxLength(255)
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<TbFiveForFiveReactivationLeaderBoard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveReactivationLeaderBoard");

                entity.Property(e => e.ActualJune).HasColumnName("Actual_June");

                entity.Property(e => e.Fy2021).HasColumnName("FY2021");

                entity.Property(e => e.Measure)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Mnth)
                    .HasMaxLength(30)
                    .HasColumnName("mnth");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("sol_desc");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("sol_id");

                entity.Property(e => e.Yr)
                    .HasMaxLength(30)
                    .HasColumnName("yr");

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<TbFiveForFiveRestrictedAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveRestrictedAccount");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Account_status");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("Acct_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictedStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Restricted_Status");

                entity.Property(e => e.RunDate).HasColumnType("date");
            });

            modelBuilder.Entity<TbFiveForFiveT4rqualifiedAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_FiveForFiveT4RQualifiedAccounts");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.Bvn)
                    .HasMaxLength(220)
                    .HasColumnName("BVN");

                entity.Property(e => e.Cif)
                    .HasMaxLength(25)
                    .HasColumnName("CIF");

                entity.Property(e => e.CrInflow)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CR_INFLOW");

                entity.Property(e => e.CustDob)
                    .HasColumnType("date")
                    .HasColumnName("CUST_DOB");

                entity.Property(e => e.DebitCnt).HasColumnName("DEBIT_CNT");

                entity.Property(e => e.Directorate)
                    .HasMaxLength(255)
                    .HasColumnName("DIRECTORATE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EodBal)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("EOD_BAL");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("GENDER");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(25)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("RUN_DATE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .HasColumnName("SOL_ID");
            });

            modelBuilder.Entity<TbKpi>(entity =>
            {
                entity.ToTable("tb_KPIS");

                entity.Property(e => e.Branch).HasMaxLength(100);

                entity.Property(e => e.Fy2021).HasColumnName("FY2021");

                entity.Property(e => e.Zone).HasMaxLength(100);
            });

            modelBuilder.Entity<TbLoginAuditTrail>(entity =>
            {
                entity.ToTable("tb_LoginAuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TbReactivationKpi>(entity =>
            {
                entity.ToTable("tb_ReactivationKPIS");

                entity.Property(e => e.Branch).HasMaxLength(100);

                entity.Property(e => e.Fy2021).HasColumnName("FY2021");

                entity.Property(e => e.Sol).HasMaxLength(10);

                entity.Property(e => e.Zone).HasMaxLength(100);
            });

            modelBuilder.Entity<TbWebAppCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_WebAppCustomer");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.Alat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALAT");

                entity.Property(e => e.AlatGoalBasedLoan)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ALAT GOAL BASED LOAN");

                entity.Property(e => e.AlatGoals)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALAT_GOALS");

                entity.Property(e => e.BusinessAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARDS");

                entity.Property(e => e.ChurnStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Churn_Status");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CreditCardAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CurrentProducts).HasColumnName("Current_Products");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DomicillaryAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILLARY_ACCOUNT");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOAN");

                entity.Property(e => e.Mortgage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccounts)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("No_of_Accounts");

                entity.Property(e => e.Orgkey)
                    .IsUnicode(false)
                    .HasColumnName("ORGKEY");

                entity.Property(e => e.PhoneNo)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.SavingsAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.Segmentation)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("segmentation");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sol_ID");

                entity.Property(e => e.TermDeposit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.Ussd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<TbWebAppCustomerCluster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_WebAppCustomerCluster");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("cif_id");

                entity.Property(e => e.CustFirstName)
                    .IsUnicode(false)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .IsUnicode(false)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("foracid");

                entity.Property(e => e.MonthName).HasMaxLength(30);

                entity.Property(e => e.Orgkey)
                    .IsUnicode(false)
                    .HasColumnName("orgkey");

                entity.Property(e => e.PhoneNo)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("sol_id");

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(30);

                entity.Property(e => e.SumAmount)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Sum_Amount");

                entity.Property(e => e.Tcount).HasColumnName("TCount");

                entity.Property(e => e.TotalTransactionVolume)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Total_Transaction_Volume");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbWebAppCustomerReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_WebAppCustomerReport");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Age_Group");

                entity.Property(e => e.Alat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALAT");

                entity.Property(e => e.AlatGoalBasedLoan)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ALAT GOAL BASED LOAN");

                entity.Property(e => e.AlatGoals)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALAT_GOALS");

                entity.Property(e => e.BusinessAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_ACCOUNT");

                entity.Property(e => e.Cards)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARDS");

                entity.Property(e => e.ChurnStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Churn_Status");

                entity.Property(e => e.CifId)
                    .HasMaxLength(100)
                    .HasColumnName("cif_id");

                entity.Property(e => e.ClvStatus)
                    .HasMaxLength(100)
                    .HasColumnName("CLV_Status");

                entity.Property(e => e.CreditCardAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CARD_ACCOUNT");

                entity.Property(e => e.CurrentAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURRENT_ACCOUNT");

                entity.Property(e => e.CurrentProducts).HasColumnName("Current_Products");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_first_name");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .HasColumnName("cust_last_name");

                entity.Property(e => e.DomicillaryAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILLARY_ACCOUNT");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.HcmLoan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HCM_LOAN");

                entity.Property(e => e.Loan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOAN");

                entity.Property(e => e.Mortgage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MORTGAGE");

                entity.Property(e => e.NoOfAccounts)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("No_of_Accounts");

                entity.Property(e => e.Orgkey)
                    .IsUnicode(false)
                    .HasColumnName("ORGKEY");

                entity.Property(e => e.PhoneNo)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.SavingsAccount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SAVINGS_ACCOUNT");

                entity.Property(e => e.Segmentation)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("segmentation");

                entity.Property(e => e.SolId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sol_ID");

                entity.Property(e => e.TermDeposit)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TERM_DEPOSIT");

                entity.Property(e => e.Ussd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USSD");

                entity.Property(e => e.WemaTreasure)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WEMA_TREASURE");
            });

            modelBuilder.Entity<TemitopePnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temitope_PNT");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foracid");
            });

            modelBuilder.Entity<TestReactivation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Reactivation");

                entity.Property(e => e.AccountNumber).HasMaxLength(10);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ChannelID");

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .HasColumnName("CIF");

                entity.Property(e => e.ReferredBy).HasMaxLength(10);
            });

            modelBuilder.Entity<TestRor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_ROR");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.CifId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Reactivationdate)
                    .HasColumnType("date")
                    .HasColumnName("REACTIVATIONDATE");

                entity.Property(e => e.Referralcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERRALCODE");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SCHM_DESC");
            });

            modelBuilder.Entity<TmpGam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_gam");

                entity.Property(e => e.AcctClassificationFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLASSIFICATION_FLG");

                entity.Property(e => e.AcctClsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_CLS_DATE");

                entity.Property(e => e.AcctClsFlg)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_CLS_FLG");

                entity.Property(e => e.AcctCrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("ACCT_CRNCY_CODE");

                entity.Property(e => e.AcctMgrUserId)
                    .HasMaxLength(15)
                    .HasColumnName("ACCT_MGR_USER_ID");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctOpnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCT_OPN_DATE");

                entity.Property(e => e.AcctOwnership)
                    .HasMaxLength(1)
                    .HasColumnName("ACCT_OWNERSHIP");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.BalOnFrezDate)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("BAL_ON_FREZ_DATE");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(5)
                    .HasColumnName("CHANNEL_ID");

                entity.Property(e => e.CifId)
                    .HasMaxLength(50)
                    .HasColumnName("CIF_ID");

                entity.Property(e => e.ClrBalAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CLR_BAL_AMT");

                entity.Property(e => e.CumCrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_CR_AMT");

                entity.Property(e => e.CumDrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("CUM_DR_AMT");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(16)
                    .HasColumnName("FORACID");

                entity.Property(e => e.FrezCode)
                    .HasMaxLength(1)
                    .HasColumnName("FREZ_CODE");

                entity.Property(e => e.FrezReasonCode)
                    .HasMaxLength(5)
                    .HasColumnName("FREZ_REASON_CODE");

                entity.Property(e => e.FxCumCrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("FX_CUM_CR_AMT");

                entity.Property(e => e.FxCumDrAmt)
                    .HasColumnType("numeric(25, 4)")
                    .HasColumnName("FX_CUM_DR_AMT");

                entity.Property(e => e.GlSubHeadCode)
                    .HasMaxLength(5)
                    .HasColumnName("GL_SUB_HEAD_CODE");

                entity.Property(e => e.IntCollFlg)
                    .HasMaxLength(1)
                    .HasColumnName("INT_COLL_FLG");

                entity.Property(e => e.IntPaidFlg)
                    .HasMaxLength(1)
                    .HasColumnName("INT_PAID_FLG");

                entity.Property(e => e.LastAnyTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_ANY_TRAN_DATE");

                entity.Property(e => e.LastFrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_FREZ_DATE");

                entity.Property(e => e.LastTranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE");

                entity.Property(e => e.LastTranDateCr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_CR");

                entity.Property(e => e.LastTranDateDr)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_TRAN_DATE_DR");

                entity.Property(e => e.LastTranIdCr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_CR");

                entity.Property(e => e.LastTranIdDr)
                    .HasMaxLength(9)
                    .HasColumnName("LAST_TRAN_ID_DR");

                entity.Property(e => e.LastUnfrezDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_UNFREZ_DATE");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.LienAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("LIEN_AMT");

                entity.Property(e => e.MinValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MIN_VALUE_DATE");

                entity.Property(e => e.NairaBalance)
                    .HasMaxLength(38)
                    .HasColumnName("NAIRA_BALANCE");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.SanctLim)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("SANCT_LIM");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(5)
                    .HasColumnName("SCHM_CODE");

                entity.Property(e => e.SchmDesc)
                    .HasMaxLength(100)
                    .HasColumnName("SCHM_DESC");

                entity.Property(e => e.SchmType)
                    .HasMaxLength(3)
                    .HasColumnName("SCHM_TYPE");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.TwoDaysBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("TWO_DAYS_BAL_NAIREQV");

                entity.Property(e => e.YstdBalNaireqv)
                    .HasMaxLength(38)
                    .HasColumnName("YSTD_BAL_NAIREQV");
            });

            modelBuilder.Entity<ToyinSal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Toyin_sal");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FORACID");
            });

            modelBuilder.Entity<Tph>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TPH");

                entity.Property(e => e.Acid)
                    .HasMaxLength(11)
                    .HasColumnName("ACID");

                entity.Property(e => e.AdjustedIntAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("ADJUSTED_INT_AMT");

                entity.Property(e => e.AdjustedProvAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("ADJUSTED_PROV_AMT");

                entity.Property(e => e.AdjustedTdsAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("ADJUSTED_TDS_AMT");

                entity.Property(e => e.BankId)
                    .HasMaxLength(8)
                    .HasColumnName("BANK_ID");

                entity.Property(e => e.ClosureType)
                    .HasMaxLength(1)
                    .HasColumnName("CLOSURE_TYPE");

                entity.Property(e => e.ClsValueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CLS_VALUE_DATE");

                entity.Property(e => e.ClsrPurposeFlg)
                    .HasMaxLength(1)
                    .HasColumnName("CLSR_PURPOSE_FLG");

                entity.Property(e => e.CollectPenalIntFlg)
                    .HasMaxLength(1)
                    .HasColumnName("COLLECT_PENAL_INT_FLG");

                entity.Property(e => e.ContractedRoi)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("CONTRACTED_ROI");

                entity.Property(e => e.CurrPdCycleAdjAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("CURR_PD_CYCLE_ADJ_AMT");

                entity.Property(e => e.DelFlg)
                    .HasMaxLength(1)
                    .HasColumnName("DEL_FLG");

                entity.Property(e => e.EffectiveRoi)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("EFFECTIVE_ROI");

                entity.Property(e => e.GlDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GL_DATE");

                entity.Property(e => e.LchgTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LCHG_TIME");

                entity.Property(e => e.LchgUserId)
                    .HasMaxLength(15)
                    .HasColumnName("LCHG_USER_ID");

                entity.Property(e => e.NormalRoi)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("NORMAL_ROI");

                entity.Property(e => e.PartCloseAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PART_CLOSE_AMT");

                entity.Property(e => e.PartCloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PART_CLOSE_DATE");

                entity.Property(e => e.PartCloseInterestRate)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("PART_CLOSE_INTEREST_RATE");

                entity.Property(e => e.PartClsPenaltyAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PART_CLS_PENALTY_AMT");

                entity.Property(e => e.PastPdCycleAdjAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PAST_PD_CYCLE_ADJ_AMT");

                entity.Property(e => e.PenalIntForFullPerdFlg)
                    .HasMaxLength(1)
                    .HasColumnName("PENAL_INT_FOR_FULL_PERD_FLG");

                entity.Property(e => e.PenalRoi)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("PENAL_ROI");

                entity.Property(e => e.PreClsIntTblCode)
                    .HasMaxLength(5)
                    .HasColumnName("PRE_CLS_INT_TBL_CODE");

                entity.Property(e => e.PreClsPenaltyFee)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("PRE_CLS_PENALTY_FEE");

                entity.Property(e => e.RcreTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RCRE_TIME");

                entity.Property(e => e.RcreUserId)
                    .HasMaxLength(15)
                    .HasColumnName("RCRE_USER_ID");

                entity.Property(e => e.RenSrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("REN_SRL_NUM");

                entity.Property(e => e.RepaymentAmt)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("REPAYMENT_AMT");

                entity.Property(e => e.SrlNum)
                    .HasMaxLength(4)
                    .HasColumnName("SRL_NUM");

                entity.Property(e => e.TotProfAmtAfterPartCls)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("TOT_PROF_AMT_AFTER_PART_CLS");

                entity.Property(e => e.TphCrncyCode)
                    .HasMaxLength(3)
                    .HasColumnName("TPH_CRNCY_CODE");

                entity.Property(e => e.TranId)
                    .HasMaxLength(9)
                    .HasColumnName("TRAN_ID");

                entity.Property(e => e.TsCnt)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("TS_CNT");
            });

            modelBuilder.Entity<TransactingBranch5f5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("transacting_Branch_5F5");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.Month).HasMaxLength(30);

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RunDate)
                    .HasColumnType("date")
                    .HasColumnName("Run_Date");

                entity.Property(e => e.SolId)
                    .HasMaxLength(10)
                    .HasColumnName("Sol_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.TotalTranCount).HasColumnName("Total_tran_count");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Year).HasMaxLength(30);

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<TransactionLogBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionLog_Backup");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cif");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountNumber).HasMaxLength(20);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TropsBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TROPS_BOND");

                entity.Property(e => e.BondType)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BOND_TYPE");

                entity.Property(e => e.BuyOrSell)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUY_OR_SELL");

                entity.Property(e => e.ContractRate)
                    .HasMaxLength(38)
                    .HasColumnName("CONTRACT_RATE");

                entity.Property(e => e.CpartyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPARTY_ID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.DaysToMaturity)
                    .HasMaxLength(38)
                    .HasColumnName("DAYS_TO_MATURITY");

                entity.Property(e => e.DealDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEAL_DATE");

                entity.Property(e => e.DealIdentifier)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_IDENTIFIER");

                entity.Property(e => e.DealNo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("DEAL_NO");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MATURITY_DATE");

                entity.Property(e => e.PrincipalAmount)
                    .HasMaxLength(38)
                    .HasColumnName("PRINCIPAL_AMOUNT");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.Yield)
                    .HasMaxLength(38)
                    .HasColumnName("YIELD");
            });

            modelBuilder.Entity<TropsFx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TROPS_FX");

                entity.Property(e => e.Ccy1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY1");

                entity.Property(e => e.Ccy2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCY2");

                entity.Property(e => e.ContractRate)
                    .HasMaxLength(38)
                    .HasColumnName("CONTRACT_RATE");

                entity.Property(e => e.CpartyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPARTY_ID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.DealDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEAL_DATE");

                entity.Property(e => e.DealNo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("DEAL_NO");

                entity.Property(e => e.DealType)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_TYPE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FarAmt)
                    .HasMaxLength(38)
                    .HasColumnName("FAR_AMT");

                entity.Property(e => e.FarRate)
                    .HasMaxLength(38)
                    .HasColumnName("FAR_RATE");

                entity.Property(e => e.FxType)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FX_TYPE");

                entity.Property(e => e.Mrs)
                    .HasMaxLength(38)
                    .HasColumnName("MRS");

                entity.Property(e => e.NearAmt)
                    .HasMaxLength(38)
                    .HasColumnName("NEAR_AMT");

                entity.Property(e => e.NearRate)
                    .HasMaxLength(38)
                    .HasColumnName("NEAR_RATE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");
            });

            modelBuilder.Entity<TropsTbill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TROPS_TBILLS");

                entity.Property(e => e.BuyOrSell)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BUY_OR_SELL");

                entity.Property(e => e.ContractRate)
                    .HasMaxLength(38)
                    .HasColumnName("CONTRACT_RATE");

                entity.Property(e => e.CpartyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPARTY_ID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.DaysToMaturity)
                    .HasMaxLength(38)
                    .HasColumnName("DAYS_TO_MATURITY");

                entity.Property(e => e.DealDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEAL_DATE");

                entity.Property(e => e.DealIdentifier)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_IDENTIFIER");

                entity.Property(e => e.DealNo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("DEAL_NO");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.PrincipalAmount)
                    .HasMaxLength(38)
                    .HasColumnName("PRINCIPAL_AMOUNT");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE");

                entity.Property(e => e.TbillsType)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TBILLS_TYPE");

                entity.Property(e => e.Yield)
                    .HasMaxLength(38)
                    .HasColumnName("YIELD");
            });

            modelBuilder.Entity<Ussdcustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USSDCustomer");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSchemeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Channels)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.LastActivity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNetwork)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnUssd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("On_USSD");

                entity.Property(e => e.PrimaryAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoleId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SoleID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UssdtranDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USSDtranDetails");

                entity.HasIndex(e => new { e.TransactionDate, e.ResponseCode }, "NonClusteredIndex-20210320-135143");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Channel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DestinationAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncomeAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate).HasColumnType("datetime");

                entity.Property(e => e.SourceAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SuspenseAccountNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionFee).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransactionReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueIdentifier)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UssdtransactionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USSDTransactionLog");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Responsecode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responsecode");

                entity.Property(e => e.Soleid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("soleid");

                entity.Property(e => e.Sourceaccountnumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sourceaccountnumber");

                entity.Property(e => e.Transactionstatus).HasColumnName("transactionstatus");

                entity.Property(e => e.Transactiontype).HasColumnName("transactiontype");
            });

            modelBuilder.Entity<VolCustomerStopOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VOL_Customer_Stop_Order");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Volume)
                    .HasMaxLength(38)
                    .HasColumnName("VOLUME");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VolFormm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VOL_Formm");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(6)
                    .HasColumnName("BRANCH_CODE");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VolGetChequeForClearing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VOL_Get_Cheque_For_Clearing");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Value)
                    .HasMaxLength(38)
                    .HasColumnName("VALUE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VolInvestmentBooked>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VOL_Investment_Booked");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Value)
                    .HasMaxLength(38)
                    .HasColumnName("VALUE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VolManagerChgIssued>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Vol_Manager_Chg_Issued");

                entity.Property(e => e.Count)
                    .HasMaxLength(38)
                    .HasColumnName("COUNT");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Volume)
                    .HasMaxLength(38)
                    .HasColumnName("VOLUME");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(41)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VolRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VOL_Region");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("SOL_DESC");

                entity.Property(e => e.SolId)
                    .HasMaxLength(8)
                    .HasColumnName("SOL_ID");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VwAdminPortalTransactingResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AdminPortalTransactingResults");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(80)
                    .HasColumnName("acct_name");

                entity.Property(e => e.PartTranType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("part_tran_type");

                entity.Property(e => e.TranDate)
                    .HasColumnType("date")
                    .HasColumnName("tran_date");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 4)");
            });

            modelBuilder.Entity<VwAtmNou>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ATM_NOU");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<VwAtmOnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ATM_ON_US");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<VwAtmRou>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ATM_ROU");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<VwFinEchannel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FIN_ECHANNEL");

                entity.Property(e => e.Region)
                    .HasMaxLength(11)
                    .HasColumnName("REGION");

                entity.Property(e => e.SolDesc)
                    .HasMaxLength(132)
                    .HasColumnName("sol_desc");

                entity.Property(e => e.TranAmt)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("tran_amt");

                entity.Property(e => e.Typez)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typez");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");

                entity.Property(e => e.Zone)
                    .HasMaxLength(14)
                    .HasColumnName("ZONE");
            });

            modelBuilder.Entity<VwPosNou>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_POS_NOU");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<VwPosOnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_POS_ON_US");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<VwWebAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Web_All");

                entity.Property(e => e.AmountRequested)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Amount Requested");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ResponseMeaning)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("response_meaning");

                entity.Property(e => e.RspCodeRsp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("rsp_code_rsp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_MONTH");
            });

            modelBuilder.Entity<WtaTurn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WTA_Turn");

                entity.Property(e => e.Acid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("acid");

                entity.Property(e => e.Apr2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Aug2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Dec2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Feb2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Feb2021).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Foracid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("foracid");

                entity.Property(e => e.Jan2021).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Jul2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Jun2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Mar2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.May2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Nov2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Oct2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.SchmCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("schm_Code");

                entity.Property(e => e.Sept2020).HasColumnType("numeric(38, 4)");
            });

            modelBuilder.Entity<_5for5User>(entity =>
            {
                entity.ToTable("5For5User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(256);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsRegionalHead).HasColumnName("isRegionalHead");

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.ProfiledDate).HasColumnType("datetime");

                entity.Property(e => e.Region).HasMaxLength(256);

                entity.Property(e => e.SentProfiledMail).HasColumnName("sentProfiledMail");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Zone).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
