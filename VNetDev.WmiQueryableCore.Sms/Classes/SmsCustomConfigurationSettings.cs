using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CustomConfigurationSettings
    /// </summary>
    [WmiClass(Name = "SMS_CustomConfigurationSettings")]
    public class SmsCustomConfigurationSettings
    {
        /// <summary>
        /// WMI method <c>AcceptEULA</c> describing delegate.
        /// <param name="accepted">WMI Property <c>Accepted</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AcceptEulaDelegate(bool accepted = default);
        /// <summary>
        /// WMI method <c>AcceptEULA</c>.
        /// </summary>
        public AcceptEulaDelegate AcceptEula;
        
        /// <summary>
        /// WMI method <c>GetEULA</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetEulaDelegate();
        /// <summary>
        /// WMI method <c>GetEULA</c>.
        /// </summary>
        public GetEulaDelegate GetEula;
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
        /// WMI Property IsBroken
        /// </summary>
        public bool IsBroken { get; set; }
        /// <summary>
        /// WMI Property IsBundle
        /// </summary>
        public bool IsBundle { get; set; }
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
        /// WMI Property LocalizedEulas
        /// </summary>
        public  ICollection<SmsCiLocalizedEulas> LocalizedEulas { get; set; }
        /// <summary>
        /// WMI Property LocalizedInformation
        /// </summary>
        public  ICollection<SmsCiLocalizedProperties> LocalizedInformation { get; set; }
        /// <summary>
        /// WMI Property LocalizedInformativeURL
        /// </summary>
        public string LocalizedInformativeUrl { get; set; }
        /// <summary>
        /// WMI Property LocalizedPropertyLocaleID
        /// </summary>
        public uint LocalizedPropertyLocaleId { get; set; }
        /// <summary>
        /// WMI Property ModelID
        /// </summary>
        public uint ModelId { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
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
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
