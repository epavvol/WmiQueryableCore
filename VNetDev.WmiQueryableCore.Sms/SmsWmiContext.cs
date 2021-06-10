using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.Sms.Classes;

namespace VNetDev.WmiQueryableCore.Sms
{
    /// <summary>
    /// Representation of WMI namespace of Microsoft Endpoint Configuration Manager version 2002
    /// </summary>
    [WmiContext(MethodDefaultReturnProperty = "StatusCode")]
    public class SmsWmiContext : WmiContext
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SmsWmiContext()
        {
        }

        /// <summary>
        /// Constructor allows to set WmiContextOptions object during context initialization.
        /// </summary>
        /// <param name="options">Preconfigured WmiContextOptions object</param>
        public SmsWmiContext(WmiContextOptions options) : base(options)
        {
        }

        #endregion

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Application</c> collection
        /// </summary>
        public WmiClassSet<SmsAadApplication> SmsAadApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Application_Ex</c> collection
        /// </summary>
        public WmiClassSet<SmsAadApplicationEx> SmsAadApplicationEx { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Discovery_Settings</c> collection
        /// </summary>
        public WmiClassSet<SmsAadDiscoverySettings> SmsAadDiscoverySettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Sync_Settings</c> collection
        /// </summary>
        public WmiClassSet<SmsAadSyncSettings> SmsAadSyncSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Tenant</c> collection
        /// </summary>
        public WmiClassSet<SmsAadTenant> SmsAadTenant { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Tenant_Ex</c> collection
        /// </summary>
        public WmiClassSet<SmsAadTenantEx> SmsAadTenantEx { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AAD_Tenant_Ex_Property</c> collection
        /// </summary>
        public WmiClassSet<SmsAadTenantExProperty> SmsAadTenantExProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ActionAccountResult</c> collection
        /// </summary>
        public WmiClassSet<SmsActionAccountResult> SmsActionAccountResult { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADDomain</c> collection
        /// </summary>
        public WmiClassSet<SmsAdDomain> SmsAdDomain { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADForest</c> collection
        /// </summary>
        public WmiClassSet<SmsAdForest> SmsAdForest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADForestDiscoveryStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAdForestDiscoveryStatus> SmsAdForestDiscoveryStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Admin</c> collection
        /// </summary>
        public WmiClassSet<SmsAdmin> SmsAdmin { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdminCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsAdminCategory> SmsAdminCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdminExtendedData</c> collection
        /// </summary>
        public WmiClassSet<SmsAdminExtendedData> SmsAdminExtendedData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdminRole</c> collection
        /// </summary>
        public WmiClassSet<SmsAdminRole> SmsAdminRole { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdminUIContent</c> collection
        /// </summary>
        public WmiClassSet<SmsAdminUiContent> SmsAdminUiContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADRDeploymentSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAdrDeploymentSettings> SmsAdrDeploymentSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADSite</c> collection
        /// </summary>
        public WmiClassSet<SmsAdSite> SmsAdSite { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ADSubnet</c> collection
        /// </summary>
        public WmiClassSet<SmsAdSubnet> SmsAdSubnet { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdvancedAntimalwareSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvancedAntimalwareSettings> SmsAdvancedAntimalwareSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdvancedThreatProtectionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvancedThreatProtectionSettings> SmsAdvancedThreatProtectionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Advertisement</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvertisement> SmsAdvertisement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdvertisementInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvertisementInfo> SmsAdvertisementInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdvertisementStatusInformation</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvertisementStatusInformation> SmsAdvertisementStatusInformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AdvertToSourceSite_a</c> collection
        /// </summary>
        public WmiClassSet<SmsAdvertToSourceSiteA> SmsAdvertToSourceSiteA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AfwAccountStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAfwAccountStatus> SmsAfwAccountStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AfwAppConfigSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAfwAppConfigSettings> SmsAfwAppConfigSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AICategory</c> collection
        /// </summary>
        public WmiClassSet<SmsAiCategory> SmsAiCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AIHardwareRequirements</c> collection
        /// </summary>
        public WmiClassSet<SmsAiHardwareRequirements> SmsAiHardwareRequirements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AIMLSParser</c> collection
        /// </summary>
        public WmiClassSet<SmsAimlsParser> SmsAimlsParser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AIProxy</c> collection
        /// </summary>
        public WmiClassSet<SmsAiProxy> SmsAiProxy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AISoftwareList</c> collection
        /// </summary>
        public WmiClassSet<SmsAiSoftwareList> SmsAiSoftwareList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AllDistributionPoint</c> collection
        /// </summary>
        public WmiClassSet<SmsAllDistributionPoint> SmsAllDistributionPoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AllowOrDenyAppsSetting</c> collection
        /// </summary>
        public WmiClassSet<SmsAllowOrDenyAppsSetting> SmsAllowOrDenyAppsSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AmPolicySummary</c> collection
        /// </summary>
        public WmiClassSet<SmsAmPolicySummary> SmsAmPolicySummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AMTCertificate</c> collection
        /// </summary>
        public WmiClassSet<SmsAmtCertificate> SmsAmtCertificate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AMTMachineInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsAmtMachineInfo> SmsAmtMachineInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareAdvancedSettingsConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareAdvancedSettingsConfig> SmsAntimalwareAdvancedSettingsConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareConfig> SmsAntimalwareConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareExcludedSettingsConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareExcludedSettingsConfig> SmsAntimalwareExcludedSettingsConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareRealtimeSettingsConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareRealtimeSettingsConfig> SmsAntimalwareRealtimeSettingsConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareScanConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareScanConfig> SmsAntimalwareScanConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareScanScheduleConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareScanScheduleConfig> SmsAntimalwareScanScheduleConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareSettings> SmsAntimalwareSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareSettingsDefault</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareSettingsDefault> SmsAntimalwareSettingsDefault { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareSignatureUpdateConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareSignatureUpdateConfig> SmsAntimalwareSignatureUpdateConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareSpynetConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareSpynetConfig> SmsAntimalwareSpynetConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareThreatDefaultActionConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareThreatDefaultActionConfig> SmsAntimalwareThreatDefaultActionConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AntimalwareThreatOverrideActionConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsAntimalwareThreatOverrideActionConfig> SmsAntimalwareThreatOverrideActionConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_APermission</c> collection
        /// </summary>
        public WmiClassSet<SmsAPermission> SmsAPermission { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppConflictsData</c> collection
        /// </summary>
        public WmiClassSet<SmsAppConflictsData> SmsAppConflictsData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDependenceRelation</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDependenceRelation> SmsAppDependenceRelation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDependenceRelation_Flat</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDependenceRelationFlat> SmsAppDependenceRelationFlat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDependencyData</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDependencyData> SmsAppDependencyData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentAssetDetails> SmsAppDeploymentAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentErrorAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentErrorAssetDetails> SmsAppDeploymentErrorAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentErrorStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentErrorStatus> SmsAppDeploymentErrorStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentRequirementsNotMetAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentRequirementsNotMetAssetDetails> SmsAppDeploymentRequirementsNotMetAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentRequirementsNotMetStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentRequirementsNotMetStatus> SmsAppDeploymentRequirementsNotMetStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDeploymentStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDeploymentStatus> SmsAppDeploymentStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppDTDeploymentSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsAppDtDeploymentSummary> SmsAppDtDeploymentSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppFailedVEsData</c> collection
        /// </summary>
        public WmiClassSet<SmsAppFailedVEsData> SmsAppFailedVEsData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppGroupDeploymentAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsAppGroupDeploymentAssetDetails> SmsAppGroupDeploymentAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppGroupDeploymentStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsAppGroupDeploymentStatus> SmsAppGroupDeploymentStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppGroupDeploymentStatusData</c> collection
        /// </summary>
        public WmiClassSet<SmsAppGroupDeploymentStatusData> SmsAppGroupDeploymentStatusData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Application</c> collection
        /// </summary>
        public WmiClassSet<SmsApplication> SmsApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationAssignment> SmsApplicationAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationCondition</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationCondition> SmsApplicationCondition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationGroup> SmsApplicationGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationGroupAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationGroupAssignment> SmsApplicationGroupAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationLatest</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationLatest> SmsApplicationLatest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationManagementAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationManagementAgentConfig> SmsApplicationManagementAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationPolicyTemplateBinding</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationPolicyTemplateBinding> SmsApplicationPolicyTemplateBinding { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationPublishingItem</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationPublishingItem> SmsApplicationPublishingItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationRequest</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationRequest> SmsApplicationRequest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ApplicationTechnology</c> collection
        /// </summary>
        public WmiClassSet<SmsApplicationTechnology> SmsApplicationTechnology { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppRelation_Flat</c> collection
        /// </summary>
        public WmiClassSet<SmsAppRelationFlat> SmsAppRelationFlat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppRequirementsData</c> collection
        /// </summary>
        public WmiClassSet<SmsAppRequirementsData> SmsAppRequirementsData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AppRestrictionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsAppRestrictionSettings> SmsAppRestrictionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ARoleOperation</c> collection
        /// </summary>
        public WmiClassSet<SmsARoleOperation> SmsARoleOperation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AssignedDeviceApplications</c> collection
        /// </summary>
        public WmiClassSet<SmsAssignedDeviceApplications> SmsAssignedDeviceApplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AssociatedSecuredCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsAssociatedSecuredCategory> SmsAssociatedSecuredCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AuthorizationList</c> collection
        /// </summary>
        public WmiClassSet<SmsAuthorizationList> SmsAuthorizationList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AutoDeployment</c> collection
        /// </summary>
        public WmiClassSet<SmsAutoDeployment> SmsAutoDeployment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AvailableOperation</c> collection
        /// </summary>
        public WmiClassSet<SmsAvailableOperation> SmsAvailableOperation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Azure_CloudService</c> collection
        /// </summary>
        public WmiClassSet<SmsAzureCloudService> SmsAzureCloudService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Azure_CloudServiceHist</c> collection
        /// </summary>
        public WmiClassSet<SmsAzureCloudServiceHist> SmsAzureCloudServiceHist { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AzureEnvironments</c> collection
        /// </summary>
        public WmiClassSet<SmsAzureEnvironments> SmsAzureEnvironments { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AzureService</c> collection
        /// </summary>
        public WmiClassSet<SmsAzureService> SmsAzureService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_AzureServicesTask</c> collection
        /// </summary>
        public WmiClassSet<SmsAzureServicesTask> SmsAzureServicesTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BannerNotifications</c> collection
        /// </summary>
        public WmiClassSet<SmsBannerNotifications> SmsBannerNotifications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BaseAssociation</c> collection
        /// </summary>
        public WmiClassSet<SmsBaseAssociation> SmsBaseAssociation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BaseClass</c> collection
        /// </summary>
        public WmiClassSet<SmsBaseClass> SmsBaseClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BaselineAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsBaselineAssignment> SmsBaselineAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BigGreenButtonConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsBigGreenButtonConfig> SmsBigGreenButtonConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BitlockerManagementSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsBitlockerManagementSettings> SmsBitlockerManagementSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BITS2Config</c> collection
        /// </summary>
        public WmiClassSet<SmsBits2Config> SmsBits2Config { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BootImagePackage</c> collection
        /// </summary>
        public WmiClassSet<SmsBootImagePackage> SmsBootImagePackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BootImagePackage_DriverRef</c> collection
        /// </summary>
        public WmiClassSet<SmsBootImagePackageDriverRef> SmsBootImagePackageDriverRef { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Boundary</c> collection
        /// </summary>
        public WmiClassSet<SmsBoundary> SmsBoundary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BoundaryGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsBoundaryGroup> SmsBoundaryGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BoundaryGroupMembers</c> collection
        /// </summary>
        public WmiClassSet<SmsBoundaryGroupMembers> SmsBoundaryGroupMembers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BoundaryGroupRelationships</c> collection
        /// </summary>
        public WmiClassSet<SmsBoundaryGroupRelationships> SmsBoundaryGroupRelationships { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BoundaryGroupSiteSystems</c> collection
        /// </summary>
        public WmiClassSet<SmsBoundaryGroupSiteSystems> SmsBoundaryGroupSiteSystems { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_BulkEnrollmentProfiles</c> collection
        /// </summary>
        public WmiClassSet<SmsBulkEnrollmentProfiles> SmsBulkEnrollmentProfiles { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Category_LocalizedProperties</c> collection
        /// </summary>
        public WmiClassSet<SmsCategoryLocalizedProperties> SmsCategoryLocalizedProperties { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CategoryInstance</c> collection
        /// </summary>
        public WmiClassSet<SmsCategoryInstance> SmsCategoryInstance { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CategoryInstanceBase</c> collection
        /// </summary>
        public WmiClassSet<SmsCategoryInstanceBase> SmsCategoryInstanceBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CategoryInstanceMembership</c> collection
        /// </summary>
        public WmiClassSet<SmsCategoryInstanceMembership> SmsCategoryInstanceMembership { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Certificate</c> collection
        /// </summary>
        public WmiClassSet<SmsCertificate> SmsCertificate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CertificateData</c> collection
        /// </summary>
        public WmiClassSet<SmsCertificateData> SmsCertificateData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CertificateInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsCertificateInfo> SmsCertificateInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CFDFeature</c> collection
        /// </summary>
        public WmiClassSet<SmsCfdFeature> SmsCfdFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_CheckSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsChCheckSummary> SmsChCheckSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_ClientHealth</c> collection
        /// </summary>
        public WmiClassSet<SmsChClientHealth> SmsChClientHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_EvalResult</c> collection
        /// </summary>
        public WmiClassSet<SmsChEvalResult> SmsChEvalResult { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_Settings</c> collection
        /// </summary>
        public WmiClassSet<SmsChSettings> SmsChSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_SummaryCurrent</c> collection
        /// </summary>
        public WmiClassSet<SmsChSummaryCurrent> SmsChSummaryCurrent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CH_SummaryHistory</c> collection
        /// </summary>
        public WmiClassSet<SmsChSummaryHistory> SmsChSummaryHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CHAlert</c> collection
        /// </summary>
        public WmiClassSet<SmsChAlert> SmsChAlert { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CI_ComplianceHistory</c> collection
        /// </summary>
        public WmiClassSet<SmsCiComplianceHistory> SmsCiComplianceHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CI_ComplianceSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsCiComplianceSummary> SmsCiComplianceSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CI_CurrentComplianceStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCiCurrentComplianceStatus> SmsCiCurrentComplianceStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CI_LocalizedEulas</c> collection
        /// </summary>
        public WmiClassSet<SmsCiLocalizedEulas> SmsCiLocalizedEulas { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CI_LocalizedProperties</c> collection
        /// </summary>
        public WmiClassSet<SmsCiLocalizedProperties> SmsCiLocalizedProperties { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIAllCategories</c> collection
        /// </summary>
        public WmiClassSet<SmsCiAllCategories> SmsCiAllCategories { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIAssignmentBaseClass</c> collection
        /// </summary>
        public WmiClassSet<SmsCiAssignmentBaseClass> SmsCiAssignmentBaseClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIAssignmentToCI</c> collection
        /// </summary>
        public WmiClassSet<SmsCiAssignmentToCi> SmsCiAssignmentToCi { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIContentFiles</c> collection
        /// </summary>
        public WmiClassSet<SmsCiContentFiles> SmsCiContentFiles { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIContentPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsCiContentPackage> SmsCiContentPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIDeploymentUnknownAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsCiDeploymentUnknownAssetDetails> SmsCiDeploymentUnknownAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIDeploymentUnknownStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCiDeploymentUnknownStatus> SmsCiDeploymentUnknownStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIRelation</c> collection
        /// </summary>
        public WmiClassSet<SmsCiRelation> SmsCiRelation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIRelation_Flat</c> collection
        /// </summary>
        public WmiClassSet<SmsCiRelationFlat> SmsCiRelationFlat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIToContent</c> collection
        /// </summary>
        public WmiClassSet<SmsCiToContent> SmsCiToContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CIUpdateSources</c> collection
        /// </summary>
        public WmiClassSet<SmsCiUpdateSources> SmsCiUpdateSources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClassicDeploymentAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsClassicDeploymentAssetDetails> SmsClassicDeploymentAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClassicDeploymentStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsClassicDeploymentStatus> SmsClassicDeploymentStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Client_ComanagementState</c> collection
        /// </summary>
        public WmiClassSet<SmsClientComanagementState> SmsClientComanagementState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Client_Reg_MultiString_List</c> collection
        /// </summary>
        public WmiClassSet<SmsClientRegMultiStringList> SmsClientRegMultiStringList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientAction</c> collection
        /// </summary>
        public WmiClassSet<SmsClientAction> SmsClientAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientActionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsClientActionStatus> SmsClientActionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientActionStringValues</c> collection
        /// </summary>
        public WmiClassSet<SmsClientActionStringValues> SmsClientActionStringValues { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientAdvertisementStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsClientAdvertisementStatus> SmsClientAdvertisementStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientAdvertisementSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsClientAdvertisementSummary> SmsClientAdvertisementSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientAgentConfig_BaseClass</c> collection
        /// </summary>
        public WmiClassSet<SmsClientAgentConfigBaseClass> SmsClientAgentConfigBaseClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientAuthCertificateSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsClientAuthCertificateSettings> SmsClientAuthCertificateSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientBaseline</c> collection
        /// </summary>
        public WmiClassSet<SmsClientBaseline> SmsClientBaseline { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientBaselineItem</c> collection
        /// </summary>
        public WmiClassSet<SmsClientBaselineItem> SmsClientBaselineItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientBaselineStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsClientBaselineStatus> SmsClientBaselineStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientCommunicationConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsClientCommunicationConfig> SmsClientCommunicationConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDataSourcesContent</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDataSourcesContent> SmsClientDataSourcesContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDataSourcesContentStats</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDataSourcesContentStats> SmsClientDataSourcesContentStats { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDataSourcesDeviceCounts</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDataSourcesDeviceCounts> SmsClientDataSourcesDeviceCounts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDataSourcesPolicy</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDataSourcesPolicy> SmsClientDataSourcesPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDeploymentCollectionBucket</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDeploymentCollectionBucket> SmsClientDeploymentCollectionBucket { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDeploymentFailureBucket</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDeploymentFailureBucket> SmsClientDeploymentFailureBucket { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDeploymentStateDetailsView</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDeploymentStateDetailsView> SmsClientDeploymentStateDetailsView { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDownloadSources</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDownloadSources> SmsClientDownloadSources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientDownloadSourcesBoundaries</c> collection
        /// </summary>
        public WmiClassSet<SmsClientDownloadSourcesBoundaries> SmsClientDownloadSourcesBoundaries { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientOperation</c> collection
        /// </summary>
        public WmiClassSet<SmsClientOperation> SmsClientOperation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientOperationStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsClientOperationStatus> SmsClientOperationStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientPfxCertificate</c> collection
        /// </summary>
        public WmiClassSet<SmsClientPfxCertificate> SmsClientPfxCertificate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientResourcesConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsClientResourcesConfig> SmsClientResourcesConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientRestartAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsClientRestartAgentConfig> SmsClientRestartAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsClientSettings> SmsClientSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientSettingsAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsClientSettingsAssignment> SmsClientSettingsAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientSettingsBase</c> collection
        /// </summary>
        public WmiClassSet<SmsClientSettingsBase> SmsClientSettingsBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ClientSettingsDefault</c> collection
        /// </summary>
        public WmiClassSet<SmsClientSettingsDefault> SmsClientSettingsDefault { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudAgentConfig> SmsCloudAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudCostEstimator</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudCostEstimator> SmsCloudCostEstimator { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudProxyConnector</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudProxyConnector> SmsCloudProxyConnector { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudProxyEndpointDefinition</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudProxyEndpointDefinition> SmsCloudProxyEndpointDefinition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudProxyRoleEndpoint</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudProxyRoleEndpoint> SmsCloudProxyRoleEndpoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CloudSubscription</c> collection
        /// </summary>
        public WmiClassSet<SmsCloudSubscription> SmsCloudSubscription { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdateFeatures</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdateFeatures> SmsCmUpdateFeatures { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackageFeatures</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackageFeatures> SmsCmUpdatePackageFeatures { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackages</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackages> SmsCmUpdatePackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackagesHistory</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackagesHistory> SmsCmUpdatePackagesHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackageSiteStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackageSiteStatus> SmsCmUpdatePackageSiteStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackDetailedMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackDetailedMonitoring> SmsCmUpdatePackDetailedMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackDetailedPrereqMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackDetailedPrereqMonitoring> SmsCmUpdatePackDetailedPrereqMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackDetailedSiteStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackDetailedSiteStatus> SmsCmUpdatePackDetailedSiteStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackDownloadMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackDownloadMonitoring> SmsCmUpdatePackDownloadMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CM_UpdatePackTopLevelMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsCmUpdatePackTopLevelMonitoring> SmsCmUpdatePackTopLevelMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CMPivotFavorite</c> collection
        /// </summary>
        public WmiClassSet<SmsCmPivotFavorite> SmsCmPivotFavorite { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CMPivotStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCmPivotStatus> SmsCmPivotStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CMPivotTask</c> collection
        /// </summary>
        public WmiClassSet<SmsCmPivotTask> SmsCmPivotTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CMSiteConfiguration</c> collection
        /// </summary>
        public WmiClassSet<SmsCmSiteConfiguration> SmsCmSiteConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CMTagRef</c> collection
        /// </summary>
        public WmiClassSet<SmsCmTagRef> SmsCmTagRef { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CN_ClientStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCnClientStatus> SmsCnClientStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Collection</c> collection
        /// </summary>
        public WmiClassSet<SmsCollection> SmsCollection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionAADGroupMapping</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionAadGroupMapping> SmsCollectionAadGroupMapping { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionBucket</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionBucket> SmsCollectionBucket { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionDependencies</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionDependencies> SmsCollectionDependencies { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionMember</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionMember> SmsCollectionMember { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionMember_a</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionMemberA> SmsCollectionMemberA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionMemberClientBaselineStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionMemberClientBaselineStatus> SmsCollectionMemberClientBaselineStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionPermission</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionPermission> SmsCollectionPermission { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionRule</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionRule> SmsCollectionRule { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionRuleDirect</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionRuleDirect> SmsCollectionRuleDirect { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionRuleExcludeCollection</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionRuleExcludeCollection> SmsCollectionRuleExcludeCollection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionRuleIncludeCollection</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionRuleIncludeCollection> SmsCollectionRuleIncludeCollection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionRuleQuery</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionRuleQuery> SmsCollectionRuleQuery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionSettings> SmsCollectionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionToPkgAdvert_a</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionToPkgAdvertA> SmsCollectionToPkgAdvertA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CollectionVariable</c> collection
        /// </summary>
        public WmiClassSet<SmsCollectionVariable> SmsCollectionVariable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CoManagementSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCoManagementSettings> SmsCoManagementSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CombinedDeviceResources</c> collection
        /// </summary>
        public WmiClassSet<SmsCombinedDeviceResources> SmsCombinedDeviceResources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CombinedResources</c> collection
        /// </summary>
        public WmiClassSet<SmsCombinedResources> SmsCombinedResources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CombinedUserResources</c> collection
        /// </summary>
        public WmiClassSet<SmsCombinedUserResources> SmsCombinedUserResources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CoMgmtConfigs</c> collection
        /// </summary>
        public WmiClassSet<SmsCoMgmtConfigs> SmsCoMgmtConfigs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CommonMacAddresses</c> collection
        /// </summary>
        public WmiClassSet<SmsCommonMacAddresses> SmsCommonMacAddresses { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CommonSmbiosGuids</c> collection
        /// </summary>
        public WmiClassSet<SmsCommonSmbiosGuids> SmsCommonSmbiosGuids { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CommunicationsProvisioningSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCommunicationsProvisioningSettings> SmsCommunicationsProvisioningSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ComplianceNotificationSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsComplianceNotificationSettings> SmsComplianceNotificationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CompliancePolicySettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCompliancePolicySettings> SmsCompliancePolicySettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ComponentSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsComponentSummarizer> SmsComponentSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConditionAccessManagement</c> collection
        /// </summary>
        public WmiClassSet<SmsConditionAccessManagement> SmsConditionAccessManagement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigData</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigData> SmsConfigData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigMgrClientAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigMgrClientAgentConfig> SmsConfigMgrClientAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationBaselineInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationBaselineInfo> SmsConfigurationBaselineInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItem</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItem> SmsConfigurationItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemBaseClass</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemBaseClass> SmsConfigurationItemBaseClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemLatest</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemLatest> SmsConfigurationItemLatest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemLatestBaseClass</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemLatestBaseClass> SmsConfigurationItemLatestBaseClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemRules</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemRules> SmsConfigurationItemRules { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemSettingReference</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemSettingReference> SmsConfigurationItemSettingReference { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationItemSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationItemSettings> SmsConfigurationItemSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationPlatform</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationPlatform> SmsConfigurationPlatform { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationPolicy</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationPolicy> SmsConfigurationPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationPolicyAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationPolicyAssignment> SmsConfigurationPolicyAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConfigurationPolicyBase</c> collection
        /// </summary>
        public WmiClassSet<SmsConfigurationPolicyBase> SmsConfigurationPolicyBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConsoleAdminsData</c> collection
        /// </summary>
        public WmiClassSet<SmsConsoleAdminsData> SmsConsoleAdminsData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConsoleDashboards</c> collection
        /// </summary>
        public WmiClassSet<SmsConsoleDashboards> SmsConsoleDashboards { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConsoleSetupInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsConsoleSetupInfo> SmsConsoleSetupInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ConsoleUsageData</c> collection
        /// </summary>
        public WmiClassSet<SmsConsoleUsageData> SmsConsoleUsageData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Content</c> collection
        /// </summary>
        public WmiClassSet<SmsContent> SmsContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ContentPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsContentPackage> SmsContentPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ContextMethods</c> collection
        /// </summary>
        public WmiClassSet<SmsContextMethods> SmsContextMethods { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CurrentThreatOutbreak</c> collection
        /// </summary>
        public WmiClassSet<SmsCurrentThreatOutbreak> SmsCurrentThreatOutbreak { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CustomConfigurationSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCustomConfigurationSettings> SmsCustomConfigurationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_CustomConfigurationSettingsSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsCustomConfigurationSettingsSettings> SmsCustomConfigurationSettingsSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmAgentConfig> SmsDcmAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentCompliantAssetDetails> SmsDcmDeploymentCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentCompliantDetailsPerAsset</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentCompliantDetailsPerAsset> SmsDcmDeploymentCompliantDetailsPerAsset { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentCompliantStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentCompliantStatus> SmsDcmDeploymentCompliantStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentErrorAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentErrorAssetDetails> SmsDcmDeploymentErrorAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentErrorDetailsPerAsset</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentErrorDetailsPerAsset> SmsDcmDeploymentErrorDetailsPerAsset { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentErrorStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentErrorStatus> SmsDcmDeploymentErrorStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentNonCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentNonCompliantAssetDetails> SmsDcmDeploymentNonCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentNonCompliantDetailsPerAsset</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentNonCompliantDetailsPerAsset> SmsDcmDeploymentNonCompliantDetailsPerAsset { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DCMDeploymentNonCompliantStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDcmDeploymentNonCompliantStatus> SmsDcmDeploymentNonCompliantStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DefaultBoundaryGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsDefaultBoundaryGroup> SmsDefaultBoundaryGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeploymentInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDeploymentInfo> SmsDeploymentInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeploymentInfoFlat</c> collection
        /// </summary>
        public WmiClassSet<SmsDeploymentInfoFlat> SmsDeploymentInfoFlat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeploymentSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsDeploymentSummary> SmsDeploymentSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeploymentType</c> collection
        /// </summary>
        public WmiClassSet<SmsDeploymentType> SmsDeploymentType { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeploymentTypeLicenseAssociation</c> collection
        /// </summary>
        public WmiClassSet<SmsDeploymentTypeLicenseAssociation> SmsDeploymentTypeLicenseAssociation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceAction</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceAction> SmsDeviceAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceCollectionMember</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceCollectionMember> SmsDeviceCollectionMember { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceDiscoveryTranslation</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceDiscoveryTranslation> SmsDeviceDiscoveryTranslation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceEnrollmentProfile</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceEnrollmentProfile> SmsDeviceEnrollmentProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceFQDN</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceFqdn> SmsDeviceFqdn { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceGuardSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceGuardSettings> SmsDeviceGuardSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceMethods</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceMethods> SmsDeviceMethods { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceSettingItem</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceSettingItem> SmsDeviceSettingItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceSettingPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceSettingPackage> SmsDeviceSettingPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceSettingPackageItem</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceSettingPackageItem> SmsDeviceSettingPackageItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DevicesWithAddIns</c> collection
        /// </summary>
        public WmiClassSet<SmsDevicesWithAddIns> SmsDevicesWithAddIns { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DevicesWithThisMacroFile</c> collection
        /// </summary>
        public WmiClassSet<SmsDevicesWithThisMacroFile> SmsDevicesWithThisMacroFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DeviceThreatProtectionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsDeviceThreatProtectionSettings> SmsDeviceThreatProtectionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DirFullCollMem</c> collection
        /// </summary>
        public WmiClassSet<SmsDirFullCollMem> SmsDirFullCollMem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionDPStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionDpStatus> SmsDistributionDpStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionJob</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionJob> SmsDistributionJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionPoint</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionPoint> SmsDistributionPoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionPointDriveInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionPointDriveInfo> SmsDistributionPointDriveInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionPointGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionPointGroup> SmsDistributionPointGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionPointInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionPointInfo> SmsDistributionPointInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionPointInfoBase</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionPointInfoBase> SmsDistributionPointInfoBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DistributionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDistributionStatus> SmsDistributionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPContentInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDpContentInfo> SmsDpContentInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupCollections</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupCollections> SmsDpGroupCollections { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupContentInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupContentInfo> SmsDpGroupContentInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupDistributionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupDistributionStatus> SmsDpGroupDistributionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupDistributionStatusDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupDistributionStatusDetails> SmsDpGroupDistributionStatusDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupInfo> SmsDpGroupInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupMembers</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupMembers> SmsDpGroupMembers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPGroupPackages</c> collection
        /// </summary>
        public WmiClassSet<SmsDpGroupPackages> SmsDpGroupPackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsDpStatus> SmsDpStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPStatusDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsDpStatusDetails> SmsDpStatusDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPStatusInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsDpStatusInfo> SmsDpStatusInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPStatusPerDP</c> collection
        /// </summary>
        public WmiClassSet<SmsDpStatusPerDp> SmsDpStatusPerDp { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DPStatusSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsDpStatusSummary> SmsDpStatusSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Driver</c> collection
        /// </summary>
        public WmiClassSet<SmsDriver> SmsDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Driver_Details</c> collection
        /// </summary>
        public WmiClassSet<SmsDriverDetails> SmsDriverDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DriverContainer</c> collection
        /// </summary>
        public WmiClassSet<SmsDriverContainer> SmsDriverContainer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DriverModel</c> collection
        /// </summary>
        public WmiClassSet<SmsDriverModel> SmsDriverModel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DriverPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsDriverPackage> SmsDriverPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DriverPnPIDs</c> collection
        /// </summary>
        public WmiClassSet<SmsDriverPnPiDs> SmsDriverPnPiDs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DW_TargetSiteTables</c> collection
        /// </summary>
        public WmiClassSet<SmsDwTargetSiteTables> SmsDwTargetSiteTables { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DW_TargetSyncGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsDwTargetSyncGroup> SmsDwTargetSyncGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_DW_TargetSyncTable</c> collection
        /// </summary>
        public WmiClassSet<SmsDwTargetSyncTable> SmsDwTargetSyncTable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EdgeBrowserSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsEdgeBrowserSettings> SmsEdgeBrowserSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EditionUpgradeConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsEditionUpgradeConfig> SmsEditionUpgradeConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EditionUpgradeSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsEditionUpgradeSettings> SmsEditionUpgradeSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EmbeddedProperty</c> collection
        /// </summary>
        public WmiClassSet<SmsEmbeddedProperty> SmsEmbeddedProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EmbeddedPropertyList</c> collection
        /// </summary>
        public WmiClassSet<SmsEmbeddedPropertyList> SmsEmbeddedPropertyList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EndpointProtectionAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsEndpointProtectionAgentConfig> SmsEndpointProtectionAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EndpointProtectionDashboardBucket</c> collection
        /// </summary>
        public WmiClassSet<SmsEndpointProtectionDashboardBucket> SmsEndpointProtectionDashboardBucket { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EndpointProtectionHealthStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsEndpointProtectionHealthStatus> SmsEndpointProtectionHealthStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EndpointProtectionThreatData</c> collection
        /// </summary>
        public WmiClassSet<SmsEndpointProtectionThreatData> SmsEndpointProtectionThreatData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EPAlert</c> collection
        /// </summary>
        public WmiClassSet<SmsEpAlert> SmsEpAlert { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_EULAContent</c> collection
        /// </summary>
        public WmiClassSet<SmsEulaContent> SmsEulaContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ExcludedMachineNetBIOSName</c> collection
        /// </summary>
        public WmiClassSet<SmsExcludedMachineNetBiosName> SmsExcludedMachineNetBiosName { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ExploitGuardSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsExploitGuardSettings> SmsExploitGuardSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Extended_Properties</c> collection
        /// </summary>
        public WmiClassSet<SmsExtendedProperties> SmsExtendedProperties { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ExtendedStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsExtendedStatus> SmsExtendedStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FailedImageUpdateView</c> collection
        /// </summary>
        public WmiClassSet<SmsFailedImageUpdateView> SmsFailedImageUpdateView { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FeatureExtension</c> collection
        /// </summary>
        public WmiClassSet<SmsFeatureExtension> SmsFeatureExtension { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FileUsageSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsFileUsageSummary> SmsFileUsageSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FirewallComplianceSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsFirewallComplianceSettings> SmsFirewallComplianceSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FirewallPolicy</c> collection
        /// </summary>
        public WmiClassSet<SmsFirewallPolicy> SmsFirewallPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FirewallSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsFirewallSettings> SmsFirewallSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FQDN_Validation</c> collection
        /// </summary>
        public WmiClassSet<SmsFqdnValidation> SmsFqdnValidation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_FullCollectionMembership</c> collection
        /// </summary>
        public WmiClassSet<SmsFullCollectionMembership> SmsFullCollectionMembership { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystem> SmsGSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_1394_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystem1394Controller> SmsGSystem1394Controller { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ACTIVESYNC_CONNECTED_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemActivesyncConnectedDevice> SmsGSystemActivesyncConnectedDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ACTIVESYNC_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemActivesyncService> SmsGSystemActivesyncService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ADD_REMOVE_PROGRAMS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAddRemovePrograms> SmsGSystemAddRemovePrograms { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ADD_REMOVE_PROGRAMS_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAddRemovePrograms64> SmsGSystemAddRemovePrograms64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ADVANCED_CLIENT_PORTS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAdvancedClientPorts> SmsGSystemAdvancedClientPorts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ADVANCED_CLIENT_SSL_CONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAdvancedClientSslConfigurations> SmsGSystemAdvancedClientSslConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AdvancedThreatProtectionHealthStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAdvancedThreatProtectionHealthStatus> SmsGSystemAdvancedThreatProtectionHealthStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_SYSTEM_AmPolicyStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAmPolicyStatus> SmsGSystemAmPolicyStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AMT_AGENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAmtAgent> SmsGSystemAmtAgent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AntimalwareHealthStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAntimalwareHealthStatus> SmsGSystemAntimalwareHealthStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AntimalwareInfectionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAntimalwareInfectionStatus> SmsGSystemAntimalwareInfectionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AppClientState</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAppClientState> SmsGSystemAppClientState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_APPV_CLIENT_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAppvClientApplication> SmsGSystemAppvClientApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_APPV_CLIENT_PACKAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAppvClientPackage> SmsGSystemAppvClientPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_AUTOSTART_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemAutostartSoftware> SmsGSystemAutostartSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BASEBOARD</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBaseboard> SmsGSystemBaseboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBattery> SmsGSystemBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BITLOCKER_DETAILS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBitlockerDetails> SmsGSystemBitlockerDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BOOT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBootConfiguration> SmsGSystemBootConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BROWSER_HELPER_OBJECT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBrowserHelperObject> SmsGSystemBrowserHelperObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_BROWSER_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemBrowserUsage> SmsGSystemBrowserUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_CCM_RECENTLY_USED_APPS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemCcmRecentlyUsedApps> SmsGSystemCcmRecentlyUsedApps { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_CDROM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemCdrom> SmsGSystemCdrom { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_CH_ClientSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemChClientSummary> SmsGSystemChClientSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_CI_ComplianceState</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemCiComplianceState> SmsGSystemCiComplianceState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ClientActionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemClientActionStatus> SmsGSystemClientActionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ClientEvents</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemClientEvents> SmsGSystemClientEvents { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ClientOperationStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemClientOperationStatus> SmsGSystemClientOperationStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_CollectedFile</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemCollectedFile> SmsGSystemCollectedFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_COMPUTER_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemComputerSystem> SmsGSystemComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_COMPUTER_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemComputerSystemExt> SmsGSystemComputerSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_COMPUTER_SYSTEM_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemComputerSystemProduct> SmsGSystemComputerSystemProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ConditionalAccessCompliance</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemConditionalAccessCompliance> SmsGSystemConditionalAccessCompliance { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_Current</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemCurrent> SmsGSystemCurrent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_SYSTEM_DCMDeploymentCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDcmDeploymentCompliantAssetDetails> SmsGSystemDcmDeploymentCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_SYSTEM_DCMDeploymentErrorAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDcmDeploymentErrorAssetDetails> SmsGSystemDcmDeploymentErrorAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_SYSTEM_DCMDeploymentNonCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDcmDeploymentNonCompliantAssetDetails> SmsGSystemDcmDeploymentNonCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DCMDeploymentState</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDcmDeploymentState> SmsGSystemDcmDeploymentState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEFAULT_BROWSER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDefaultBrowser> SmsGSystemDefaultBrowser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DESKTOP</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDesktop> SmsGSystemDesktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DESKTOP_MONITOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDesktopMonitor> SmsGSystemDesktopMonitor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_BLUETOOTH</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceBluetooth> SmsGSystemDeviceBluetooth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_CAMERA</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceCamera> SmsGSystemDeviceCamera { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_CERTIFICATES</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceCertificates> SmsGSystemDeviceCertificates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceClient> SmsGSystemDeviceClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_CLIENTAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceClientagentversion> SmsGSystemDeviceClientagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_COMPUTERSYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceComputersystem> SmsGSystemDeviceComputersystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_DISPLAY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceDisplay> SmsGSystemDeviceDisplay { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_EMAIL</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceEmail> SmsGSystemDeviceEmail { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_ENCRYPTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceEncryption> SmsGSystemDeviceEncryption { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_EXCHANGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceExchange> SmsGSystemDeviceExchange { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceInfo> SmsGSystemDeviceInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_INSTALLEDAPPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceInstalledapplications> SmsGSystemDeviceInstalledapplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_IRDA</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceIrda> SmsGSystemDeviceIrda { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceMemory> SmsGSystemDeviceMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_MEMORY_ADDRESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceMemoryAddress> SmsGSystemDeviceMemoryAddress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_OSINFORMATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceOsinformation> SmsGSystemDeviceOsinformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_PASSWORD</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDevicePassword> SmsGSystemDevicePassword { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDevicePolicy> SmsGSystemDevicePolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_POWER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDevicePower> SmsGSystemDevicePower { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_WINDOWSSECURITYPOLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceWindowssecuritypolicy> SmsGSystemDeviceWindowssecuritypolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DEVICE_WLAN</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDeviceWlan> SmsGSystemDeviceWlan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDisk> SmsGSystemDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DMA_CHANNEL</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDmaChannel> SmsGSystemDmaChannel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_DRIVER_VXD</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemDriverVxd> SmsGSystemDriverVxd { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_EAS_Property</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEasProperty> SmsGSystemEasProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_EMBEDDED_DEVICE_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEmbeddedDeviceInfo> SmsGSystemEmbeddedDeviceInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ENCRYPTABLE_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEncryptableVolume> SmsGSystemEncryptableVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_EndpointProtectionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEndpointProtectionStatus> SmsGSystemEndpointProtectionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ENVIRONMENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEnvironment> SmsGSystemEnvironment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_EPDeploymentState</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEpDeploymentState> SmsGSystemEpDeploymentState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_EPPolicyApplication</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemEpPolicyApplication> SmsGSystemEpPolicyApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_ExtHistory</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemExtHistory> SmsGSystemExtHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_FIRMWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemFirmware> SmsGSystemFirmware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_FOLDER_REDIRECTION_HEALTH</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemFolderRedirectionHealth> SmsGSystemFolderRedirectionHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_History</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemHistory> SmsGSystemHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_IDE_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemIdeController> SmsGSystemIdeController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_INSTALLED_EXECUTABLE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemInstalledExecutable> SmsGSystemInstalledExecutable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_INSTALLED_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemInstalledSoftware> SmsGSystemInstalledSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_IRQ</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemIrq> SmsGSystemIrq { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_KEYBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemKeyboardDevice> SmsGSystemKeyboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_LastSoftwareScan</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemLastSoftwareScan> SmsGSystemLastSoftwareScan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_LOAD_ORDER_GROUP</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemLoadOrderGroup> SmsGSystemLoadOrderGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_LOGICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemLogicalDisk> SmsGSystemLogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MBAM_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemMbamPolicy> SmsGSystemMbamPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MDM_DEVDETAIL_EXT01</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemMdmDevdetailExt01> SmsGSystemMdmDevdetailExt01 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MDM_RemoteFind</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemMdmRemoteFind> SmsGSystemMdmRemoteFind { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MDM_SecurityStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemMdmSecurityStatus> SmsGSystemMdmSecurityStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MODEM_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemModemDevice> SmsGSystemModemDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_MOTHERBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemMotherboardDevice> SmsGSystemMotherboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_NETWORK_ADAPTER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemNetworkAdapter> SmsGSystemNetworkAdapter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_NETWORK_ADAPTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemNetworkAdapterConfiguration> SmsGSystemNetworkAdapterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_NETWORK_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemNetworkClient> SmsGSystemNetworkClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_NETWORK_LOGIN_PROFILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemNetworkLoginProfile> SmsGSystemNetworkLoginProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_NT_EVENTLOG_FILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemNtEventlogFile> SmsGSystemNtEventlogFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_ADDIN</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeAddin> SmsGSystemOfficeAddin { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_CLIENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeClientmetric> SmsGSystemOfficeClientmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_DEVICESUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeDevicesummary> SmsGSystemOfficeDevicesummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_DOCUMENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeDocumentmetric> SmsGSystemOfficeDocumentmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_DOCUMENTSOLUTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeDocumentsolution> SmsGSystemOfficeDocumentsolution { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_MACROERROR</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeMacroerror> SmsGSystemOfficeMacroerror { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_PRODUCTINFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeProductinfo> SmsGSystemOfficeProductinfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_VBARULEVIOLATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeVbaruleviolation> SmsGSystemOfficeVbaruleviolation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE_VBASUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOfficeVbasummary> SmsGSystemOfficeVbasummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OFFICE365PROPLUSCONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOffice365proplusconfigurations> SmsGSystemOffice365ProPlusConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OPERATING_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOperatingSystem> SmsGSystemOperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OPERATING_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOperatingSystemExt> SmsGSystemOperatingSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OPTIONAL_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOptionalFeature> SmsGSystemOptionalFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_OS_RECOVERY_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemOsRecoveryConfiguration> SmsGSystemOsRecoveryConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PAGE_FILE_SETTING</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPageFileSetting> SmsGSystemPageFileSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PARALLEL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemParallelPort> SmsGSystemParallelPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PARTITION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPartition> SmsGSystemPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PC_BIOS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPcBios> SmsGSystemPcBios { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PCMCIA_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPcmciaController> SmsGSystemPcmciaController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PHYSICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPhysicalDisk> SmsGSystemPhysicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PHYSICAL_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPhysicalMemory> SmsGSystemPhysicalMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PNP_DEVICE_DRIVER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPnpDeviceDriver> SmsGSystemPnpDeviceDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POINTING_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPointingDevice> SmsGSystemPointingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPort> SmsGSystemPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PORTABLE_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPortableBattery> SmsGSystemPortableBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_CAPABILITIES</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementCapabilities> SmsGSystemPowerManagementCapabilities { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementClientoptoutSettings> SmsGSystemPowerManagementClientoptoutSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementConfiguration> SmsGSystemPowerManagementConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_DAY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementDay> SmsGSystemPowerManagementDay { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_MONTH</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementMonth> SmsGSystemPowerManagementMonth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_SETTINGS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementSettings> SmsGSystemPowerManagementSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_MANAGEMENT_SUSPEND_ERROR</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerManagementSuspendError> SmsGSystemPowerManagementSuspendError { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_POWER_SUPPLY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPowerSupply> SmsGSystemPowerSupply { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PRINT_JOB</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPrintJob> SmsGSystemPrintJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PRINTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPrinterConfiguration> SmsGSystemPrinterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PRINTER_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemPrinterDevice> SmsGSystemPrinterDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PROCESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemProcess> SmsGSystemProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PROCESSOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemProcessor> SmsGSystemProcessor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PROTECTED_VOLUME_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemProtectedVolumeInfo> SmsGSystemProtectedVolumeInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_PROTOCOL</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemProtocol> SmsGSystemProtocol { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_QUICK_FIX_ENGINEERING</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemQuickFixEngineering> SmsGSystemQuickFixEngineering { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_RAX_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemRaxApplication> SmsGSystemRaxApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_REGISTRY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemRegistry> SmsGSystemRegistry { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_SYSTEM_ResourceClientSettingsAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemResourceClientSettingsAssignment> SmsGSystemResourceClientSettingsAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SCSI_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemScsiController> SmsGSystemScsiController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SERIAL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSerialPort> SmsGSystemSerialPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SERIAL_PORT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSerialPortConfiguration> SmsGSystemSerialPortConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SERVER_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemServerFeature> SmsGSystemServerFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemService> SmsGSystemService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SHARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemShare> SmsGSystemShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SMS_ADVANCED_CLIENT_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSmsAdvancedClientState> SmsGSystemSmsAdvancedClientState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SOFTWARE_LICENSING_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareLicensingProduct> SmsGSystemSoftwareLicensingProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SOFTWARE_LICENSING_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareLicensingService> SmsGSystemSoftwareLicensingService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SOFTWARE_SHORTCUT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareShortcut> SmsGSystemSoftwareShortcut { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SOFTWARE_TAG</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareTag> SmsGSystemSoftwareTag { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SoftwareFile</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareFile> SmsGSystemSoftwareFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SoftwareProduct</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareProduct> SmsGSystemSoftwareProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SoftwareUsageData</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoftwareUsageData> SmsGSystemSoftwareUsageData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SOUND_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSoundDevice> SmsGSystemSoundDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystem> SmsGSystemSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_ACCOUNT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemAccount> SmsGSystemSystemAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_CONSOLE_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemConsoleUsage> SmsGSystemSystemConsoleUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_CONSOLE_USER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemConsoleUser> SmsGSystemSystemConsoleUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_DEVICES</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemDevices> SmsGSystemSystemDevices { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_DRIVER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemDriver> SmsGSystemSystemDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEM_ENCLOSURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystemEnclosure> SmsGSystemSystemEnclosure { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEMBOOTDATA</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystembootdata> SmsGSystemSystembootdata { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_SYSTEMBOOTSUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemSystembootsummary> SmsGSystemSystembootsummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TAPE_DRIVE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTapeDrive> SmsGSystemTapeDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_Threats</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemThreats> SmsGSystemThreats { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TIME_ZONE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTimeZone> SmsGSystemTimeZone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TPM</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTpm> SmsGSystemTpm { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TPM_STATUS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTpmStatus> SmsGSystemTpmStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TS_ISSUED_LICENSE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTsIssuedLicense> SmsGSystemTsIssuedLicense { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_TS_LICENSE_KEY_PACK</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemTsLicenseKeyPack> SmsGSystemTsLicenseKeyPack { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_UAComputerStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemUaComputerStatus> SmsGSystemUaComputerStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_UnknownFile</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemUnknownFile> SmsGSystemUnknownFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_USB_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemUsbController> SmsGSystemUsbController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_USB_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemUsbDevice> SmsGSystemUsbDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_USER_PROFILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemUserProfile> SmsGSystemUserProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIDEO_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVideoController> SmsGSystemVideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIRTUAL_APPLICATION_PACKAGES</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVirtualApplicationPackages> SmsGSystemVirtualApplicationPackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIRTUAL_APPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVirtualApplications> SmsGSystemVirtualApplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIRTUAL_MACHINE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVirtualMachine> SmsGSystemVirtualMachine { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIRTUAL_MACHINE_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVirtualMachine64> SmsGSystemVirtualMachine64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VIRTUAL_MACHINE_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVirtualMachineExt> SmsGSystemVirtualMachineExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemVolume> SmsGSystemVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WEBAPP_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWebappApplication> SmsGSystemWebappApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WINDOWS8_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWindows8Application> SmsGSystemWindows8Application { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WINDOWS8_APPLICATION_USER_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWindows8ApplicationUserInfo> SmsGSystemWindows8ApplicationUserInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WINDOWSUPDATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWindowsupdate> SmsGSystemWindowsupdate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WINDOWSUPDATEAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWindowsupdateagentversion> SmsGSystemWindowsupdateagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WORKSTATION_STATUS</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWorkstationStatus> SmsGSystemWorkstationStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_WRITE_FILTER_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemWriteFilterState> SmsGSystemWriteFilterState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_System_X86_PC_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGSystemX86PcMemory> SmsGSystemX86PcMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_User</c> collection
        /// </summary>
        public WmiClassSet<SmsGUser> SmsGUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_USER_DCMDeploymentCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGUserDcmDeploymentCompliantAssetDetails> SmsGUserDcmDeploymentCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_USER_DCMDeploymentErrorAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGUserDcmDeploymentErrorAssetDetails> SmsGUserDcmDeploymentErrorAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_USER_DCMDeploymentNonCompliantAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsGUserDcmDeploymentNonCompliantAssetDetails> SmsGUserDcmDeploymentNonCompliantAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_User_DCMDeploymentState</c> collection
        /// </summary>
        public WmiClassSet<SmsGUserDcmDeploymentState> SmsGUserDcmDeploymentState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_G_UserGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsGUserGroup> SmsGUserGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_1394_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystem1394Controller> SmsGehSystem1394Controller { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ACTIVESYNC_CONNECTED_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemActivesyncConnectedDevice> SmsGehSystemActivesyncConnectedDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ACTIVESYNC_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemActivesyncService> SmsGehSystemActivesyncService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ADD_REMOVE_PROGRAMS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAddRemovePrograms> SmsGehSystemAddRemovePrograms { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ADD_REMOVE_PROGRAMS_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAddRemovePrograms64> SmsGehSystemAddRemovePrograms64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ADVANCED_CLIENT_PORTS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAdvancedClientPorts> SmsGehSystemAdvancedClientPorts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ADVANCED_CLIENT_SSL_CONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAdvancedClientSslConfigurations> SmsGehSystemAdvancedClientSslConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_AMT_AGENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAmtAgent> SmsGehSystemAmtAgent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_APPV_CLIENT_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAppvClientApplication> SmsGehSystemAppvClientApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_APPV_CLIENT_PACKAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAppvClientPackage> SmsGehSystemAppvClientPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_AUTOSTART_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemAutostartSoftware> SmsGehSystemAutostartSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BASEBOARD</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBaseboard> SmsGehSystemBaseboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBattery> SmsGehSystemBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BITLOCKER_DETAILS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBitlockerDetails> SmsGehSystemBitlockerDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BOOT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBootConfiguration> SmsGehSystemBootConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BROWSER_HELPER_OBJECT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBrowserHelperObject> SmsGehSystemBrowserHelperObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_BROWSER_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemBrowserUsage> SmsGehSystemBrowserUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_CDROM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemCdrom> SmsGehSystemCdrom { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ClientEvents</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemClientEvents> SmsGehSystemClientEvents { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_COMPUTER_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemComputerSystem> SmsGehSystemComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_COMPUTER_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemComputerSystemExt> SmsGehSystemComputerSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_COMPUTER_SYSTEM_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemComputerSystemProduct> SmsGehSystemComputerSystemProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEFAULT_BROWSER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDefaultBrowser> SmsGehSystemDefaultBrowser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DESKTOP</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDesktop> SmsGehSystemDesktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DESKTOP_MONITOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDesktopMonitor> SmsGehSystemDesktopMonitor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_BLUETOOTH</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceBluetooth> SmsGehSystemDeviceBluetooth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_CAMERA</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceCamera> SmsGehSystemDeviceCamera { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_CERTIFICATES</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceCertificates> SmsGehSystemDeviceCertificates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceClient> SmsGehSystemDeviceClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_CLIENTAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceClientagentversion> SmsGehSystemDeviceClientagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_COMPUTERSYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceComputersystem> SmsGehSystemDeviceComputersystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_DISPLAY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceDisplay> SmsGehSystemDeviceDisplay { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_EMAIL</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceEmail> SmsGehSystemDeviceEmail { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_ENCRYPTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceEncryption> SmsGehSystemDeviceEncryption { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_EXCHANGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceExchange> SmsGehSystemDeviceExchange { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_INSTALLEDAPPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceInstalledapplications> SmsGehSystemDeviceInstalledapplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_IRDA</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceIrda> SmsGehSystemDeviceIrda { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceMemory> SmsGehSystemDeviceMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_MEMORY_ADDRESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceMemoryAddress> SmsGehSystemDeviceMemoryAddress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_OSINFORMATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceOsinformation> SmsGehSystemDeviceOsinformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_PASSWORD</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDevicePassword> SmsGehSystemDevicePassword { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDevicePolicy> SmsGehSystemDevicePolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_POWER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDevicePower> SmsGehSystemDevicePower { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_WINDOWSSECURITYPOLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceWindowssecuritypolicy> SmsGehSystemDeviceWindowssecuritypolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DEVICE_WLAN</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDeviceWlan> SmsGehSystemDeviceWlan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDisk> SmsGehSystemDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DMA_CHANNEL</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDmaChannel> SmsGehSystemDmaChannel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_DRIVER_VXD</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemDriverVxd> SmsGehSystemDriverVxd { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_EMBEDDED_DEVICE_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemEmbeddedDeviceInfo> SmsGehSystemEmbeddedDeviceInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ENCRYPTABLE_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemEncryptableVolume> SmsGehSystemEncryptableVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_ENVIRONMENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemEnvironment> SmsGehSystemEnvironment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_FIRMWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemFirmware> SmsGehSystemFirmware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_IDE_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemIdeController> SmsGehSystemIdeController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_INSTALLED_EXECUTABLE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemInstalledExecutable> SmsGehSystemInstalledExecutable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_INSTALLED_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemInstalledSoftware> SmsGehSystemInstalledSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_IRQ</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemIrq> SmsGehSystemIrq { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_KEYBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemKeyboardDevice> SmsGehSystemKeyboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_LOAD_ORDER_GROUP</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemLoadOrderGroup> SmsGehSystemLoadOrderGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_LOGICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemLogicalDisk> SmsGehSystemLogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MBAM_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemMbamPolicy> SmsGehSystemMbamPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MDM_DEVDETAIL_EXT01</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemMdmDevdetailExt01> SmsGehSystemMdmDevdetailExt01 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MDM_RemoteFind</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemMdmRemoteFind> SmsGehSystemMdmRemoteFind { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MDM_SecurityStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemMdmSecurityStatus> SmsGehSystemMdmSecurityStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MODEM_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemModemDevice> SmsGehSystemModemDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_MOTHERBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemMotherboardDevice> SmsGehSystemMotherboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_NETWORK_ADAPTER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemNetworkAdapter> SmsGehSystemNetworkAdapter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_NETWORK_ADAPTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemNetworkAdapterConfiguration> SmsGehSystemNetworkAdapterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_NETWORK_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemNetworkClient> SmsGehSystemNetworkClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_NETWORK_LOGIN_PROFILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemNetworkLoginProfile> SmsGehSystemNetworkLoginProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_NT_EVENTLOG_FILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemNtEventlogFile> SmsGehSystemNtEventlogFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_ADDIN</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeAddin> SmsGehSystemOfficeAddin { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_CLIENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeClientmetric> SmsGehSystemOfficeClientmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_DEVICESUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeDevicesummary> SmsGehSystemOfficeDevicesummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_DOCUMENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeDocumentmetric> SmsGehSystemOfficeDocumentmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_DOCUMENTSOLUTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeDocumentsolution> SmsGehSystemOfficeDocumentsolution { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_MACROERROR</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeMacroerror> SmsGehSystemOfficeMacroerror { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_PRODUCTINFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeProductinfo> SmsGehSystemOfficeProductinfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_VBARULEVIOLATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeVbaruleviolation> SmsGehSystemOfficeVbaruleviolation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE_VBASUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOfficeVbasummary> SmsGehSystemOfficeVbasummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OFFICE365PROPLUSCONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOffice365proplusconfigurations> SmsGehSystemOffice365ProPlusConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OPERATING_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOperatingSystem> SmsGehSystemOperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OPERATING_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOperatingSystemExt> SmsGehSystemOperatingSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OPTIONAL_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOptionalFeature> SmsGehSystemOptionalFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_OS_RECOVERY_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemOsRecoveryConfiguration> SmsGehSystemOsRecoveryConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PAGE_FILE_SETTING</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPageFileSetting> SmsGehSystemPageFileSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PARALLEL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemParallelPort> SmsGehSystemParallelPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PARTITION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPartition> SmsGehSystemPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PC_BIOS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPcBios> SmsGehSystemPcBios { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PCMCIA_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPcmciaController> SmsGehSystemPcmciaController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PHYSICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPhysicalDisk> SmsGehSystemPhysicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PHYSICAL_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPhysicalMemory> SmsGehSystemPhysicalMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_POINTING_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPointingDevice> SmsGehSystemPointingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPort> SmsGehSystemPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PORTABLE_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPortableBattery> SmsGehSystemPortableBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_POWER_SUPPLY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPowerSupply> SmsGehSystemPowerSupply { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PRINT_JOB</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPrintJob> SmsGehSystemPrintJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PRINTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPrinterConfiguration> SmsGehSystemPrinterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PRINTER_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemPrinterDevice> SmsGehSystemPrinterDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PROCESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemProcess> SmsGehSystemProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PROCESSOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemProcessor> SmsGehSystemProcessor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PROTECTED_VOLUME_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemProtectedVolumeInfo> SmsGehSystemProtectedVolumeInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_PROTOCOL</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemProtocol> SmsGehSystemProtocol { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_QUICK_FIX_ENGINEERING</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemQuickFixEngineering> SmsGehSystemQuickFixEngineering { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_RAX_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemRaxApplication> SmsGehSystemRaxApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_REGISTRY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemRegistry> SmsGehSystemRegistry { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SCSI_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemScsiController> SmsGehSystemScsiController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SERIAL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSerialPort> SmsGehSystemSerialPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SERIAL_PORT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSerialPortConfiguration> SmsGehSystemSerialPortConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SERVER_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemServerFeature> SmsGehSystemServerFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemService> SmsGehSystemService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SHARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemShare> SmsGehSystemShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SMS_ADVANCED_CLIENT_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSmsAdvancedClientState> SmsGehSystemSmsAdvancedClientState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SOFTWARE_LICENSING_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSoftwareLicensingProduct> SmsGehSystemSoftwareLicensingProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SOFTWARE_LICENSING_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSoftwareLicensingService> SmsGehSystemSoftwareLicensingService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SOFTWARE_SHORTCUT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSoftwareShortcut> SmsGehSystemSoftwareShortcut { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SOFTWARE_TAG</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSoftwareTag> SmsGehSystemSoftwareTag { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SOUND_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSoundDevice> SmsGehSystemSoundDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystem> SmsGehSystemSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM_ACCOUNT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystemAccount> SmsGehSystemSystemAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM_CONSOLE_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystemConsoleUsage> SmsGehSystemSystemConsoleUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM_CONSOLE_USER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystemConsoleUser> SmsGehSystemSystemConsoleUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM_DRIVER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystemDriver> SmsGehSystemSystemDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEM_ENCLOSURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystemEnclosure> SmsGehSystemSystemEnclosure { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEMBOOTDATA</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystembootdata> SmsGehSystemSystembootdata { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_SYSTEMBOOTSUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemSystembootsummary> SmsGehSystemSystembootsummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TAPE_DRIVE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTapeDrive> SmsGehSystemTapeDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TIME_ZONE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTimeZone> SmsGehSystemTimeZone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TPM</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTpm> SmsGehSystemTpm { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TPM_STATUS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTpmStatus> SmsGehSystemTpmStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TS_ISSUED_LICENSE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTsIssuedLicense> SmsGehSystemTsIssuedLicense { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_TS_LICENSE_KEY_PACK</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemTsLicenseKeyPack> SmsGehSystemTsLicenseKeyPack { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_USB_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemUsbController> SmsGehSystemUsbController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_USB_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemUsbDevice> SmsGehSystemUsbDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIDEO_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVideoController> SmsGehSystemVideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIRTUAL_APPLICATION_PACKAGES</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVirtualApplicationPackages> SmsGehSystemVirtualApplicationPackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIRTUAL_APPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVirtualApplications> SmsGehSystemVirtualApplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIRTUAL_MACHINE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVirtualMachine> SmsGehSystemVirtualMachine { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIRTUAL_MACHINE_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVirtualMachine64> SmsGehSystemVirtualMachine64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VIRTUAL_MACHINE_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVirtualMachineExt> SmsGehSystemVirtualMachineExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemVolume> SmsGehSystemVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WEBAPP_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWebappApplication> SmsGehSystemWebappApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WINDOWS8_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWindows8Application> SmsGehSystemWindows8Application { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WINDOWS8_APPLICATION_USER_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWindows8ApplicationUserInfo> SmsGehSystemWindows8ApplicationUserInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WINDOWSUPDATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWindowsupdate> SmsGehSystemWindowsupdate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WINDOWSUPDATEAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWindowsupdateagentversion> SmsGehSystemWindowsupdateagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_WRITE_FILTER_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemWriteFilterState> SmsGehSystemWriteFilterState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GEH_System_X86_PC_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGehSystemX86PcMemory> SmsGehSystemX86PcMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_1394_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystem1394Controller> SmsGhSystem1394Controller { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ACTIVESYNC_CONNECTED_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemActivesyncConnectedDevice> SmsGhSystemActivesyncConnectedDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ACTIVESYNC_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemActivesyncService> SmsGhSystemActivesyncService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ADD_REMOVE_PROGRAMS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAddRemovePrograms> SmsGhSystemAddRemovePrograms { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ADD_REMOVE_PROGRAMS_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAddRemovePrograms64> SmsGhSystemAddRemovePrograms64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ADVANCED_CLIENT_PORTS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAdvancedClientPorts> SmsGhSystemAdvancedClientPorts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ADVANCED_CLIENT_SSL_CONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAdvancedClientSslConfigurations> SmsGhSystemAdvancedClientSslConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_AMT_AGENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAmtAgent> SmsGhSystemAmtAgent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_APPV_CLIENT_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAppvClientApplication> SmsGhSystemAppvClientApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_APPV_CLIENT_PACKAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAppvClientPackage> SmsGhSystemAppvClientPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_AUTOSTART_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemAutostartSoftware> SmsGhSystemAutostartSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BASEBOARD</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBaseboard> SmsGhSystemBaseboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBattery> SmsGhSystemBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BITLOCKER_DETAILS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBitlockerDetails> SmsGhSystemBitlockerDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BOOT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBootConfiguration> SmsGhSystemBootConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BROWSER_HELPER_OBJECT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBrowserHelperObject> SmsGhSystemBrowserHelperObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_BROWSER_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemBrowserUsage> SmsGhSystemBrowserUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_CDROM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemCdrom> SmsGhSystemCdrom { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ClientEvents</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemClientEvents> SmsGhSystemClientEvents { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_COMPUTER_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemComputerSystem> SmsGhSystemComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_COMPUTER_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemComputerSystemExt> SmsGhSystemComputerSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_COMPUTER_SYSTEM_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemComputerSystemProduct> SmsGhSystemComputerSystemProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEFAULT_BROWSER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDefaultBrowser> SmsGhSystemDefaultBrowser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DESKTOP</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDesktop> SmsGhSystemDesktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DESKTOP_MONITOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDesktopMonitor> SmsGhSystemDesktopMonitor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_BLUETOOTH</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceBluetooth> SmsGhSystemDeviceBluetooth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_CAMERA</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceCamera> SmsGhSystemDeviceCamera { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_CERTIFICATES</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceCertificates> SmsGhSystemDeviceCertificates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceClient> SmsGhSystemDeviceClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_CLIENTAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceClientagentversion> SmsGhSystemDeviceClientagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_COMPUTERSYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceComputersystem> SmsGhSystemDeviceComputersystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_DISPLAY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceDisplay> SmsGhSystemDeviceDisplay { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_EMAIL</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceEmail> SmsGhSystemDeviceEmail { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_ENCRYPTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceEncryption> SmsGhSystemDeviceEncryption { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_EXCHANGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceExchange> SmsGhSystemDeviceExchange { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_INSTALLEDAPPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceInstalledapplications> SmsGhSystemDeviceInstalledapplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_IRDA</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceIrda> SmsGhSystemDeviceIrda { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceMemory> SmsGhSystemDeviceMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_MEMORY_ADDRESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceMemoryAddress> SmsGhSystemDeviceMemoryAddress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_OSINFORMATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceOsinformation> SmsGhSystemDeviceOsinformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_PASSWORD</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDevicePassword> SmsGhSystemDevicePassword { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDevicePolicy> SmsGhSystemDevicePolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_POWER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDevicePower> SmsGhSystemDevicePower { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_WINDOWSSECURITYPOLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceWindowssecuritypolicy> SmsGhSystemDeviceWindowssecuritypolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DEVICE_WLAN</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDeviceWlan> SmsGhSystemDeviceWlan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDisk> SmsGhSystemDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DMA_CHANNEL</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDmaChannel> SmsGhSystemDmaChannel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_DRIVER_VXD</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemDriverVxd> SmsGhSystemDriverVxd { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_EMBEDDED_DEVICE_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemEmbeddedDeviceInfo> SmsGhSystemEmbeddedDeviceInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ENCRYPTABLE_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemEncryptableVolume> SmsGhSystemEncryptableVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_ENVIRONMENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemEnvironment> SmsGhSystemEnvironment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_FIRMWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemFirmware> SmsGhSystemFirmware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_IDE_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemIdeController> SmsGhSystemIdeController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_INSTALLED_EXECUTABLE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemInstalledExecutable> SmsGhSystemInstalledExecutable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_INSTALLED_SOFTWARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemInstalledSoftware> SmsGhSystemInstalledSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_IRQ</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemIrq> SmsGhSystemIrq { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_KEYBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemKeyboardDevice> SmsGhSystemKeyboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_LOAD_ORDER_GROUP</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemLoadOrderGroup> SmsGhSystemLoadOrderGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_LOGICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemLogicalDisk> SmsGhSystemLogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MBAM_POLICY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemMbamPolicy> SmsGhSystemMbamPolicy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MDM_DEVDETAIL_EXT01</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemMdmDevdetailExt01> SmsGhSystemMdmDevdetailExt01 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MDM_RemoteFind</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemMdmRemoteFind> SmsGhSystemMdmRemoteFind { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MDM_SecurityStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemMdmSecurityStatus> SmsGhSystemMdmSecurityStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MODEM_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemModemDevice> SmsGhSystemModemDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_MOTHERBOARD_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemMotherboardDevice> SmsGhSystemMotherboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_NETWORK_ADAPTER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemNetworkAdapter> SmsGhSystemNetworkAdapter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_NETWORK_ADAPTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemNetworkAdapterConfiguration> SmsGhSystemNetworkAdapterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_NETWORK_CLIENT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemNetworkClient> SmsGhSystemNetworkClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_NETWORK_LOGIN_PROFILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemNetworkLoginProfile> SmsGhSystemNetworkLoginProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_NT_EVENTLOG_FILE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemNtEventlogFile> SmsGhSystemNtEventlogFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_ADDIN</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeAddin> SmsGhSystemOfficeAddin { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_CLIENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeClientmetric> SmsGhSystemOfficeClientmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_DEVICESUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeDevicesummary> SmsGhSystemOfficeDevicesummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_DOCUMENTMETRIC</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeDocumentmetric> SmsGhSystemOfficeDocumentmetric { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_DOCUMENTSOLUTION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeDocumentsolution> SmsGhSystemOfficeDocumentsolution { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_MACROERROR</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeMacroerror> SmsGhSystemOfficeMacroerror { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_PRODUCTINFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeProductinfo> SmsGhSystemOfficeProductinfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_VBARULEVIOLATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeVbaruleviolation> SmsGhSystemOfficeVbaruleviolation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE_VBASUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOfficeVbasummary> SmsGhSystemOfficeVbasummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OFFICE365PROPLUSCONFIGURATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOffice365proplusconfigurations> SmsGhSystemOffice365ProPlusConfigurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OPERATING_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOperatingSystem> SmsGhSystemOperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OPERATING_SYSTEM_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOperatingSystemExt> SmsGhSystemOperatingSystemExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OPTIONAL_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOptionalFeature> SmsGhSystemOptionalFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_OS_RECOVERY_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemOsRecoveryConfiguration> SmsGhSystemOsRecoveryConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PAGE_FILE_SETTING</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPageFileSetting> SmsGhSystemPageFileSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PARALLEL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemParallelPort> SmsGhSystemParallelPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PARTITION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPartition> SmsGhSystemPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PC_BIOS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPcBios> SmsGhSystemPcBios { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PCMCIA_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPcmciaController> SmsGhSystemPcmciaController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PHYSICAL_DISK</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPhysicalDisk> SmsGhSystemPhysicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PHYSICAL_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPhysicalMemory> SmsGhSystemPhysicalMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_POINTING_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPointingDevice> SmsGhSystemPointingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPort> SmsGhSystemPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PORTABLE_BATTERY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPortableBattery> SmsGhSystemPortableBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_POWER_SUPPLY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPowerSupply> SmsGhSystemPowerSupply { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PRINT_JOB</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPrintJob> SmsGhSystemPrintJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PRINTER_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPrinterConfiguration> SmsGhSystemPrinterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PRINTER_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemPrinterDevice> SmsGhSystemPrinterDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PROCESS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemProcess> SmsGhSystemProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PROCESSOR</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemProcessor> SmsGhSystemProcessor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PROTECTED_VOLUME_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemProtectedVolumeInfo> SmsGhSystemProtectedVolumeInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_PROTOCOL</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemProtocol> SmsGhSystemProtocol { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_QUICK_FIX_ENGINEERING</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemQuickFixEngineering> SmsGhSystemQuickFixEngineering { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_RAX_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemRaxApplication> SmsGhSystemRaxApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_REGISTRY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemRegistry> SmsGhSystemRegistry { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SCSI_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemScsiController> SmsGhSystemScsiController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SERIAL_PORT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSerialPort> SmsGhSystemSerialPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SERIAL_PORT_CONFIGURATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSerialPortConfiguration> SmsGhSystemSerialPortConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SERVER_FEATURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemServerFeature> SmsGhSystemServerFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemService> SmsGhSystemService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SHARE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemShare> SmsGhSystemShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SMS_ADVANCED_CLIENT_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSmsAdvancedClientState> SmsGhSystemSmsAdvancedClientState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SOFTWARE_LICENSING_PRODUCT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSoftwareLicensingProduct> SmsGhSystemSoftwareLicensingProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SOFTWARE_LICENSING_SERVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSoftwareLicensingService> SmsGhSystemSoftwareLicensingService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SOFTWARE_SHORTCUT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSoftwareShortcut> SmsGhSystemSoftwareShortcut { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SOFTWARE_TAG</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSoftwareTag> SmsGhSystemSoftwareTag { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SOUND_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSoundDevice> SmsGhSystemSoundDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystem> SmsGhSystemSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM_ACCOUNT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystemAccount> SmsGhSystemSystemAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM_CONSOLE_USAGE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystemConsoleUsage> SmsGhSystemSystemConsoleUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM_CONSOLE_USER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystemConsoleUser> SmsGhSystemSystemConsoleUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM_DRIVER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystemDriver> SmsGhSystemSystemDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEM_ENCLOSURE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystemEnclosure> SmsGhSystemSystemEnclosure { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEMBOOTDATA</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystembootdata> SmsGhSystemSystembootdata { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_SYSTEMBOOTSUMMARY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemSystembootsummary> SmsGhSystemSystembootsummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TAPE_DRIVE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTapeDrive> SmsGhSystemTapeDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TIME_ZONE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTimeZone> SmsGhSystemTimeZone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TPM</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTpm> SmsGhSystemTpm { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TPM_STATUS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTpmStatus> SmsGhSystemTpmStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TS_ISSUED_LICENSE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTsIssuedLicense> SmsGhSystemTsIssuedLicense { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_TS_LICENSE_KEY_PACK</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemTsLicenseKeyPack> SmsGhSystemTsLicenseKeyPack { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_USB_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemUsbController> SmsGhSystemUsbController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_USB_DEVICE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemUsbDevice> SmsGhSystemUsbDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIDEO_CONTROLLER</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVideoController> SmsGhSystemVideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIRTUAL_APPLICATION_PACKAGES</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVirtualApplicationPackages> SmsGhSystemVirtualApplicationPackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIRTUAL_APPLICATIONS</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVirtualApplications> SmsGhSystemVirtualApplications { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIRTUAL_MACHINE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVirtualMachine> SmsGhSystemVirtualMachine { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIRTUAL_MACHINE_64</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVirtualMachine64> SmsGhSystemVirtualMachine64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VIRTUAL_MACHINE_EXT</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVirtualMachineExt> SmsGhSystemVirtualMachineExt { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_VOLUME</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemVolume> SmsGhSystemVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WEBAPP_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWebappApplication> SmsGhSystemWebappApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WINDOWS8_APPLICATION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWindows8Application> SmsGhSystemWindows8Application { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WINDOWS8_APPLICATION_USER_INFO</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWindows8ApplicationUserInfo> SmsGhSystemWindows8ApplicationUserInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WINDOWSUPDATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWindowsupdate> SmsGhSystemWindowsupdate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WINDOWSUPDATEAGENTVERSION</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWindowsupdateagentversion> SmsGhSystemWindowsupdateagentversion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_WRITE_FILTER_STATE</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemWriteFilterState> SmsGhSystemWriteFilterState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GH_System_X86_PC_MEMORY</c> collection
        /// </summary>
        public WmiClassSet<SmsGhSystemX86PcMemory> SmsGhSystemX86PcMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_GlobalCondition</c> collection
        /// </summary>
        public WmiClassSet<SmsGlobalCondition> SmsGlobalCondition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Group</c> collection
        /// </summary>
        public WmiClassSet<SmsGroup> SmsGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_HA_SiteServerDetailedMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsHaSiteServerDetailedMonitoring> SmsHaSiteServerDetailedMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_HA_SiteServerDetailedPrereqMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsHaSiteServerDetailedPrereqMonitoring> SmsHaSiteServerDetailedPrereqMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_HA_SiteServerTopLevelMonitoring</c> collection
        /// </summary>
        public WmiClassSet<SmsHaSiteServerTopLevelMonitoring> SmsHaSiteServerTopLevelMonitoring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_HardwareInventoryAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsHardwareInventoryAgentConfig> SmsHardwareInventoryAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_HealthAttestationDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsHealthAttestationDetails> SmsHealthAttestationDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Identification</c> collection
        /// </summary>
        public WmiClassSet<SmsIdentification> SmsIdentification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageDeploymentAgent</c> collection
        /// </summary>
        public WmiClassSet<SmsImageDeploymentAgent> SmsImageDeploymentAgent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageDiskInformation</c> collection
        /// </summary>
        public WmiClassSet<SmsImageDiskInformation> SmsImageDiskInformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageInformation</c> collection
        /// </summary>
        public WmiClassSet<SmsImageInformation> SmsImageInformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImagePackage</c> collection
        /// </summary>
        public WmiClassSet<SmsImagePackage> SmsImagePackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageServicingProgress</c> collection
        /// </summary>
        public WmiClassSet<SmsImageServicingProgress> SmsImageServicingProgress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageServicingScanRequest</c> collection
        /// </summary>
        public WmiClassSet<SmsImageServicingScanRequest> SmsImageServicingScanRequest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageServicingSchedule</c> collection
        /// </summary>
        public WmiClassSet<SmsImageServicingSchedule> SmsImageServicingSchedule { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageServicingScheduledImage</c> collection
        /// </summary>
        public WmiClassSet<SmsImageServicingScheduledImage> SmsImageServicingScheduledImage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageServicingScheduledUpdate</c> collection
        /// </summary>
        public WmiClassSet<SmsImageServicingScheduledUpdate> SmsImageServicingScheduledUpdate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageUpdateHistory</c> collection
        /// </summary>
        public WmiClassSet<SmsImageUpdateHistory> SmsImageUpdateHistory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageUpdateStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsImageUpdateStatus> SmsImageUpdateStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImageUpdateStatusView</c> collection
        /// </summary>
        public WmiClassSet<SmsImageUpdateStatusView> SmsImageUpdateStatusView { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ImportedObject</c> collection
        /// </summary>
        public WmiClassSet<SmsImportedObject> SmsImportedObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_InitModifiableSecuredCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsInitModifiableSecuredCategory> SmsInitModifiableSecuredCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_InitSettableSecuredCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsInitSettableSecuredCategory> SmsInitSettableSecuredCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_InstanceChangeNotification</c> collection
        /// </summary>
        public WmiClassSet<SmsInstanceChangeNotification> SmsInstanceChangeNotification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_IntuneAccountInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsIntuneAccountInfo> SmsIntuneAccountInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_InventoryReport</c> collection
        /// </summary>
        public WmiClassSet<SmsInventoryReport> SmsInventoryReport { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_InventoryReportClass</c> collection
        /// </summary>
        public WmiClassSet<SmsInventoryReportClass> SmsInventoryReportClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ISVCatalogCategories</c> collection
        /// </summary>
        public WmiClassSet<SmsIsvCatalogCategories> SmsIsvCatalogCategories { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ISVCatalogs</c> collection
        /// </summary>
        public WmiClassSet<SmsIsvCatalogs> SmsIsvCatalogs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ISVProxyCertificateInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsIsvProxyCertificateInfo> SmsIsvProxyCertificateInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LastCategoryObject</c> collection
        /// </summary>
        public WmiClassSet<SmsLastCategoryObject> SmsLastCategoryObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LastPXEAdvertisement</c> collection
        /// </summary>
        public WmiClassSet<SmsLastPxeAdvertisement> SmsLastPxeAdvertisement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LegacyImagePackage</c> collection
        /// </summary>
        public WmiClassSet<SmsLegacyImagePackage> SmsLegacyImagePackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LicensedVppApps</c> collection
        /// </summary>
        public WmiClassSet<SmsLicensedVppApps> SmsLicensedVppApps { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LifecycleDetectedGroups</c> collection
        /// </summary>
        public WmiClassSet<SmsLifecycleDetectedGroups> SmsLifecycleDetectedGroups { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_LocalizedNameLookup</c> collection
        /// </summary>
        public WmiClassSet<SmsLocalizedNameLookup> SmsLocalizedNameLookup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365ACollection</c> collection
        /// </summary>
        public WmiClassSet<SmsM365aCollection> SmsM365ACollection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365ADeploymentPlan</c> collection
        /// </summary>
        public WmiClassSet<SmsM365aDeploymentPlan> SmsM365ADeploymentPlan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365ADeploymentPlanDevice</c> collection
        /// </summary>
        public WmiClassSet<SmsM365aDeploymentPlanDevice> SmsM365ADeploymentPlanDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365AProperty</c> collection
        /// </summary>
        public WmiClassSet<SmsM365aProperty> SmsM365AProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365ASettings</c> collection
        /// </summary>
        public WmiClassSet<SmsM365aSettings> SmsM365ASettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365ConnectionHealth</c> collection
        /// </summary>
        public WmiClassSet<SmsM365ConnectionHealth> SmsM365ConnectionHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_M365DeploymentPlanDashboard</c> collection
        /// </summary>
        public WmiClassSet<SmsM365DeploymentPlanDashboard> SmsM365DeploymentPlanDashboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MachineOrchestrationGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsMachineOrchestrationGroup> SmsMachineOrchestrationGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MachineOrchestrationGroupMembers</c> collection
        /// </summary>
        public WmiClassSet<SmsMachineOrchestrationGroupMembers> SmsMachineOrchestrationGroupMembers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MachineSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsMachineSettings> SmsMachineSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MachineVariable</c> collection
        /// </summary>
        public WmiClassSet<SmsMachineVariable> SmsMachineVariable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MAMPolicyTemplate</c> collection
        /// </summary>
        public WmiClassSet<SmsMamPolicyTemplate> SmsMamPolicyTemplate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MAMStoreApplication</c> collection
        /// </summary>
        public WmiClassSet<SmsMamStoreApplication> SmsMamStoreApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ManagementInsightResultsList</c> collection
        /// </summary>
        public WmiClassSet<SmsManagementInsightResultsList> SmsManagementInsightResultsList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ManagementInsightRuleGroups</c> collection
        /// </summary>
        public WmiClassSet<SmsManagementInsightRuleGroups> SmsManagementInsightRuleGroups { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ManagementInsightRules_Relation</c> collection
        /// </summary>
        public WmiClassSet<SmsManagementInsightRulesRelation> SmsManagementInsightRulesRelation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ManagementInsights</c> collection
        /// </summary>
        public WmiClassSet<SmsManagementInsights> SmsManagementInsights { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMAppleVppLicense</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmAppleVppLicense> SmsMdmAppleVppLicense { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMAppleVppToken</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmAppleVppToken> SmsMdmAppleVppToken { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMBulkEnrollmentPackages</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmBulkEnrollmentPackages> SmsMdmBulkEnrollmentPackages { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMBulkEnrollmentProfiles</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmBulkEnrollmentProfiles> SmsMdmBulkEnrollmentProfiles { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMCorpEnrollmentProfiles</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmCorpEnrollmentProfiles> SmsMdmCorpEnrollmentProfiles { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMCorpOwnedDevices</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmCorpOwnedDevices> SmsMdmCorpOwnedDevices { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMDeviceCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmDeviceCategory> SmsMdmDeviceCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMDeviceEnrollmentManagers</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmDeviceEnrollmentManagers> SmsMdmDeviceEnrollmentManagers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MDMDeviceThreat</c> collection
        /// </summary>
        public WmiClassSet<SmsMdmDeviceThreat> SmsMdmDeviceThreat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MeterData</c> collection
        /// </summary>
        public WmiClassSet<SmsMeterData> SmsMeterData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MeteredFiles</c> collection
        /// </summary>
        public WmiClassSet<SmsMeteredFiles> SmsMeteredFiles { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MeteredProductRule</c> collection
        /// </summary>
        public WmiClassSet<SmsMeteredProductRule> SmsMeteredProductRule { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MeteredUser</c> collection
        /// </summary>
        public WmiClassSet<SmsMeteredUser> SmsMeteredUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationCollectionInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationCollectionInfo> SmsMigrationCollectionInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationDashboard</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationDashboard> SmsMigrationDashboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationDP</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationDp> SmsMigrationDp { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationEntity</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationEntity> SmsMigrationEntity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationEntityDependency</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationEntityDependency> SmsMigrationEntityDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationExpandingScope</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationExpandingScope> SmsMigrationExpandingScope { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationJob</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationJob> SmsMigrationJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationJobEntityRelation</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationJobEntityRelation> SmsMigrationJobEntityRelation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationSiteMapping</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationSiteMapping> SmsMigrationSiteMapping { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MigrationSourceSite</c> collection
        /// </summary>
        public WmiClassSet<SmsMigrationSourceSite> SmsMigrationSourceSite { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MobileDeviceAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsMobileDeviceAgentConfig> SmsMobileDeviceAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_MonthlyUsageSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsMonthlyUsageSummary> SmsMonthlyUsageSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_NAL_Methods</c> collection
        /// </summary>
        public WmiClassSet<SmsNalMethods> SmsNalMethods { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_NetworkAccessAccountConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsNetworkAccessAccountConfig> SmsNetworkAccessAccountConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_O365ADRs</c> collection
        /// </summary>
        public WmiClassSet<SmsO365adRs> SmsO365AdRs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_O365Configurations</c> collection
        /// </summary>
        public WmiClassSet<SmsO365Configurations> SmsO365Configurations { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectContainerItem</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectContainerItem> SmsObjectContainerItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectContainerNode</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectContainerNode> SmsObjectContainerNode { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectContentExtraInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectContentExtraInfo> SmsObjectContentExtraInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectContentInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectContentInfo> SmsObjectContentInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectLock</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectLock> SmsObjectLock { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectLockRequest</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectLockRequest> SmsObjectLockRequest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectName</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectName> SmsObjectName { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ObjectOperationDependences</c> collection
        /// </summary>
        public WmiClassSet<SmsObjectOperationDependences> SmsObjectOperationDependences { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficeAddinReadiness</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficeAddinReadiness> SmsOfficeAddinReadiness { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficeMacroAdvisory</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficeMacroAdvisory> SmsOfficeMacroAdvisory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficeMacroHealthSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficeMacroHealthSummary> SmsOfficeMacroHealthSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficePilot</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficePilot> SmsOfficePilot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficePilotAddInsHealth</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficePilotAddInsHealth> SmsOfficePilotAddInsHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficePilotDevicesHealth</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficePilotDevicesHealth> SmsOfficePilotDevicesHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficePilotDevicesReadyToDeploy</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficePilotDevicesReadyToDeploy> SmsOfficePilotDevicesReadyToDeploy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficePilotMacrosHealth</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficePilotMacrosHealth> SmsOfficePilotMacrosHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficeProplusReadiness</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficeProplusReadiness> SmsOfficeProplusReadiness { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OfficeVersionsOfAddIns</c> collection
        /// </summary>
        public WmiClassSet<SmsOfficeVersionsOfAddIns> SmsOfficeVersionsOfAddIns { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OMSCollection</c> collection
        /// </summary>
        public WmiClassSet<SmsOmsCollection> SmsOmsCollection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OMSConfigurationData</c> collection
        /// </summary>
        public WmiClassSet<SmsOmsConfigurationData> SmsOmsConfigurationData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OneDriveKnownFolderMigrationSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsOneDriveKnownFolderMigrationSettings> SmsOneDriveKnownFolderMigrationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OperatingSystemInstallPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsOperatingSystemInstallPackage> SmsOperatingSystemInstallPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Operation</c> collection
        /// </summary>
        public WmiClassSet<SmsOperation> SmsOperation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OS_Details</c> collection
        /// </summary>
        public WmiClassSet<SmsOsDetails> SmsOsDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OSDeploymentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsOsDeploymentConfig> SmsOsDeploymentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OSDeploymentKitInstalledVersion</c> collection
        /// </summary>
        public WmiClassSet<SmsOsDeploymentKitInstalledVersion> SmsOsDeploymentKitInstalledVersion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OSDeploymentKitSupportedPlatforms</c> collection
        /// </summary>
        public WmiClassSet<SmsOsDeploymentKitSupportedPlatforms> SmsOsDeploymentKitSupportedPlatforms { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OSDeploymentKitWinPEOptionalComponent</c> collection
        /// </summary>
        public WmiClassSet<SmsOsDeploymentKitWinPeOptionalComponent> SmsOsDeploymentKitWinPeOptionalComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OutOfBandManagementConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsOutOfBandManagementConfig> SmsOutOfBandManagementConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_OverallThreatActivity</c> collection
        /// </summary>
        public WmiClassSet<SmsOverallThreatActivity> SmsOverallThreatActivity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Package</c> collection
        /// </summary>
        public WmiClassSet<SmsPackage> SmsPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageAccessByUsers</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageAccessByUsers> SmsPackageAccessByUsers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageBaseclass</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageBaseclass> SmsPackageBaseclass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageContentServerInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageContentServerInfo> SmsPackageContentServerInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageStatus> SmsPackageStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageStatusDetailSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageStatusDetailSummarizer> SmsPackageStatusDetailSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageStatusDistPointsSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageStatusDistPointsSummarizer> SmsPackageStatusDistPointsSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageStatusRootSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageStatusRootSummarizer> SmsPackageStatusRootSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageToAdvert_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageToAdvertA> SmsPackageToAdvertA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageToContent</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageToContent> SmsPackageToContent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PackageToSourceSite_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPackageToSourceSiteA> SmsPackageToSourceSiteA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PassportForWorkProfileSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsPassportForWorkProfileSettings> SmsPassportForWorkProfileSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PDF_Package</c> collection
        /// </summary>
        public WmiClassSet<SmsPdfPackage> SmsPdfPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PDF_Program</c> collection
        /// </summary>
        public WmiClassSet<SmsPdfProgram> SmsPdfProgram { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PDFPkgToPDFProgram_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPdfPkgToPdfProgramA> SmsPdfPkgToPdfProgramA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PeerPxeConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsPeerPxeConfig> SmsPeerPxeConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PendingRegistrationRecord</c> collection
        /// </summary>
        public WmiClassSet<SmsPendingRegistrationRecord> SmsPendingRegistrationRecord { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Permission</c> collection
        /// </summary>
        public WmiClassSet<SmsPermission> SmsPermission { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PfxCertificateSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsPfxCertificateSettings> SmsPfxCertificateSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PfxCertificateTemplates</c> collection
        /// </summary>
        public WmiClassSet<SmsPfxCertificateTemplates> SmsPfxCertificateTemplates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PhasedDeployment</c> collection
        /// </summary>
        public WmiClassSet<SmsPhasedDeployment> SmsPhasedDeployment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PhasedDeploymentOperationalDataCI</c> collection
        /// </summary>
        public WmiClassSet<SmsPhasedDeploymentOperationalDataCi> SmsPhasedDeploymentOperationalDataCi { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PhasedDeploymentOperationalDataPkgProgram</c> collection
        /// </summary>
        public WmiClassSet<SmsPhasedDeploymentOperationalDataPkgProgram> SmsPhasedDeploymentOperationalDataPkgProgram { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PkgToPkgAccess_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPkgToPkgAccessA> SmsPkgToPkgAccessA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PkgToPkgProgram_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPkgToPkgProgramA> SmsPkgToPkgProgramA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PkgToPkgServer_a</c> collection
        /// </summary>
        public WmiClassSet<SmsPkgToPkgServerA> SmsPkgToPkgServerA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PolicyAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsPolicyAgentConfig> SmsPolicyAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PolicyProperty</c> collection
        /// </summary>
        public WmiClassSet<SmsPolicyProperty> SmsPolicyProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PowerAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsPowerAgentConfig> SmsPowerAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PowerConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsPowerConfig> SmsPowerConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ProductFileInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsProductFileInfo> SmsProductFileInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Program</c> collection
        /// </summary>
        public WmiClassSet<SmsProgram> SmsProgram { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_PXECertificateInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsPxeCertificateInfo> SmsPxeCertificateInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Query</c> collection
        /// </summary>
        public WmiClassSet<SmsQuery> SmsQuery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_IPNetwork</c> collection
        /// </summary>
        public WmiClassSet<SmsRIpNetwork> SmsRIpNetwork { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_ProvisioningSystem</c> collection
        /// </summary>
        public WmiClassSet<SmsRProvisioningSystem> SmsRProvisioningSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_System</c> collection
        /// </summary>
        public WmiClassSet<SmsRSystem> SmsRSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_UnknownSystem</c> collection
        /// </summary>
        public WmiClassSet<SmsRUnknownSystem> SmsRUnknownSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_User</c> collection
        /// </summary>
        public WmiClassSet<SmsRUser> SmsRUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_R_UserGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsRUserGroup> SmsRUserGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RbacSecuredObject</c> collection
        /// </summary>
        public WmiClassSet<SmsRbacSecuredObject> SmsRbacSecuredObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RcmSqlControl</c> collection
        /// </summary>
        public WmiClassSet<SmsRcmSqlControl> SmsRcmSqlControl { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RcmSqlControlProperty</c> collection
        /// </summary>
        public WmiClassSet<SmsRcmSqlControlProperty> SmsRcmSqlControlProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ReadinessDashboardConfigurationData</c> collection
        /// </summary>
        public WmiClassSet<SmsReadinessDashboardConfigurationData> SmsReadinessDashboardConfigurationData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RemoteConnectionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsRemoteConnectionSettings> SmsRemoteConnectionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RemoteToolsAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsRemoteToolsAgentConfig> SmsRemoteToolsAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ReplicationGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsReplicationGroup> SmsReplicationGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ReplicationLinkStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsReplicationLinkStatus> SmsReplicationLinkStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ReplicationLinkSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsReplicationLinkSummary> SmsReplicationLinkSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ReportViewSchema</c> collection
        /// </summary>
        public WmiClassSet<SmsReportViewSchema> SmsReportViewSchema { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ResIDValueLookup</c> collection
        /// </summary>
        public WmiClassSet<SmsResIdValueLookup> SmsResIdValueLookup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Resource</c> collection
        /// </summary>
        public WmiClassSet<SmsResource> SmsResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ResourceMap</c> collection
        /// </summary>
        public WmiClassSet<SmsResourceMap> SmsResourceMap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Role</c> collection
        /// </summary>
        public WmiClassSet<SmsRole> SmsRole { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_RoleInObjectType</c> collection
        /// </summary>
        public WmiClassSet<SmsRoleInObjectType> SmsRoleInObjectType { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCFToSCI_a</c> collection
        /// </summary>
        public WmiClassSet<SmsScfToSciA> SmsScfToSciA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCFToSite_a</c> collection
        /// </summary>
        public WmiClassSet<SmsScfToSiteA> SmsScfToSiteA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScheduleMethods</c> collection
        /// </summary>
        public WmiClassSet<SmsScheduleMethods> SmsScheduleMethods { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScheduleToken</c> collection
        /// </summary>
        public WmiClassSet<SmsScheduleToken> SmsScheduleToken { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_Address</c> collection
        /// </summary>
        public WmiClassSet<SmsSciAddress> SmsSciAddress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_ClientComp</c> collection
        /// </summary>
        public WmiClassSet<SmsSciClientComp> SmsSciClientComp { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_ClientConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSciClientConfig> SmsSciClientConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_Component</c> collection
        /// </summary>
        public WmiClassSet<SmsSciComponent> SmsSciComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_Configuration</c> collection
        /// </summary>
        public WmiClassSet<SmsSciConfiguration> SmsSciConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_FileDefinition</c> collection
        /// </summary>
        public WmiClassSet<SmsSciFileDefinition> SmsSciFileDefinition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_MaintenanceTask</c> collection
        /// </summary>
        public WmiClassSet<SmsSciMaintenanceTask> SmsSciMaintenanceTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_Property</c> collection
        /// </summary>
        public WmiClassSet<SmsSciProperty> SmsSciProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_PropertyList</c> collection
        /// </summary>
        public WmiClassSet<SmsSciPropertyList> SmsSciPropertyList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_Reserved</c> collection
        /// </summary>
        public WmiClassSet<SmsSciReserved> SmsSciReserved { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SCProperty</c> collection
        /// </summary>
        public WmiClassSet<SmsSciScProperty> SmsSciScProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SCPropertyList</c> collection
        /// </summary>
        public WmiClassSet<SmsSciScPropertyList> SmsSciScPropertyList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SiteAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsSciSiteAssignment> SmsSciSiteAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SiteDefinition</c> collection
        /// </summary>
        public WmiClassSet<SmsSciSiteDefinition> SmsSciSiteDefinition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SQLTask</c> collection
        /// </summary>
        public WmiClassSet<SmsSciSqlTask> SmsSciSqlTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SCI_SysResUse</c> collection
        /// </summary>
        public WmiClassSet<SmsSciSysResUse> SmsSciSysResUse { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScriptParameter</c> collection
        /// </summary>
        public WmiClassSet<SmsScriptParameter> SmsScriptParameter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Scripts</c> collection
        /// </summary>
        public WmiClassSet<SmsScripts> SmsScripts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScriptsExecutionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsScriptsExecutionStatus> SmsScriptsExecutionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScriptsExecutionSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsScriptsExecutionSummary> SmsScriptsExecutionSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ScriptsExecutionTask</c> collection
        /// </summary>
        public WmiClassSet<SmsScriptsExecutionTask> SmsScriptsExecutionTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SDMPackageLocalizedData</c> collection
        /// </summary>
        public WmiClassSet<SmsSdmPackageLocalizedData> SmsSdmPackageLocalizedData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SearchFolder</c> collection
        /// </summary>
        public WmiClassSet<SmsSearchFolder> SmsSearchFolder { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SecondarySiteStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSecondarySiteStatus> SmsSecondarySiteStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SecuredCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsSecuredCategory> SmsSecuredCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SecuredCategoryMembership</c> collection
        /// </summary>
        public WmiClassSet<SmsSecuredCategoryMembership> SmsSecuredCategoryMembership { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ServicePlan</c> collection
        /// </summary>
        public WmiClassSet<SmsServicePlan> SmsServicePlan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ServiceWindow</c> collection
        /// </summary>
        public WmiClassSet<SmsServiceWindow> SmsServiceWindow { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SettableSecuredCategory</c> collection
        /// </summary>
        public WmiClassSet<SmsSettableSecuredCategory> SmsSettableSecuredCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SettingsDefinitionBase</c> collection
        /// </summary>
        public WmiClassSet<SmsSettingsDefinitionBase> SmsSettingsDefinitionBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SetupInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsSetupInfo> SmsSetupInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SeverityRef</c> collection
        /// </summary>
        public WmiClassSet<SmsSeverityRef> SmsSeverityRef { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SII_Property</c> collection
        /// </summary>
        public WmiClassSet<SmsSiiProperty> SmsSiiProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SII_PropertyList</c> collection
        /// </summary>
        public WmiClassSet<SmsSiiPropertyList> SmsSiiPropertyList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_AddressType</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibAddressType> SmsSiibAddressType { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_Component_FileList</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibComponentFileList> SmsSiibComponentFileList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_Configuration</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibConfiguration> SmsSiibConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_Generic_Configuration</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibGenericConfiguration> SmsSiibGenericConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_SenderType</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibSenderType> SmsSiibSenderType { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SIIB_SysResRole</c> collection
        /// </summary>
        public WmiClassSet<SmsSiibSysResRole> SmsSiibSysResRole { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Site</c> collection
        /// </summary>
        public WmiClassSet<SmsSite> SmsSite { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteAndSubsites</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteAndSubsites> SmsSiteAndSubsites { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteControlDaySchedule</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteControlDaySchedule> SmsSiteControlDaySchedule { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteControlFile</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteControlFile> SmsSiteControlFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteControlItem</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteControlItem> SmsSiteControlItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteDetailSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteDetailSummarizer> SmsSiteDetailSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteInstallItem</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteInstallItem> SmsSiteInstallItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteInstallItemBase</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteInstallItemBase> SmsSiteInstallItemBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteInstallMap</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteInstallMap> SmsSiteInstallMap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteSystemSummarizer</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteSystemSummarizer> SmsSiteSystemSummarizer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteToSiteID_a</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteToSiteIdA> SmsSiteToSiteIdA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SiteToSubSite_a</c> collection
        /// </summary>
        public WmiClassSet<SmsSiteToSubSiteA> SmsSiteToSubSiteA { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SleepServer</c> collection
        /// </summary>
        public WmiClassSet<SmsSleepServer> SmsSleepServer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareCenterConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareCenterConfig> SmsSoftwareCenterConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareConversionRules</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareConversionRules> SmsSoftwareConversionRules { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareDistributionAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareDistributionAgentConfig> SmsSoftwareDistributionAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareInventoryAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareInventoryAgentConfig> SmsSoftwareInventoryAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareMeteringAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareMeteringAgentConfig> SmsSoftwareMeteringAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareUpdate</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareUpdate> SmsSoftwareUpdate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareUpdateBase</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareUpdateBase> SmsSoftwareUpdateBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareUpdatesAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareUpdatesAgentConfig> SmsSoftwareUpdatesAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareUpdateSource</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareUpdateSource> SmsSoftwareUpdateSource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SoftwareUpdatesPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsSoftwareUpdatesPackage> SmsSoftwareUpdatesPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SQLTaskStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSqlTaskStatus> SmsSqlTaskStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_NonRecurring</c> collection
        /// </summary>
        public WmiClassSet<SmsStNonRecurring> SmsStNonRecurring { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_RecurInterval</c> collection
        /// </summary>
        public WmiClassSet<SmsStRecurInterval> SmsStRecurInterval { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_RecurMonthlyByDate</c> collection
        /// </summary>
        public WmiClassSet<SmsStRecurMonthlyByDate> SmsStRecurMonthlyByDate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_RecurMonthlyByWeekday</c> collection
        /// </summary>
        public WmiClassSet<SmsStRecurMonthlyByWeekday> SmsStRecurMonthlyByWeekday { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_RecurMonthlyByWeekdayBase</c> collection
        /// </summary>
        public WmiClassSet<SmsStRecurMonthlyByWeekdayBase> SmsStRecurMonthlyByWeekdayBase { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ST_RecurWeekly</c> collection
        /// </summary>
        public WmiClassSet<SmsStRecurWeekly> SmsStRecurWeekly { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatAttr</c> collection
        /// </summary>
        public WmiClassSet<SmsStatAttr> SmsStatAttr { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StateInformation</c> collection
        /// </summary>
        public WmiClassSet<SmsStateInformation> SmsStateInformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StateMigration</c> collection
        /// </summary>
        public WmiClassSet<SmsStateMigration> SmsStateMigration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StateMigrationUserNames</c> collection
        /// </summary>
        public WmiClassSet<SmsStateMigrationUserNames> SmsStateMigrationUserNames { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StateSystemConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsStateSystemConfig> SmsStateSystemConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatInsStr</c> collection
        /// </summary>
        public WmiClassSet<SmsStatInsStr> SmsStatInsStr { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatMsg</c> collection
        /// </summary>
        public WmiClassSet<SmsStatMsg> SmsStatMsg { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatMsgAttributes</c> collection
        /// </summary>
        public WmiClassSet<SmsStatMsgAttributes> SmsStatMsgAttributes { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatMsgInsStrings</c> collection
        /// </summary>
        public WmiClassSet<SmsStatMsgInsStrings> SmsStatMsgInsStrings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatMsgModuleNames</c> collection
        /// </summary>
        public WmiClassSet<SmsStatMsgModuleNames> SmsStatMsgModuleNames { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatMsgWithInsStrings</c> collection
        /// </summary>
        public WmiClassSet<SmsStatMsgWithInsStrings> SmsStatMsgWithInsStrings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_StatusMessage</c> collection
        /// </summary>
        public WmiClassSet<SmsStatusMessage> SmsStatusMessage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Subscription</c> collection
        /// </summary>
        public WmiClassSet<SmsSubscription> SmsSubscription { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SUMDeploymentAssetDetails</c> collection
        /// </summary>
        public WmiClassSet<SmsSumDeploymentAssetDetails> SmsSumDeploymentAssetDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SUMDeploymentStatistics</c> collection
        /// </summary>
        public WmiClassSet<SmsSumDeploymentStatistics> SmsSumDeploymentStatistics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SUMDeploymentStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSumDeploymentStatus> SmsSumDeploymentStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummarizationInterval</c> collection
        /// </summary>
        public WmiClassSet<SmsSummarizationInterval> SmsSummarizationInterval { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummarizationSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsSummarizationSettings> SmsSummarizationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummarizerRootStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSummarizerRootStatus> SmsSummarizerRootStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummarizerSiteStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSummarizerSiteStatus> SmsSummarizerSiteStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummarizerStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSummarizerStatus> SmsSummarizerStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SummaryTask</c> collection
        /// </summary>
        public WmiClassSet<SmsSummaryTask> SmsSummaryTask { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SupportedPlatforms</c> collection
        /// </summary>
        public WmiClassSet<SmsSupportedPlatforms> SmsSupportedPlatforms { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SupportedPlatformsOfflineServicing</c> collection
        /// </summary>
        public WmiClassSet<SmsSupportedPlatformsOfflineServicing> SmsSupportedPlatformsOfflineServicing { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SUPSyncStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsSupSyncStatus> SmsSupSyncStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SyncPfxCertificateTemplatesAction</c> collection
        /// </summary>
        public WmiClassSet<SmsSyncPfxCertificateTemplatesAction> SmsSyncPfxCertificateTemplatesAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SystemAuxInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsSystemAuxInfo> SmsSystemAuxInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SystemResourceList</c> collection
        /// </summary>
        public WmiClassSet<SmsSystemResourceList> SmsSystemResourceList { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_SystemResourceQueryResults</c> collection
        /// </summary>
        public WmiClassSet<SmsSystemResourceQueryResults> SmsSystemResourceQueryResults { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TargetingAgentConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsTargetingAgentConfig> SmsTargetingAgentConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequence> SmsTaskSequence { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Action</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceAction> SmsTaskSequenceAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplicationInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplicationInfo> SmsTaskSequenceApplicationInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplyDataImageAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplyDataImageAction> SmsTaskSequenceApplyDataImageAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplyDriverPackageAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplyDriverPackageAction> SmsTaskSequenceApplyDriverPackageAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplyNetworkSettingsAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplyNetworkSettingsAction> SmsTaskSequenceApplyNetworkSettingsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplyOperatingSystemAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplyOperatingSystemAction> SmsTaskSequenceApplyOperatingSystemAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ApplyWindowsSettingsAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceApplyWindowsSettingsAction> SmsTaskSequenceApplyWindowsSettingsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_AutoApplyAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceAutoApplyAction> SmsTaskSequenceAutoApplyAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_CaptureNetworkSettingsAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceCaptureNetworkSettingsAction> SmsTaskSequenceCaptureNetworkSettingsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_CaptureSystemImageAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceCaptureSystemImageAction> SmsTaskSequenceCaptureSystemImageAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_CaptureUserStateAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceCaptureUserStateAction> SmsTaskSequenceCaptureUserStateAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_CaptureWindowsSettingsAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceCaptureWindowsSettingsAction> SmsTaskSequenceCaptureWindowsSettingsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ComputerConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceComputerConditionExpression> SmsTaskSequenceComputerConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Condition</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceCondition> SmsTaskSequenceCondition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceConditionExpression> SmsTaskSequenceConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ConditionOperand</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceConditionOperand> SmsTaskSequenceConditionOperand { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ConditionOperator</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceConditionOperator> SmsTaskSequenceConditionOperator { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ConnectNetworkFolderAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceConnectNetworkFolderAction> SmsTaskSequenceConnectNetworkFolderAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ConvertDiskAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceConvertDiskAction> SmsTaskSequenceConvertDiskAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_DisableBitLockerAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceDisableBitLockerAction> SmsTaskSequenceDisableBitLockerAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_DownloadPackageContentAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceDownloadPackageContentAction> SmsTaskSequenceDownloadPackageContentAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_EnableBitLockerAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceEnableBitLockerAction> SmsTaskSequenceEnableBitLockerAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_FileConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceFileConditionExpression> SmsTaskSequenceFileConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_FolderConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceFolderConditionExpression> SmsTaskSequenceFolderConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Group</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceGroup> SmsTaskSequenceGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_InstallApplicationAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceInstallApplicationAction> SmsTaskSequenceInstallApplicationAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_InstallDeployToolsAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceInstallDeployToolsAction> SmsTaskSequenceInstallDeployToolsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_InstallSoftwareAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceInstallSoftwareAction> SmsTaskSequenceInstallSoftwareAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_InstallUpdateAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceInstallUpdateAction> SmsTaskSequenceInstallUpdateAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_JoinDomainWorkgroupAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceJoinDomainWorkgroupAction> SmsTaskSequenceJoinDomainWorkgroupAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_LocationConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceLocationConditionExpression> SmsTaskSequenceLocationConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_MakeModelConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceMakeModelConditionExpression> SmsTaskSequenceMakeModelConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_NetworkAdapterSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceNetworkAdapterSettings> SmsTaskSequenceNetworkAdapterSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_OfflineEnableBitLockerAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceOfflineEnableBitLockerAction> SmsTaskSequenceOfflineEnableBitLockerAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_OSConditionGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceOsConditionGroup> SmsTaskSequenceOsConditionGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_OSExpressionGroup</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceOsExpressionGroup> SmsTaskSequenceOsExpressionGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PackageInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePackageInfo> SmsTaskSequencePackageInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PartitionDiskAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePartitionDiskAction> SmsTaskSequencePartitionDiskAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PartitionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePartitionSettings> SmsTaskSequencePartitionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Pointer</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePointer> SmsTaskSequencePointer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PrepareOSAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePrepareOsAction> SmsTaskSequencePrepareOsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PrepareSMSClientAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePrepareSmsClientAction> SmsTaskSequencePrepareSmsClientAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_PrestartCheckAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePrestartCheckAction> SmsTaskSequencePrestartCheckAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RebootAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRebootAction> SmsTaskSequenceRebootAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Reference</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceReference> SmsTaskSequenceReference { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RegistryConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRegistryConditionExpression> SmsTaskSequenceRegistryConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_ReleaseStateStoreAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceReleaseStateStoreAction> SmsTaskSequenceReleaseStateStoreAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RequestStateStoreAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRequestStateStoreAction> SmsTaskSequenceRequestStateStoreAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RestoreUserStateAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRestoreUserStateAction> SmsTaskSequenceRestoreUserStateAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Rule</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRule> SmsTaskSequenceRule { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RunCommandLineAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRunCommandLineAction> SmsTaskSequenceRunCommandLineAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_RunPowerShellScriptAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceRunPowerShellScriptAction> SmsTaskSequenceRunPowerShellScriptAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SecuredVariable</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSecuredVariable> SmsTaskSequenceSecuredVariable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SetDynamicVariablesAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSetDynamicVariablesAction> SmsTaskSequenceSetDynamicVariablesAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SetupWindowsAndSMSAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSetupWindowsAndSmsAction> SmsTaskSequenceSetupWindowsAndSmsAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SetVariableAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSetVariableAction> SmsTaskSequenceSetVariableAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SoftwareConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSoftwareConditionExpression> SmsTaskSequenceSoftwareConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Step</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceStep> SmsTaskSequenceStep { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_SubTasksequence</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceSubTasksequence> SmsTaskSequenceSubTasksequence { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_UpgradeOperatingSystemAction</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceUpgradeOperatingSystemAction> SmsTaskSequenceUpgradeOperatingSystemAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_Variable</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceVariable> SmsTaskSequenceVariable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_VariableConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceVariableConditionExpression> SmsTaskSequenceVariableConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequence_WMIConditionExpression</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceWmiConditionExpression> SmsTaskSequenceWmiConditionExpression { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequenceAppReferenceDps</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceAppReferenceDps> SmsTaskSequenceAppReferenceDps { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequenceAppReferencesInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceAppReferencesInfo> SmsTaskSequenceAppReferencesInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequenceExecutionStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceExecutionStatus> SmsTaskSequenceExecutionStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequencePackage</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePackage> SmsTaskSequencePackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequencePackageReference</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePackageReference> SmsTaskSequencePackageReference { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequencePackageReference_All</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePackageReferenceAll> SmsTaskSequencePackageReferenceAll { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequencePackageReference_Flat</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequencePackageReferenceFlat> SmsTaskSequencePackageReferenceFlat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequenceReferenceDps</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceReferenceDps> SmsTaskSequenceReferenceDps { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TaskSequenceReferencesInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsTaskSequenceReferencesInfo> SmsTaskSequenceReferencesInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Template</c> collection
        /// </summary>
        public WmiClassSet<SmsTemplate> SmsTemplate { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TermsAndConditionsSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsTermsAndConditionsSettings> SmsTermsAndConditionsSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_ThreatPath</c> collection
        /// </summary>
        public WmiClassSet<SmsThreatPath> SmsThreatPath { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TopThreatsDetected</c> collection
        /// </summary>
        public WmiClassSet<SmsTopThreatsDetected> SmsTopThreatsDetected { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TopThreatSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsTopThreatSummary> SmsTopThreatSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_TrustedRootCertificateSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsTrustedRootCertificateSettings> SmsTrustedRootCertificateSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UacComplianceSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsUacComplianceSettings> SmsUacComplianceSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UnManagedApps</c> collection
        /// </summary>
        public WmiClassSet<SmsUnManagedApps> SmsUnManagedApps { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateCategoryInstance</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateCategoryInstance> SmsUpdateCategoryInstance { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateComplianceStatus</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateComplianceStatus> SmsUpdateComplianceStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateDeploymentClientSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateDeploymentClientSummary> SmsUpdateDeploymentClientSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateDeploymentSummary</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateDeploymentSummary> SmsUpdateDeploymentSummary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateGroupAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateGroupAssignment> SmsUpdateGroupAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdatesAssignment</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdatesAssignment> SmsUpdatesAssignment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UpdateState_Combined</c> collection
        /// </summary>
        public WmiClassSet<SmsUpdateStateCombined> SmsUpdateStateCombined { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserApplicationRequest</c> collection
        /// </summary>
        public WmiClassSet<SmsUserApplicationRequest> SmsUserApplicationRequest { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserApplicationRequestHistoryItem</c> collection
        /// </summary>
        public WmiClassSet<SmsUserApplicationRequestHistoryItem> SmsUserApplicationRequestHistoryItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserMachineIntelligence</c> collection
        /// </summary>
        public WmiClassSet<SmsUserMachineIntelligence> SmsUserMachineIntelligence { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserMachineRelationship</c> collection
        /// </summary>
        public WmiClassSet<SmsUserMachineRelationship> SmsUserMachineRelationship { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsUserSettings> SmsUserSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserStateManagementSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsUserStateManagementSettings> SmsUserStateManagementSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_UserVariable</c> collection
        /// </summary>
        public WmiClassSet<SmsUserVariable> SmsUserVariable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_VhdPackage</c> collection
        /// </summary>
        public WmiClassSet<SmsVhdPackage> SmsVhdPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_VirtualEnvironment</c> collection
        /// </summary>
        public WmiClassSet<SmsVirtualEnvironment> SmsVirtualEnvironment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_VpnConnectionSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsVpnConnectionSettings> SmsVpnConnectionSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WhatsNewFeature</c> collection
        /// </summary>
        public WmiClassSet<SmsWhatsNewFeature> SmsWhatsNewFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WhatsNewScenario</c> collection
        /// </summary>
        public WmiClassSet<SmsWhatsNewScenario> SmsWhatsNewScenario { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_Windows10Dashboard</c> collection
        /// </summary>
        public WmiClassSet<SmsWindows10Dashboard> SmsWindows10Dashboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsAnalyticsConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsAnalyticsConfig> SmsWindowsAnalyticsConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsDefenderAntimalwareSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsDefenderAntimalwareSettings> SmsWindowsDefenderAntimalwareSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsDefenderApplicationGuard</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsDefenderApplicationGuard> SmsWindowsDefenderApplicationGuard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsDOConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsDoConfig> SmsWindowsDoConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsServicingBusinessReadyUpdates</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsServicingBusinessReadyUpdates> SmsWindowsServicingBusinessReadyUpdates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsServicingLocalizedNames</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsServicingLocalizedNames> SmsWindowsServicingLocalizedNames { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsServicingProductCategoryNames</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsServicingProductCategoryNames> SmsWindowsServicingProductCategoryNames { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsServicingStates</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsServicingStates> SmsWindowsServicingStates { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WindowsUpdateForBusinessConfigurationSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsWindowsUpdateForBusinessConfigurationSettings> SmsWindowsUpdateForBusinessConfigurationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WinPEOptionalComponentInBootImage</c> collection
        /// </summary>
        public WmiClassSet<SmsWinPeOptionalComponentInBootImage> SmsWinPeOptionalComponentInBootImage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WinPEOptionalComponentInfo</c> collection
        /// </summary>
        public WmiClassSet<SmsWinPeOptionalComponentInfo> SmsWinPeOptionalComponentInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WinPEPeerCacheConfig</c> collection
        /// </summary>
        public WmiClassSet<SmsWinPePeerCacheConfig> SmsWinPePeerCacheConfig { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WinRTSideLoadingKey</c> collection
        /// </summary>
        public WmiClassSet<SmsWinRtSideLoadingKey> SmsWinRtSideLoadingKey { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WirelessProfileSettings</c> collection
        /// </summary>
        public WmiClassSet<SmsWirelessProfileSettings> SmsWirelessProfileSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WSfBConfigurationData</c> collection
        /// </summary>
        public WmiClassSet<SmsWSfBConfigurationData> SmsWSfBConfigurationData { get; set; }

        /// <summary>
        /// Representation of WMI class <c>SMS_WSUSSigningCertificate</c> collection
        /// </summary>
        public WmiClassSet<SmsWsusSigningCertificate> SmsWsusSigningCertificate { get; set; }
    }
}