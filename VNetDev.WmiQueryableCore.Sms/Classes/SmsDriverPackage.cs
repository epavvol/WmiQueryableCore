using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DriverPackage
    /// </summary>
    [WmiClass(Name = "SMS_DriverPackage")]
    public class SmsDriverPackage
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
        /// WMI method <c>AddDriverContent</c> describing delegate.
        /// <param name="bRefreshDPs">WMI Property <c>bRefreshDPs</c> of type <c>bool</c>.</param>
        /// <param name="contentIDs">WMI Property <c>ContentIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="contentSourcePath">WMI Property <c>ContentSourcePath</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddDriverContentDelegate(bool bRefreshDPs = default, ICollection<uint> contentIDs = default, ICollection<string> contentSourcePath = default);
        /// <summary>
        /// WMI method <c>AddDriverContent</c>.
        /// </summary>
        public AddDriverContentDelegate AddDriverContent;
        
        /// <summary>
        /// WMI method <c>ValidateNewPackageSource</c> describing delegate.
        /// <param name="packageSource">WMI Property <c>PackageSource</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ValidateNewPackageSourceDelegate(string packageSource = default);
        /// <summary>
        /// WMI method <c>ValidateNewPackageSource</c>.
        /// </summary>
        public ValidateNewPackageSourceDelegate ValidateNewPackageSource;
        
        /// <summary>
        /// WMI method <c>RemoveDriverContent</c> describing delegate.
        /// <param name="bRefreshDPs">WMI Property <c>bRefreshDPs</c> of type <c>bool</c>.</param>
        /// <param name="contentIDs">WMI Property <c>ContentIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveDriverContentDelegate(bool bRefreshDPs = default, ICollection<uint> contentIDs = default);
        /// <summary>
        /// WMI method <c>RemoveDriverContent</c>.
        /// </summary>
        public RemoveDriverContentDelegate RemoveDriverContent;
        
        /// <summary>
        /// WMI method <c>RebuildPackage</c> describing delegate.
        /// <param name="contentSourcePath">WMI Property <c>ContentSourcePath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RebuildPackageDelegate(string contentSourcePath = default);
        /// <summary>
        /// WMI method <c>RebuildPackage</c>.
        /// </summary>
        public RebuildPackageDelegate RebuildPackage;
        
        /// <summary>
        /// WMI static method <c>CheckSourceFolder</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sourceFolder">WMI Property <c>SourceFolder</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CheckSourceFolderDelegate(WmiContext wmiContext, string sourceFolder = default);
        /// <summary>
        /// WMI static method <c>CheckSourceFolder</c>.
        /// </summary>
        public static CheckSourceFolderDelegate CheckSourceFolder;
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
        /// WMI Property RefreshPkgSourceFlag
        /// </summary>
        public bool RefreshPkgSourceFlag { get; set; }
        /// <summary>
        /// WMI Property RefreshSchedule
        /// </summary>
        public ICollection<object> RefreshSchedule { get; set; }
        /// <summary>
        /// WMI Property SecuredScopeNames
        /// </summary>
        public ICollection<string> SecuredScopeNames { get; set; }
        /// <summary>
        /// WMI Property SedoObjectVersion
        /// </summary>
        public string SedoObjectVersion { get; set; }
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
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
