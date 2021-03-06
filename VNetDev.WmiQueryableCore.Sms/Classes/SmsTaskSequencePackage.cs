using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequencePackage
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequencePackage")]
    public class SmsTaskSequencePackage
    {
        /// <summary>
        /// WMI method <c>RefreshPkgSource</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshPkgSourceDelegate();
        /// <summary>
        /// WMI method <c>RefreshPkgSource</c>.
        /// </summary>
        public RefreshPkgSourceDelegate RefreshPkgSource;
        
        /// <summary>
        /// WMI static method <c>GetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNextIdDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetNextID</c>.
        /// </summary>
        public static GetNextIdDelegate GetNextId;
        
        /// <summary>
        /// WMI static method <c>SetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nextId">WMI Property <c>NextID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetNextIdDelegate(WmiContext wmiContext, uint nextId = default);
        /// <summary>
        /// WMI static method <c>SetNextID</c>.
        /// </summary>
        public static SetNextIdDelegate SetNextId;
        
        /// <summary>
        /// WMI method <c>Unlock</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UnlockDelegate();
        /// <summary>
        /// WMI method <c>Unlock</c>.
        /// </summary>
        public UnlockDelegate Unlock;
        
        /// <summary>
        /// WMI method <c>SetSourceSite</c> describing delegate.
        /// <param name="sourceSite">WMI Property <c>SourceSite</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetSourceSiteDelegate(string sourceSite = default);
        /// <summary>
        /// WMI method <c>SetSourceSite</c>.
        /// </summary>
        public SetSourceSiteDelegate SetSourceSite;
        
        /// <summary>
        /// WMI method <c>AddDistributionPoints</c> describing delegate.
        /// <param name="nalPath">WMI Property <c>NALPath</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddDistributionPointsDelegate(ICollection<string> nalPath = default, ICollection<string> siteCode = default);
        /// <summary>
        /// WMI method <c>AddDistributionPoints</c>.
        /// </summary>
        public AddDistributionPointsDelegate AddDistributionPoints;
        
        /// <summary>
        /// WMI method <c>AddChangeNotification</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddChangeNotificationDelegate();
        /// <summary>
        /// WMI method <c>AddChangeNotification</c>.
        /// </summary>
        public AddChangeNotificationDelegate AddChangeNotification;
        
        /// <summary>
        /// WMI static method <c>SetSequence</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskSequence">WMI Property <c>TaskSequence</c> of type <c>System.Object[]</c>.</param>
        /// <param name="taskSequencePackage">WMI Property <c>TaskSequencePackage</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetSequenceDelegate(WmiContext wmiContext,  SmsTaskSequence taskSequence = default,  SmsTaskSequencePackage taskSequencePackage = default);
        /// <summary>
        /// WMI static method <c>SetSequence</c>.
        /// </summary>
        public static SetSequenceDelegate SetSequence;
        
        /// <summary>
        /// WMI static method <c>GetSequence</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskSequencePackage">WMI Property <c>TaskSequencePackage</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSequenceDelegate(WmiContext wmiContext,  SmsTaskSequencePackage taskSequencePackage = default);
        /// <summary>
        /// WMI static method <c>GetSequence</c>.
        /// </summary>
        public static GetSequenceDelegate GetSequence;
        
        /// <summary>
        /// WMI static method <c>GetParentAndChildSequences</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskSequencePackage">WMI Property <c>TaskSequencePackage</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetParentAndChildSequencesDelegate(WmiContext wmiContext,  SmsTaskSequencePackage taskSequencePackage = default);
        /// <summary>
        /// WMI static method <c>GetParentAndChildSequences</c>.
        /// </summary>
        public static GetParentAndChildSequencesDelegate GetParentAndChildSequences;
        
        /// <summary>
        /// WMI static method <c>ImportSequence</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sequenceXml">WMI Property <c>SequenceXML</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportSequenceDelegate(WmiContext wmiContext, string sequenceXml = default);
        /// <summary>
        /// WMI static method <c>ImportSequence</c>.
        /// </summary>
        public static ImportSequenceDelegate ImportSequence;
        
        /// <summary>
        /// WMI static method <c>GetTsPolicies</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="advertisementComment">WMI Property <c>AdvertisementComment</c> of type <c>string</c>.</param>
        /// <param name="advertisementFlags">WMI Property <c>AdvertisementFlags</c> of type <c>uint</c>.</param>
        /// <param name="advertisementId">WMI Property <c>AdvertisementID</c> of type <c>string</c>.</param>
        /// <param name="advertisementName">WMI Property <c>AdvertisementName</c> of type <c>string</c>.</param>
        /// <param name="bootImageId">WMI Property <c>BootImageID</c> of type <c>string</c>.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <param name="sourceSite">WMI Property <c>SourceSite</c> of type <c>string</c>.</param>
        /// <param name="taskSequence">WMI Property <c>TaskSequence</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetTsPoliciesDelegate(WmiContext wmiContext, string advertisementComment = default, uint advertisementFlags = default, string advertisementId = default, string advertisementName = default, string bootImageId = default, string packageId = default, string sourceSite = default,  SmsTaskSequence taskSequence = default);
        /// <summary>
        /// WMI static method <c>GetTsPolicies</c>.
        /// </summary>
        public static GetTsPoliciesDelegate GetTsPolicies;
        
        /// <summary>
        /// WMI static method <c>GetTsPoliciesSaMedia</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="advertisementComment">WMI Property <c>AdvertisementComment</c> of type <c>string</c>.</param>
        /// <param name="advertisementFlags">WMI Property <c>AdvertisementFlags</c> of type <c>uint</c>.</param>
        /// <param name="advertisementId">WMI Property <c>AdvertisementID</c> of type <c>string</c>.</param>
        /// <param name="advertisementName">WMI Property <c>AdvertisementName</c> of type <c>string</c>.</param>
        /// <param name="bootImageId">WMI Property <c>BootImageID</c> of type <c>string</c>.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <param name="sourceSite">WMI Property <c>SourceSite</c> of type <c>string</c>.</param>
        /// <param name="taskSequence">WMI Property <c>TaskSequence</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetTsPoliciesSaMediaDelegate(WmiContext wmiContext, string advertisementComment = default, uint advertisementFlags = default, string advertisementId = default, string advertisementName = default, string bootImageId = default, string packageId = default, string sourceSite = default,  SmsTaskSequence taskSequence = default);
        /// <summary>
        /// WMI static method <c>GetTsPoliciesSaMedia</c>.
        /// </summary>
        public static GetTsPoliciesSaMediaDelegate GetTsPoliciesSaMedia;
        
        /// <summary>
        /// WMI static method <c>GetClientConfigPolicies</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientConfigPoliciesDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetClientConfigPolicies</c>.
        /// </summary>
        public static GetClientConfigPoliciesDelegate GetClientConfigPolicies;
        
        /// <summary>
        /// WMI static method <c>GetPackageDefaultHash</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <param name="sourceVersion">WMI Property <c>SourceVersion</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetPackageDefaultHashDelegate(WmiContext wmiContext, string packageId = default, uint sourceVersion = default);
        /// <summary>
        /// WMI static method <c>GetPackageDefaultHash</c>.
        /// </summary>
        public static GetPackageDefaultHashDelegate GetPackageDefaultHash;
        
        /// <summary>
        /// WMI static method <c>GetPackageHash</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <param name="sourceVersion">WMI Property <c>SourceVersion</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetPackageHashDelegate(WmiContext wmiContext, string packageId = default, uint sourceVersion = default);
        /// <summary>
        /// WMI static method <c>GetPackageHash</c>.
        /// </summary>
        public static GetPackageHashDelegate GetPackageHash;
        
        /// <summary>
        /// WMI static method <c>GetContentHash</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="contentId">WMI Property <c>ContentID</c> of type <c>uint</c>.</param>
        /// <param name="hashAlgId">WMI Property <c>HashAlgID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetContentHashDelegate(WmiContext wmiContext, uint contentId = default, uint hashAlgId = default);
        /// <summary>
        /// WMI static method <c>GetContentHash</c>.
        /// </summary>
        public static GetContentHashDelegate GetContentHash;
        
        /// <summary>
        /// WMI static method <c>GetTSRelatedToDriverCategory</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="categoryUniqueId">WMI Property <c>CategoryUniqueId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetTsRelatedToDriverCategoryDelegate(WmiContext wmiContext, string categoryUniqueId = default);
        /// <summary>
        /// WMI static method <c>GetTSRelatedToDriverCategory</c>.
        /// </summary>
        public static GetTsRelatedToDriverCategoryDelegate GetTsRelatedToDriverCategory;
        
        /// <summary>
        /// WMI static method <c>CheckReferencesShareType</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CheckReferencesShareTypeDelegate(WmiContext wmiContext, string packageId = default);
        /// <summary>
        /// WMI static method <c>CheckReferencesShareType</c>.
        /// </summary>
        public static CheckReferencesShareTypeDelegate CheckReferencesShareType;
        /// <summary>
        /// WMI Property ActionInProgress
        /// </summary>
        public uint ActionInProgress { get; set; }
        /// <summary>
        /// WMI Property AlternateContentProviders
        /// </summary>
        public string AlternateContentProviders { get; set; }
        /// <summary>
        /// WMI Property BaseBoardProductID
        /// </summary>
        public string BaseBoardProductId { get; set; }
        /// <summary>
        /// WMI Property BootImageID
        /// </summary>
        public string BootImageId { get; set; }
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// WMI Property CustomHighImpactHeadline
        /// </summary>
        public string CustomHighImpactHeadline { get; set; }
        /// <summary>
        /// WMI Property CustomHighImpactSet
        /// </summary>
        public uint CustomHighImpactSet { get; set; }
        /// <summary>
        /// WMI Property CustomHighImpactWarning
        /// </summary>
        public string CustomHighImpactWarning { get; set; }
        /// <summary>
        /// WMI Property CustomHighImpactWarningInstall
        /// </summary>
        public string CustomHighImpactWarningInstall { get; set; }
        /// <summary>
        /// WMI Property CustomHighImpactWarningTop
        /// </summary>
        public string CustomHighImpactWarningTop { get; set; }
        /// <summary>
        /// WMI Property CustomProgressMsg
        /// </summary>
        public string CustomProgressMsg { get; set; }
        /// <summary>
        /// WMI Property DependentProgram
        /// </summary>
        public string DependentProgram { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DriverManufacturer
        /// </summary>
        public string DriverManufacturer { get; set; }
        /// <summary>
        /// WMI Property DriverModel
        /// </summary>
        public string DriverModel { get; set; }
        /// <summary>
        /// WMI Property DriverOSVersion
        /// </summary>
        public string DriverOsVersion { get; set; }
        /// <summary>
        /// WMI Property DriverPkgVersion
        /// </summary>
        public string DriverPkgVersion { get; set; }
        /// <summary>
        /// WMI Property Duration
        /// </summary>
        public uint Duration { get; set; }
        /// <summary>
        /// WMI Property EstimatedDownloadSizeMB
        /// </summary>
        public uint EstimatedDownloadSizeMb { get; set; }
        /// <summary>
        /// WMI Property EstimatedRunTimeMinutes
        /// </summary>
        public uint EstimatedRunTimeMinutes { get; set; }
        /// <summary>
        /// WMI Property ExtendedData
        /// </summary>
        public ICollection<byte> ExtendedData { get; set; }
        /// <summary>
        /// WMI Property ExtendedDataSize
        /// </summary>
        public uint ExtendedDataSize { get; set; }
        /// <summary>
        /// WMI Property ForcedDisconnectDelay
        /// </summary>
        public uint ForcedDisconnectDelay { get; set; }
        /// <summary>
        /// WMI Property ForcedDisconnectEnabled
        /// </summary>
        public bool ForcedDisconnectEnabled { get; set; }
        /// <summary>
        /// WMI Property ForcedDisconnectNumRetries
        /// </summary>
        public uint ForcedDisconnectNumRetries { get; set; }
        /// <summary>
        /// WMI Property HighImpactTaskSequence
        /// </summary>
        public uint HighImpactTaskSequence { get; set; }
        /// <summary>
        /// WMI Property Icon
        /// </summary>
        public ICollection<byte> Icon { get; set; }
        /// <summary>
        /// WMI Property IconSize
        /// </summary>
        public uint IconSize { get; set; }
        /// <summary>
        /// WMI Property IgnoreAddressSchedule
        /// </summary>
        public bool IgnoreAddressSchedule { get; set; }
        /// <summary>
        /// WMI Property ISVData
        /// </summary>
        public ICollection<byte> IsvData { get; set; }
        /// <summary>
        /// WMI Property ISVDataSize
        /// </summary>
        public uint IsvDataSize { get; set; }
        /// <summary>
        /// WMI Property IsVersionCompatible
        /// </summary>
        public bool IsVersionCompatible { get; set; }
        /// <summary>
        /// WMI Property ISVString
        /// </summary>
        public string IsvString { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// WMI Property LastRefreshTime
        /// </summary>
        public DateTime LastRefreshTime { get; set; }
        /// <summary>
        /// WMI Property LocalizedCategoryInstanceNames
        /// </summary>
        public ICollection<string> LocalizedCategoryInstanceNames { get; set; }
        /// <summary>
        /// WMI Property LocalizedTaskSequenceDescription
        /// </summary>
        public string LocalizedTaskSequenceDescription { get; set; }
        /// <summary>
        /// WMI Property LocalizedTaskSequenceName
        /// </summary>
        public string LocalizedTaskSequenceName { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MIFFilename
        /// </summary>
        public string MifFilename { get; set; }
        /// <summary>
        /// WMI Property MIFName
        /// </summary>
        public string MifName { get; set; }
        /// <summary>
        /// WMI Property MIFPublisher
        /// </summary>
        public string MifPublisher { get; set; }
        /// <summary>
        /// WMI Property MIFVersion
        /// </summary>
        public string MifVersion { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumOfPrograms
        /// </summary>
        public uint NumOfPrograms { get; set; }
        /// <summary>
        /// WMI Property ObjectPath
        /// </summary>
        public string ObjectPath { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageSize
        /// </summary>
        public uint PackageSize { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property PkgFlags
        /// </summary>
        public uint PkgFlags { get; set; }
        /// <summary>
        /// WMI Property PkgSourceFlag
        /// </summary>
        public uint PkgSourceFlag { get; set; }
        /// <summary>
        /// WMI Property PkgSourcePath
        /// </summary>
        public string PkgSourcePath { get; set; }
        /// <summary>
        /// WMI Property PreDownloadRule
        /// </summary>
        public string PreDownloadRule { get; set; }
        /// <summary>
        /// WMI Property PreferredAddressType
        /// </summary>
        public string PreferredAddressType { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ProgramFlags
        /// </summary>
        public uint ProgramFlags { get; set; }
        /// <summary>
        /// WMI Property References
        /// </summary>
        public ICollection<object> References { get; set; }
        /// <summary>
        /// WMI Property ReferencesCount
        /// </summary>
        public uint ReferencesCount { get; set; }
        /// <summary>
        /// WMI Property RefreshPkgSourceFlag
        /// </summary>
        public bool RefreshPkgSourceFlag { get; set; }
        /// <summary>
        /// WMI Property RefreshSchedule
        /// </summary>
        public ICollection<object> RefreshSchedule { get; set; }
        /// <summary>
        /// WMI Property Reserved
        /// </summary>
        public string Reserved { get; set; }
        /// <summary>
        /// WMI Property RestartRequired
        /// </summary>
        public uint RestartRequired { get; set; }
        /// <summary>
        /// WMI Property SecuredScopeNames
        /// </summary>
        public ICollection<string> SecuredScopeNames { get; set; }
        /// <summary>
        /// WMI Property SedoObjectVersion
        /// </summary>
        public string SedoObjectVersion { get; set; }
        /// <summary>
        /// WMI Property Sequence
        /// </summary>
        public string Sequence { get; set; }
        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }
        /// <summary>
        /// WMI Property ShareType
        /// </summary>
        public uint ShareType { get; set; }
        /// <summary>
        /// WMI Property SourceDate
        /// </summary>
        public DateTime SourceDate { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property SourceVersion
        /// </summary>
        public uint SourceVersion { get; set; }
        /// <summary>
        /// WMI Property StoredPkgPath
        /// </summary>
        public string StoredPkgPath { get; set; }
        /// <summary>
        /// WMI Property StoredPkgVersion
        /// </summary>
        public uint StoredPkgVersion { get; set; }
        /// <summary>
        /// WMI Property SupportedOperatingSystems
        /// </summary>
        public ICollection<object> SupportedOperatingSystems { get; set; }
        /// <summary>
        /// WMI Property TaskSequenceFlags
        /// </summary>
        public uint TaskSequenceFlags { get; set; }
        /// <summary>
        /// WMI Property TsEnabled
        /// </summary>
        public bool TsEnabled { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
