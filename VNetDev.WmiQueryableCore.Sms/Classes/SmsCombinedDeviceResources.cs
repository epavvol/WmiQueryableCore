using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CombinedDeviceResources
    /// </summary>
    [WmiClass(Name = "SMS_CombinedDeviceResources")]
    public class SmsCombinedDeviceResources
    {
        /// <summary>
        /// WMI Property AADDeviceID
        /// </summary>
        public string AadDeviceId { get; set; }
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property ActivationLockBypassState
        /// </summary>
        public uint ActivationLockBypassState { get; set; }
        /// <summary>
        /// WMI Property ActivationLockBypassStateTimeStamp
        /// </summary>
        public DateTime ActivationLockBypassStateTimeStamp { get; set; }
        /// <summary>
        /// WMI Property ActivationLockState
        /// </summary>
        public string ActivationLockState { get; set; }
        /// <summary>
        /// WMI Property ADLastLogonTime
        /// </summary>
        public DateTime AdLastLogonTime { get; set; }
        /// <summary>
        /// WMI Property ADSiteName
        /// </summary>
        public string AdSiteName { get; set; }
        /// <summary>
        /// WMI Property AMTFullVersion
        /// </summary>
        public string AmtFullVersion { get; set; }
        /// <summary>
        /// WMI Property AMTStatus
        /// </summary>
        public uint AmtStatus { get; set; }
        /// <summary>
        /// WMI Property ATPLastConnected
        /// </summary>
        public DateTime AtpLastConnected { get; set; }
        /// <summary>
        /// WMI Property ATPOnboardingState
        /// </summary>
        public uint AtpOnboardingState { get; set; }
        /// <summary>
        /// WMI Property ATPOrgId
        /// </summary>
        public string AtpOrgId { get; set; }
        /// <summary>
        /// WMI Property ATPSenseIsRunning
        /// </summary>
        public bool AtpSenseIsRunning { get; set; }
        /// <summary>
        /// WMI Property BoundaryGroups
        /// </summary>
        public string BoundaryGroups { get; set; }
        /// <summary>
        /// WMI Property CAComplianceEvalTime
        /// </summary>
        public string CaComplianceEvalTime { get; set; }
        /// <summary>
        /// WMI Property CAComplianceSetTime
        /// </summary>
        public string CaComplianceSetTime { get; set; }
        /// <summary>
        /// WMI Property CAErrorDetails
        /// </summary>
        public string CaErrorDetails { get; set; }
        /// <summary>
        /// WMI Property CAErrorLocation
        /// </summary>
        public uint CaErrorLocation { get; set; }
        /// <summary>
        /// WMI Property CAIsCompliant
        /// </summary>
        public bool CaIsCompliant { get; set; }
        /// <summary>
        /// WMI Property ClientActiveStatus
        /// </summary>
        public int ClientActiveStatus { get; set; }
        /// <summary>
        /// WMI Property ClientCertType
        /// </summary>
        public uint ClientCertType { get; set; }
        /// <summary>
        /// WMI Property ClientCheckPass
        /// </summary>
        public int ClientCheckPass { get; set; }
        /// <summary>
        /// WMI Property ClientEdition
        /// </summary>
        public uint ClientEdition { get; set; }
        /// <summary>
        /// WMI Property ClientRemediationSuccess
        /// </summary>
        public int ClientRemediationSuccess { get; set; }
        /// <summary>
        /// WMI Property ClientState
        /// </summary>
        public uint ClientState { get; set; }
        /// <summary>
        /// WMI Property ClientType
        /// </summary>
        public uint ClientType { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property CNAccessMP
        /// </summary>
        public string CnAccessMp { get; set; }
        /// <summary>
        /// WMI Property CNIsOnInternet
        /// </summary>
        public bool CnIsOnInternet { get; set; }
        /// <summary>
        /// WMI Property CNIsOnline
        /// </summary>
        public bool CnIsOnline { get; set; }
        /// <summary>
        /// WMI Property CNLastOfflineTime
        /// </summary>
        public DateTime CnLastOfflineTime { get; set; }
        /// <summary>
        /// WMI Property CNLastOnlineTime
        /// </summary>
        public DateTime CnLastOnlineTime { get; set; }
        /// <summary>
        /// WMI Property CoManaged
        /// </summary>
        public bool CoManaged { get; set; }
        /// <summary>
        /// WMI Property CurrentLogonUser
        /// </summary>
        public string CurrentLogonUser { get; set; }
        /// <summary>
        /// WMI Property DeviceAccessState
        /// </summary>
        public string DeviceAccessState { get; set; }
        /// <summary>
        /// WMI Property DeviceCategory
        /// </summary>
        public string DeviceCategory { get; set; }
        /// <summary>
        /// WMI Property DeviceOS
        /// </summary>
        public string DeviceOs { get; set; }
        /// <summary>
        /// WMI Property DeviceOSBuild
        /// </summary>
        public string DeviceOsBuild { get; set; }
        /// <summary>
        /// WMI Property DeviceOwner
        /// </summary>
        public uint DeviceOwner { get; set; }
        /// <summary>
        /// WMI Property DeviceThreatLevel
        /// </summary>
        public string DeviceThreatLevel { get; set; }
        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// WMI Property EASDeviceID
        /// </summary>
        public string EasDeviceId { get; set; }
        /// <summary>
        /// WMI Property EnrollmentStatus
        /// </summary>
        public uint EnrollmentStatus { get; set; }
        /// <summary>
        /// WMI Property EPAntispywareEnabled
        /// </summary>
        public bool EpAntispywareEnabled { get; set; }
        /// <summary>
        /// WMI Property EPAntispywareSignatureLastUpdateDateTime
        /// </summary>
        public DateTime EpAntispywareSignatureLastUpdateDateTime { get; set; }
        /// <summary>
        /// WMI Property EPAntispywareSignatureLastVersion
        /// </summary>
        public string EpAntispywareSignatureLastVersion { get; set; }
        /// <summary>
        /// WMI Property EPAntivirusEnabled
        /// </summary>
        public bool EpAntivirusEnabled { get; set; }
        /// <summary>
        /// WMI Property EPAntivirusSignatureLastUpdateDateTime
        /// </summary>
        public DateTime EpAntivirusSignatureLastUpdateDateTime { get; set; }
        /// <summary>
        /// WMI Property EPAntivirusSignatureLastVersion
        /// </summary>
        public string EpAntivirusSignatureLastVersion { get; set; }
        /// <summary>
        /// WMI Property EPClientVersion
        /// </summary>
        public string EpClientVersion { get; set; }
        /// <summary>
        /// WMI Property EPDeploymentDescription
        /// </summary>
        public string EpDeploymentDescription { get; set; }
        /// <summary>
        /// WMI Property EPDeploymentErrorCode
        /// </summary>
        public uint EpDeploymentErrorCode { get; set; }
        /// <summary>
        /// WMI Property EPDeploymentState
        /// </summary>
        public uint EpDeploymentState { get; set; }
        /// <summary>
        /// WMI Property EPEnabled
        /// </summary>
        public bool EpEnabled { get; set; }
        /// <summary>
        /// WMI Property EPEngineVersion
        /// </summary>
        public string EpEngineVersion { get; set; }
        /// <summary>
        /// WMI Property EPInfectionStatus
        /// </summary>
        public uint EpInfectionStatus { get; set; }
        /// <summary>
        /// WMI Property EPLastFullScanDateTimeEnd
        /// </summary>
        public DateTime EpLastFullScanDateTimeEnd { get; set; }
        /// <summary>
        /// WMI Property EPLastFullScanDateTimeStart
        /// </summary>
        public DateTime EpLastFullScanDateTimeStart { get; set; }
        /// <summary>
        /// WMI Property EPLastInfectionTime
        /// </summary>
        public DateTime EpLastInfectionTime { get; set; }
        /// <summary>
        /// WMI Property EPLastQuickScanDateTimeEnd
        /// </summary>
        public DateTime EpLastQuickScanDateTimeEnd { get; set; }
        /// <summary>
        /// WMI Property EPLastQuickScanDateTimeStart
        /// </summary>
        public DateTime EpLastQuickScanDateTimeStart { get; set; }
        /// <summary>
        /// WMI Property EPLastThreatName
        /// </summary>
        public string EpLastThreatName { get; set; }
        /// <summary>
        /// WMI Property EPPendingFullScan
        /// </summary>
        public bool EpPendingFullScan { get; set; }
        /// <summary>
        /// WMI Property EPPendingManualSteps
        /// </summary>
        public bool EpPendingManualSteps { get; set; }
        /// <summary>
        /// WMI Property EPPendingOfflineScan
        /// </summary>
        public bool EpPendingOfflineScan { get; set; }
        /// <summary>
        /// WMI Property EPPendingReboot
        /// </summary>
        public bool EpPendingReboot { get; set; }
        /// <summary>
        /// WMI Property EPPolicyApplicationDescription
        /// </summary>
        public string EpPolicyApplicationDescription { get; set; }
        /// <summary>
        /// WMI Property EPPolicyApplicationErrorCode
        /// </summary>
        public uint EpPolicyApplicationErrorCode { get; set; }
        /// <summary>
        /// WMI Property EPPolicyApplicationState
        /// </summary>
        public uint EpPolicyApplicationState { get; set; }
        /// <summary>
        /// WMI Property EPProductStatus
        /// </summary>
        public uint EpProductStatus { get; set; }
        /// <summary>
        /// WMI Property ExchangeOrganization
        /// </summary>
        public string ExchangeOrganization { get; set; }
        /// <summary>
        /// WMI Property ExchangeServer
        /// </summary>
        public string ExchangeServer { get; set; }
        /// <summary>
        /// WMI Property IMEI
        /// </summary>
        public string Imei { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property IsAlwaysInternet
        /// </summary>
        public bool IsAlwaysInternet { get; set; }
        /// <summary>
        /// WMI Property IsAOACCapable
        /// </summary>
        public bool IsAoacCapable { get; set; }
        /// <summary>
        /// WMI Property IsApproved
        /// </summary>
        public uint IsApproved { get; set; }
        /// <summary>
        /// WMI Property IsBlocked
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// WMI Property IsClient
        /// </summary>
        public bool IsClient { get; set; }
        /// <summary>
        /// WMI Property IsInternetEnabled
        /// </summary>
        public bool IsInternetEnabled { get; set; }
        /// <summary>
        /// WMI Property IsMDMActive
        /// </summary>
        public bool IsMdmActive { get; set; }
        /// <summary>
        /// WMI Property IsObsolete
        /// </summary>
        public bool IsObsolete { get; set; }
        /// <summary>
        /// WMI Property IsSupervised
        /// </summary>
        public string IsSupervised { get; set; }
        /// <summary>
        /// WMI Property IsVirtualMachine
        /// </summary>
        public bool IsVirtualMachine { get; set; }
        /// <summary>
        /// WMI Property LastActiveTime
        /// </summary>
        public DateTime LastActiveTime { get; set; }
        /// <summary>
        /// WMI Property LastClientCheckTime
        /// </summary>
        public DateTime LastClientCheckTime { get; set; }
        /// <summary>
        /// WMI Property LastDDR
        /// </summary>
        public DateTime LastDdr { get; set; }
        /// <summary>
        /// WMI Property LastHardwareScan
        /// </summary>
        public DateTime LastHardwareScan { get; set; }
        /// <summary>
        /// WMI Property LastInstallationError
        /// </summary>
        public uint LastInstallationError { get; set; }
        /// <summary>
        /// WMI Property LastLogonUser
        /// </summary>
        public string LastLogonUser { get; set; }
        /// <summary>
        /// WMI Property LastMPServerName
        /// </summary>
        public string LastMpServerName { get; set; }
        /// <summary>
        /// WMI Property LastPolicyRequest
        /// </summary>
        public DateTime LastPolicyRequest { get; set; }
        /// <summary>
        /// WMI Property LastSoftwareScan
        /// </summary>
        public DateTime LastSoftwareScan { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessage
        /// </summary>
        public DateTime LastStatusMessage { get; set; }
        /// <summary>
        /// WMI Property LastSuccessSyncTimeUTC
        /// </summary>
        public DateTime LastSuccessSyncTimeUtc { get; set; }
        /// <summary>
        /// WMI Property LastSyncNowRequest
        /// </summary>
        public DateTime LastSyncNowRequest { get; set; }
        /// <summary>
        /// WMI Property LatestProcessingAttempt
        /// </summary>
        public DateTime LatestProcessingAttempt { get; set; }
        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// WMI Property ManagementAuthority
        /// </summary>
        public uint ManagementAuthority { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PasscodeResetState
        /// </summary>
        public uint PasscodeResetState { get; set; }
        /// <summary>
        /// WMI Property PasscodeResetStateTimeStamp
        /// </summary>
        public DateTime PasscodeResetStateTimeStamp { get; set; }
        /// <summary>
        /// WMI Property PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// WMI Property PolicyApplicationStatus
        /// </summary>
        public string PolicyApplicationStatus { get; set; }
        /// <summary>
        /// WMI Property PrimaryUser
        /// </summary>
        public string PrimaryUser { get; set; }
        /// <summary>
        /// WMI Property RemoteLockState
        /// </summary>
        public uint RemoteLockState { get; set; }
        /// <summary>
        /// WMI Property RemoteLockStateTimeStamp
        /// </summary>
        public DateTime RemoteLockStateTimeStamp { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property RetireStatus
        /// </summary>
        public uint RetireStatus { get; set; }
        /// <summary>
        /// WMI Property SenseID
        /// </summary>
        public string SenseId { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SMBIOSGUID
        /// </summary>
        public string Smbiosguid { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property SuppressAutoProvision
        /// </summary>
        public bool SuppressAutoProvision { get; set; }
        /// <summary>
        /// WMI Property SyncNowStatus
        /// </summary>
        public uint SyncNowStatus { get; set; }
        /// <summary>
        /// WMI Property Unknown
        /// </summary>
        public bool Unknown { get; set; }
        /// <summary>
        /// WMI Property UserDomainName
        /// </summary>
        public string UserDomainName { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property WipeStatus
        /// </summary>
        public uint WipeStatus { get; set; }
    }
}
