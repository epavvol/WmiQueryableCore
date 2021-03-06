using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConfigurationItemBaseClass
    /// </summary>
    [WmiClass(Name = "SMS_ConfigurationItemBaseClass")]
    public class SmsConfigurationItemBaseClass
    {
        /// <summary>
        /// WMI method <c>SetIsExpired</c> describing delegate.
        /// <param name="expired">WMI Property <c>Expired</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetIsExpiredDelegate(bool expired = default);
        /// <summary>
        /// WMI method <c>SetIsExpired</c>.
        /// </summary>
        public SetIsExpiredDelegate SetIsExpired;
        
        /// <summary>
        /// WMI method <c>UpdateStats</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateStatsDelegate();
        /// <summary>
        /// WMI method <c>UpdateStats</c>.
        /// </summary>
        public UpdateStatsDelegate UpdateStats;
        
        /// <summary>
        /// WMI method <c>Restore</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RestoreDelegate();
        /// <summary>
        /// WMI method <c>Restore</c>.
        /// </summary>
        public RestoreDelegate Restore;
        
        /// <summary>
        /// WMI method <c>GetCIDocuments</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetCiDocumentsDelegate();
        /// <summary>
        /// WMI method <c>GetCIDocuments</c>.
        /// </summary>
        public GetCiDocumentsDelegate GetCiDocuments;
        
        /// <summary>
        /// WMI method <c>GetCIDocumentBody</c> describing delegate.
        /// <param name="documentId">WMI Property <c>DocumentID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetCiDocumentBodyDelegate(string documentId = default);
        /// <summary>
        /// WMI method <c>GetCIDocumentBody</c>.
        /// </summary>
        public GetCiDocumentBodyDelegate GetCiDocumentBody;
        
        /// <summary>
        /// WMI static method <c>InitiateUserInstall</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="clientGuid">WMI Property <c>ClientGUID</c> of type <c>string</c>.</param>
        /// <param name="modelName">WMI Property <c>ModelName</c> of type <c>string</c>.</param>
        /// <param name="username">WMI Property <c>Username</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitiateUserInstallDelegate(WmiContext wmiContext, string clientGuid = default, string modelName = default, string username = default);
        /// <summary>
        /// WMI static method <c>InitiateUserInstall</c>.
        /// </summary>
        public static InitiateUserInstallDelegate InitiateUserInstall;
        
        /// <summary>
        /// WMI static method <c>ManageDeploymentForDevice</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="action">WMI Property <c>Action</c> of type <c>uint</c>.</param>
        /// <param name="assignmentUniqueId">WMI Property <c>AssignmentUniqueID</c> of type <c>string</c>.</param>
        /// <param name="clientGuid">WMI Property <c>ClientGUID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ManageDeploymentForDeviceDelegate(WmiContext wmiContext, uint action = default, string assignmentUniqueId = default, string clientGuid = default);
        /// <summary>
        /// WMI static method <c>ManageDeploymentForDevice</c>.
        /// </summary>
        public static ManageDeploymentForDeviceDelegate ManageDeploymentForDevice;
        /// <summary>
        /// WMI Property ApplicabilityCondition
        /// </summary>
        public string ApplicabilityCondition { get; set; }
        /// <summary>
        /// WMI Property CategoryInstance_UniqueIDs
        /// </summary>
        [WmiProperty(Name = "CategoryInstance_UniqueIDs")]
        public ICollection<string> CategoryInstanceUniqueIDs { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property CIType_ID
        /// </summary>
        [WmiProperty(Name = "CIType_ID")]
        public uint CiTypeId { get; set; }
        /// <summary>
        /// WMI Property CIVersion
        /// </summary>
        public uint CiVersion { get; set; }
        /// <summary>
        /// WMI Property ConfigurationFlags
        /// </summary>
        public ulong ConfigurationFlags { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property EffectiveDate
        /// </summary>
        public DateTime EffectiveDate { get; set; }
        /// <summary>
        /// WMI Property EULAAccepted
        /// </summary>
        public uint EulaAccepted { get; set; }
        /// <summary>
        /// WMI Property EULAExists
        /// </summary>
        public bool EulaExists { get; set; }
        /// <summary>
        /// WMI Property EULASignoffDate
        /// </summary>
        public DateTime EulaSignoffDate { get; set; }
        /// <summary>
        /// WMI Property EULASignoffUser
        /// </summary>
        public string EulaSignoffUser { get; set; }
        /// <summary>
        /// WMI Property ExecutionContext
        /// </summary>
        public uint ExecutionContext { get; set; }
        /// <summary>
        /// WMI Property Featured
        /// </summary>
        public uint Featured { get; set; }
        /// <summary>
        /// WMI Property HasContent
        /// </summary>
        public bool HasContent { get; set; }
        /// <summary>
        /// WMI Property IsBundle
        /// </summary>
        public bool IsBundle { get; set; }
        /// <summary>
        /// WMI Property IsDeployable
        /// </summary>
        public bool IsDeployable { get; set; }
        /// <summary>
        /// WMI Property IsDeployed
        /// </summary>
        public bool IsDeployed { get; set; }
        /// <summary>
        /// WMI Property IsDigest
        /// </summary>
        public bool IsDigest { get; set; }
        /// <summary>
        /// WMI Property IsEnabled
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// WMI Property IsExpired
        /// </summary>
        public bool IsExpired { get; set; }
        /// <summary>
        /// WMI Property IsHidden
        /// </summary>
        public bool IsHidden { get; set; }
        /// <summary>
        /// WMI Property IsLatest
        /// </summary>
        public bool IsLatest { get; set; }
        /// <summary>
        /// WMI Property IsQuarantined
        /// </summary>
        public bool IsQuarantined { get; set; }
        /// <summary>
        /// WMI Property IsSuperseded
        /// </summary>
        public bool IsSuperseded { get; set; }
        /// <summary>
        /// WMI Property IsSuperseding
        /// </summary>
        public bool IsSuperseding { get; set; }
        /// <summary>
        /// WMI Property IsUserDefined
        /// </summary>
        public bool IsUserDefined { get; set; }
        /// <summary>
        /// WMI Property IsVersionCompatible
        /// </summary>
        public bool IsVersionCompatible { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LocalizedCategoryInstanceNames
        /// </summary>
        public ICollection<string> LocalizedCategoryInstanceNames { get; set; }
        /// <summary>
        /// WMI Property LocalizedDescription
        /// </summary>
        public string LocalizedDescription { get; set; }
        /// <summary>
        /// WMI Property LocalizedDisplayName
        /// </summary>
        public string LocalizedDisplayName { get; set; }
        /// <summary>
        /// WMI Property LocalizedInformativeURL
        /// </summary>
        public string LocalizedInformativeUrl { get; set; }
        /// <summary>
        /// WMI Property LocalizedPropertyLocaleID
        /// </summary>
        public uint LocalizedPropertyLocaleId { get; set; }
        /// <summary>
        /// WMI Property LogonRequirement
        /// </summary>
        public uint LogonRequirement { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property ModelID
        /// </summary>
        public uint ModelId { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property NumberOfDependentDTs
        /// </summary>
        public uint NumberOfDependentDTs { get; set; }
        /// <summary>
        /// WMI Property NumberOfDependentTS
        /// </summary>
        public uint NumberOfDependentTs { get; set; }
        /// <summary>
        /// WMI Property NumberOfDeployments
        /// </summary>
        public uint NumberOfDeployments { get; set; }
        /// <summary>
        /// WMI Property NumberOfDeploymentTypes
        /// </summary>
        public uint NumberOfDeploymentTypes { get; set; }
        /// <summary>
        /// WMI Property NumberOfDevicesWithApp
        /// </summary>
        public uint NumberOfDevicesWithApp { get; set; }
        /// <summary>
        /// WMI Property NumberOfDevicesWithFailure
        /// </summary>
        public uint NumberOfDevicesWithFailure { get; set; }
        /// <summary>
        /// WMI Property NumberOfSettings
        /// </summary>
        public uint NumberOfSettings { get; set; }
        /// <summary>
        /// WMI Property NumberOfUsersWithApp
        /// </summary>
        public uint NumberOfUsersWithApp { get; set; }
        /// <summary>
        /// WMI Property NumberOfUsersWithFailure
        /// </summary>
        public uint NumberOfUsersWithFailure { get; set; }
        /// <summary>
        /// WMI Property NumberOfUsersWithRequest
        /// </summary>
        public uint NumberOfUsersWithRequest { get; set; }
        /// <summary>
        /// WMI Property NumberOfVirtualEnvironments
        /// </summary>
        public uint NumberOfVirtualEnvironments { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PermittedUses
        /// </summary>
        public uint PermittedUses { get; set; }
        /// <summary>
        /// WMI Property PlatformCategoryInstance_UniqueIDs
        /// </summary>
        [WmiProperty(Name = "PlatformCategoryInstance_UniqueIDs")]
        public ICollection<string> PlatformCategoryInstanceUniqueIDs { get; set; }
        /// <summary>
        /// WMI Property PlatformType
        /// </summary>
        public uint PlatformType { get; set; }
        /// <summary>
        /// WMI Property SDMPackageLocalizedData
        /// </summary>
        public  ICollection<SmsSdmPackageLocalizedData> SdmPackageLocalizedData { get; set; }
        /// <summary>
        /// WMI Property SDMPackageVersion
        /// </summary>
        public uint SdmPackageVersion { get; set; }
        /// <summary>
        /// WMI Property SDMPackageXML
        /// </summary>
        public string SdmPackageXml { get; set; }
        /// <summary>
        /// WMI Property SecuredScopeNames
        /// </summary>
        public ICollection<string> SecuredScopeNames { get; set; }
        /// <summary>
        /// WMI Property SedoObjectVersion
        /// </summary>
        public string SedoObjectVersion { get; set; }
        /// <summary>
        /// WMI Property SoftwareVersion
        /// </summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// WMI Property SourceCIVersion
        /// </summary>
        public uint SourceCiVersion { get; set; }
        /// <summary>
        /// WMI Property SourceModelName
        /// </summary>
        public string SourceModelName { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
    }
}
