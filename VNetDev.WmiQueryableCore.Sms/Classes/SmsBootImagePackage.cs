using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BootImagePackage
    /// </summary>
    [WmiClass(Name = "SMS_BootImagePackage")]
    public class SmsBootImagePackage
    {
        /// <summary>
        /// WMI method <c>RefreshPkgSource</c> describing delegate.
        /// <param name="contextId">WMI Property <c>ContextID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshPkgSourceDelegate(string contextId = default);
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
        /// WMI method <c>ReloadImageProperties</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReloadImagePropertiesDelegate();
        /// <summary>
        /// WMI method <c>ReloadImageProperties</c>.
        /// </summary>
        public ReloadImagePropertiesDelegate ReloadImageProperties;
        
        /// <summary>
        /// WMI method <c>ReloadWinPeFromAdk</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReloadWinPeFromAdkDelegate();
        /// <summary>
        /// WMI method <c>ReloadWinPeFromAdk</c>.
        /// </summary>
        public ReloadWinPeFromAdkDelegate ReloadWinPeFromAdk;
        
        /// <summary>
        /// WMI static method <c>GetImageProperties</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sourceImagePath">WMI Property <c>SourceImagePath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetImagePropertiesDelegate(WmiContext wmiContext, string sourceImagePath = default);
        /// <summary>
        /// WMI static method <c>GetImageProperties</c>.
        /// </summary>
        public static GetImagePropertiesDelegate GetImageProperties;
        
        /// <summary>
        /// WMI static method <c>ExportSingleIndexImage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="exportedImagePath">WMI Property <c>ExportedImagePath</c> of type <c>string</c>.</param>
        /// <param name="imageIndex">WMI Property <c>ImageIndex</c> of type <c>uint</c>.</param>
        /// <param name="sourceImagePath">WMI Property <c>SourceImagePath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ExportSingleIndexImageDelegate(WmiContext wmiContext, string exportedImagePath = default, uint imageIndex = default, string sourceImagePath = default);
        /// <summary>
        /// WMI static method <c>ExportSingleIndexImage</c>.
        /// </summary>
        public static ExportSingleIndexImageDelegate ExportSingleIndexImage;
        
        /// <summary>
        /// WMI static method <c>ConvertToSingleIndexImage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="imageIndex">WMI Property <c>ImageIndex</c> of type <c>uint</c>.</param>
        /// <param name="sourceImagePath">WMI Property <c>SourceImagePath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ConvertToSingleIndexImageDelegate(WmiContext wmiContext, uint imageIndex = default, string sourceImagePath = default);
        /// <summary>
        /// WMI static method <c>ConvertToSingleIndexImage</c>.
        /// </summary>
        public static ConvertToSingleIndexImageDelegate ConvertToSingleIndexImage;
        
        /// <summary>
        /// WMI static method <c>QueryOSDBinaryInjectionStatus</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="contextId">WMI Property <c>ContextID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint QueryOsdBinaryInjectionStatusDelegate(WmiContext wmiContext, string contextId = default);
        /// <summary>
        /// WMI static method <c>QueryOSDBinaryInjectionStatus</c>.
        /// </summary>
        public static QueryOsdBinaryInjectionStatusDelegate QueryOsdBinaryInjectionStatus;
        
        /// <summary>
        /// WMI static method <c>DeleteContextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="contextId">WMI Property <c>ContextID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteContextIdDelegate(WmiContext wmiContext, string contextId = default);
        /// <summary>
        /// WMI static method <c>DeleteContextID</c>.
        /// </summary>
        public static DeleteContextIdDelegate DeleteContextId;
        
        /// <summary>
        /// WMI static method <c>UpdateImage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateImageDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>UpdateImage</c>.
        /// </summary>
        public static UpdateImageDelegate UpdateImage;
        
        /// <summary>
        /// WMI static method <c>UpdateDefaultImage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateDefaultImageDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>UpdateDefaultImage</c>.
        /// </summary>
        public static UpdateDefaultImageDelegate UpdateDefaultImage;
        
        /// <summary>
        /// WMI static method <c>ExportDefaultBootImage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="architecture">WMI Property <c>Architecture</c> of type <c>string</c>.</param>
        /// <param name="exportImagePath">WMI Property <c>ExportImagePath</c> of type <c>string</c>.</param>
        /// <param name="imageIndex">WMI Property <c>ImageIndex</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ExportDefaultBootImageDelegate(WmiContext wmiContext, string architecture = default, string exportImagePath = default, uint imageIndex = default);
        /// <summary>
        /// WMI static method <c>ExportDefaultBootImage</c>.
        /// </summary>
        public static ExportDefaultBootImageDelegate ExportDefaultBootImage;
        
        /// <summary>
        /// WMI method <c>UpdateOptionalComponents</c> describing delegate.
        /// <param name="componentIds">WMI Property <c>ComponentIds</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateOptionalComponentsDelegate(ICollection<string> componentIds = default);
        /// <summary>
        /// WMI method <c>UpdateOptionalComponents</c>.
        /// </summary>
        public UpdateOptionalComponentsDelegate UpdateOptionalComponents;
        /// <summary>
        /// WMI Property ActionInProgress
        /// </summary>
        public uint ActionInProgress { get; set; }
        /// <summary>
        /// WMI Property AlternateContentProviders
        /// </summary>
        public string AlternateContentProviders { get; set; }
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property BackgroundBitmapPath
        /// </summary>
        public string BackgroundBitmapPath { get; set; }
        /// <summary>
        /// WMI Property BaseBoardProductID
        /// </summary>
        public string BaseBoardProductId { get; set; }
        /// <summary>
        /// WMI Property ContextID
        /// </summary>
        public string ContextId { get; set; }
        /// <summary>
        /// WMI Property DefaultImage
        /// </summary>
        public bool DefaultImage { get; set; }
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
        /// WMI Property EnableLabShell
        /// </summary>
        public bool EnableLabShell { get; set; }
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
        /// WMI Property ImageDiskLayout
        /// </summary>
        public string ImageDiskLayout { get; set; }
        /// <summary>
        /// WMI Property ImageIndex
        /// </summary>
        public uint ImageIndex { get; set; }
        /// <summary>
        /// WMI Property ImageOSVersion
        /// </summary>
        public string ImageOsVersion { get; set; }
        /// <summary>
        /// WMI Property ImagePath
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// WMI Property ImageProperty
        /// </summary>
        public string ImageProperty { get; set; }
        /// <summary>
        /// WMI Property InputLocale
        /// </summary>
        public string InputLocale { get; set; }
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
        /// WMI Property OptionalComponents
        /// </summary>
        public ICollection<uint> OptionalComponents { get; set; }
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
        /// WMI Property PreExecCommandLine
        /// </summary>
        public string PreExecCommandLine { get; set; }
        /// <summary>
        /// WMI Property PreExecSourceDirectory
        /// </summary>
        public string PreExecSourceDirectory { get; set; }
        /// <summary>
        /// WMI Property PreferredAddressType
        /// </summary>
        public string PreferredAddressType { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ProductionClientVersion
        /// </summary>
        public string ProductionClientVersion { get; set; }
        /// <summary>
        /// WMI Property ReferencedDrivers
        /// </summary>
        public ICollection<SmsDriverDetails> ReferencedDrivers { get; set; }
        /// <summary>
        /// WMI Property RefreshPkgSourceFlag
        /// </summary>
        public bool RefreshPkgSourceFlag { get; set; }
        /// <summary>
        /// WMI Property RefreshSchedule
        /// </summary>
        public ICollection<SmsScheduleToken> RefreshSchedule { get; set; }
        /// <summary>
        /// WMI Property ScratchSpace
        /// </summary>
        public uint ScratchSpace { get; set; }
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
