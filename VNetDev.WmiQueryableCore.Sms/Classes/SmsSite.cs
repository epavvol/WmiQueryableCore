using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Site
    /// </summary>
    [WmiClass(Name = "SMS_Site")]
    public class SmsSite
    {
        /// <summary>
        /// WMI static method <c>SetContentLibraryLocation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="location">WMI Property <c>Location</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetContentLibraryLocationDelegate(WmiContext wmiContext, string location = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>SetContentLibraryLocation</c>.
        /// </summary>
        public static SetContentLibraryLocationDelegate SetContentLibraryLocation;
        
        /// <summary>
        /// WMI static method <c>VerifyNoLoops</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="centralSiteCode">WMI Property <c>CentralSiteCode</c> of type <c>string</c>.</param>
        /// <param name="parentSiteCode">WMI Property <c>ParentSiteCode</c> of type <c>string</c>.</param>
        /// <param name="targetSiteCode">WMI Property <c>TargetSiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint VerifyNoLoopsDelegate(WmiContext wmiContext, string centralSiteCode = default, string parentSiteCode = default, string targetSiteCode = default);
        /// <summary>
        /// WMI static method <c>VerifyNoLoops</c>.
        /// </summary>
        public static VerifyNoLoopsDelegate VerifyNoLoops;
        
        /// <summary>
        /// WMI static method <c>ImportMachineEntry</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="addToCollection">WMI Property <c>AddToCollection</c> of type <c>bool</c>.</param>
        /// <param name="adminPassword">WMI Property <c>AdminPassword</c> of type <c>string</c>.</param>
        /// <param name="collectionId">WMI Property <c>CollectionId</c> of type <c>string</c>.</param>
        /// <param name="collectionRule">WMI Property <c>CollectionRule</c> of type <c>System.Object[]</c>.</param>
        /// <param name="fqdn">WMI Property <c>FQDN</c> of type <c>string</c>.</param>
        /// <param name="isAmtMachine">WMI Property <c>IsAMTMachine</c> of type <c>bool</c>.</param>
        /// <param name="macAddress">WMI Property <c>MACAddress</c> of type <c>string</c>.</param>
        /// <param name="meBxPassword">WMI Property <c>MEBxPassword</c> of type <c>string</c>.</param>
        /// <param name="netbiosName">WMI Property <c>NetbiosName</c> of type <c>string</c>.</param>
        /// <param name="overwriteExistingRecord">WMI Property <c>OverwriteExistingRecord</c> of type <c>bool</c>.</param>
        /// <param name="smbiosguid">WMI Property <c>SMBIOSGUID</c> of type <c>string</c>.</param>
        /// <param name="wtgUniqueKey">WMI Property <c>WTGUniqueKey</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportMachineEntryDelegate(WmiContext wmiContext, bool addToCollection = default, string adminPassword = default, string collectionId = default,  SmsCollectionRule collectionRule = default, string fqdn = default, bool isAmtMachine = default, string macAddress = default, string meBxPassword = default, string netbiosName = default, bool overwriteExistingRecord = default, string smbiosguid = default, string wtgUniqueKey = default);
        /// <summary>
        /// WMI static method <c>ImportMachineEntry</c>.
        /// </summary>
        public static ImportMachineEntryDelegate ImportMachineEntry;
        
        /// <summary>
        /// WMI static method <c>ImportMachineEntryToMultipleCollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="addToCollection">WMI Property <c>AddToCollection</c> of type <c>bool</c>.</param>
        /// <param name="adminPassword">WMI Property <c>AdminPassword</c> of type <c>string</c>.</param>
        /// <param name="collectionIds">WMI Property <c>CollectionIds</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="collectionRule">WMI Property <c>CollectionRule</c> of type <c>System.Object[]</c>.</param>
        /// <param name="fqdn">WMI Property <c>FQDN</c> of type <c>string</c>.</param>
        /// <param name="isAmtMachine">WMI Property <c>IsAMTMachine</c> of type <c>bool</c>.</param>
        /// <param name="macAddress">WMI Property <c>MACAddress</c> of type <c>string</c>.</param>
        /// <param name="meBxPassword">WMI Property <c>MEBxPassword</c> of type <c>string</c>.</param>
        /// <param name="netbiosName">WMI Property <c>NetbiosName</c> of type <c>string</c>.</param>
        /// <param name="overwriteExistingRecord">WMI Property <c>OverwriteExistingRecord</c> of type <c>bool</c>.</param>
        /// <param name="smbiosguid">WMI Property <c>SMBIOSGUID</c> of type <c>string</c>.</param>
        /// <param name="wtgUniqueKey">WMI Property <c>WTGUniqueKey</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportMachineEntryToMultipleCollectionsDelegate(WmiContext wmiContext, bool addToCollection = default, string adminPassword = default, ICollection<string> collectionIds = default,  SmsCollectionRule collectionRule = default, string fqdn = default, bool isAmtMachine = default, string macAddress = default, string meBxPassword = default, string netbiosName = default, bool overwriteExistingRecord = default, string smbiosguid = default, string wtgUniqueKey = default);
        /// <summary>
        /// WMI static method <c>ImportMachineEntryToMultipleCollections</c>.
        /// </summary>
        public static ImportMachineEntryToMultipleCollectionsDelegate ImportMachineEntryToMultipleCollections;
        
        /// <summary>
        /// WMI static method <c>SubmitRegistrationRecord</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certificate">WMI Property <c>Certificate</c> of type <c>string</c>.</param>
        /// <param name="certificatePfx">WMI Property <c>CertificatePFX</c> of type <c>string</c>.</param>
        /// <param name="issuedCert">WMI Property <c>IssuedCert</c> of type <c>int</c>.</param>
        /// <param name="serverName">WMI Property <c>ServerName</c> of type <c>string</c>.</param>
        /// <param name="smsid">WMI Property <c>SMSID</c> of type <c>string</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>int</c>.</param>
        /// <param name="udaSetting">WMI Property <c>UdaSetting</c> of type <c>int</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SubmitRegistrationRecordDelegate(WmiContext wmiContext, string certificate = default, string certificatePfx = default, int issuedCert = default, string serverName = default, string smsid = default, int type = default, int udaSetting = default);
        /// <summary>
        /// WMI static method <c>SubmitRegistrationRecord</c>.
        /// </summary>
        public static SubmitRegistrationRecordDelegate SubmitRegistrationRecord;
        
        /// <summary>
        /// WMI static method <c>IsUsedCert</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certificate">WMI Property <c>Certificate</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool IsUsedCertDelegate(WmiContext wmiContext, string certificate = default);
        /// <summary>
        /// WMI static method <c>IsUsedCert</c>.
        /// </summary>
        public static IsUsedCertDelegate IsUsedCert;
        
        /// <summary>
        /// WMI static method <c>GetClientInfo</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientInfoDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetClientInfo</c>.
        /// </summary>
        public static GetClientInfoDelegate GetClientInfo;
        
        /// <summary>
        /// WMI static method <c>SubmitAMTCert</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certificate">WMI Property <c>Certificate</c> of type <c>string</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>int</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SubmitAmtCertDelegate(WmiContext wmiContext, string certificate = default, string password = default, string siteCode = default, int type = default);
        /// <summary>
        /// WMI static method <c>SubmitAMTCert</c>.
        /// </summary>
        public static SubmitAmtCertDelegate SubmitAmtCert;
        
        /// <summary>
        /// WMI static method <c>GetSiteADInfo</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSiteAdInfoDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>GetSiteADInfo</c>.
        /// </summary>
        public static GetSiteAdInfoDelegate GetSiteAdInfo;
        
        /// <summary>
        /// WMI static method <c>ImportGlobalUserAccountEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportGlobalUserAccountExDelegate(WmiContext wmiContext, string password = default, string userName = default);
        /// <summary>
        /// WMI static method <c>ImportGlobalUserAccountEx</c>.
        /// </summary>
        public static ImportGlobalUserAccountExDelegate ImportGlobalUserAccountEx;
        
        /// <summary>
        /// WMI static method <c>ImportGlobalUserAccount</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>ICollection{byte}</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportGlobalUserAccountDelegate(WmiContext wmiContext, ICollection<byte> password = default, string userName = default);
        /// <summary>
        /// WMI static method <c>ImportGlobalUserAccount</c>.
        /// </summary>
        public static ImportGlobalUserAccountDelegate ImportGlobalUserAccount;
        
        /// <summary>
        /// WMI static method <c>EncryptDataEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="data">WMI Property <c>Data</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint EncryptDataExDelegate(WmiContext wmiContext, string data = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>EncryptDataEx</c>.
        /// </summary>
        public static EncryptDataExDelegate EncryptDataEx;
        
        /// <summary>
        /// WMI static method <c>EncryptData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="data">WMI Property <c>Data</c> of type <c>ICollection{byte}</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint EncryptDataDelegate(WmiContext wmiContext, ICollection<byte> data = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>EncryptData</c>.
        /// </summary>
        public static EncryptDataDelegate EncryptData;
        
        /// <summary>
        /// WMI static method <c>GetFeatureState</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="featureId">WMI Property <c>FeatureID</c> of type <c>uint</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetFeatureStateDelegate(WmiContext wmiContext, uint featureId = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>GetFeatureState</c>.
        /// </summary>
        public static GetFeatureStateDelegate GetFeatureState;
        
        /// <summary>
        /// WMI static method <c>UpdateFeatureState</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="featureId">WMI Property <c>FeatureID</c> of type <c>uint</c>.</param>
        /// <param name="isEnabled">WMI Property <c>IsEnabled</c> of type <c>bool</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateFeatureStateDelegate(WmiContext wmiContext, uint featureId = default, bool isEnabled = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>UpdateFeatureState</c>.
        /// </summary>
        public static UpdateFeatureStateDelegate UpdateFeatureState;
        
        /// <summary>
        /// WMI static method <c>GetAutoUpgradeConfigs</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetAutoUpgradeConfigsDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetAutoUpgradeConfigs</c>.
        /// </summary>
        public static GetAutoUpgradeConfigsDelegate GetAutoUpgradeConfigs;
        
        /// <summary>
        /// WMI static method <c>UpdateAutoUpgradeConfigs</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="advertisementDuration">WMI Property <c>AdvertisementDuration</c> of type <c>uint</c>.</param>
        /// <param name="allowFallbackToContentSource">WMI Property <c>AllowFallbackToContentSource</c> of type <c>bool</c>.</param>
        /// <param name="allowPrestage">WMI Property <c>AllowPrestage</c> of type <c>bool</c>.</param>
        /// <param name="clientVersion">WMI Property <c>ClientVersion</c> of type <c>string</c>.</param>
        /// <param name="downloadOptionInSlowNetwork">WMI Property <c>DownloadOptionInSlowNetwork</c> of type <c>uint</c>.</param>
        /// <param name="excludedCollectionId">WMI Property <c>ExcludedCollectionID</c> of type <c>string</c>.</param>
        /// <param name="excludeServers">WMI Property <c>ExcludeServers</c> of type <c>bool</c>.</param>
        /// <param name="ignoreNonPersistableVm">WMI Property <c>IgnoreNonPersistableVM</c> of type <c>bool</c>.</param>
        /// <param name="isProgramEnabled">WMI Property <c>IsProgramEnabled</c> of type <c>bool</c>.</param>
        /// <param name="isUpgradeExclusionEnabled">WMI Property <c>IsUpgradeExclusionEnabled</c> of type <c>bool</c>.</param>
        /// <param name="overrideServiceWindow">WMI Property <c>OverrideServiceWindow</c> of type <c>bool</c>.</param>
        /// <param name="validationFailureInterval">WMI Property <c>ValidationFailureInterval</c> of type <c>uint</c>.</param>
        /// <param name="validationInterval">WMI Property <c>ValidationInterval</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateAutoUpgradeConfigsDelegate(WmiContext wmiContext, uint advertisementDuration = default, bool allowFallbackToContentSource = default, bool allowPrestage = default, string clientVersion = default, uint downloadOptionInSlowNetwork = default, string excludedCollectionId = default, bool excludeServers = default, bool ignoreNonPersistableVm = default, bool isProgramEnabled = default, bool isUpgradeExclusionEnabled = default, bool overrideServiceWindow = default, uint validationFailureInterval = default, uint validationInterval = default);
        /// <summary>
        /// WMI static method <c>UpdateAutoUpgradeConfigs</c>.
        /// </summary>
        public static UpdateAutoUpgradeConfigsDelegate UpdateAutoUpgradeConfigs;
        
        /// <summary>
        /// WMI static method <c>UpdateAutoUpgradeClientContent</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateAutoUpgradeClientContentDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>UpdateAutoUpgradeClientContent</c>.
        /// </summary>
        public static UpdateAutoUpgradeClientContentDelegate UpdateAutoUpgradeClientContent;
        
        /// <summary>
        /// WMI static method <c>RedistributeAutoUpgradeClientContent</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="dpnalPath">WMI Property <c>DPNALPath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RedistributeAutoUpgradeClientContentDelegate(WmiContext wmiContext, string dpnalPath = default);
        /// <summary>
        /// WMI static method <c>RedistributeAutoUpgradeClientContent</c>.
        /// </summary>
        public static RedistributeAutoUpgradeClientContentDelegate RedistributeAutoUpgradeClientContent;
        
        /// <summary>
        /// WMI static method <c>GetClientPilotingConfigs</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientPilotingConfigsDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetClientPilotingConfigs</c>.
        /// </summary>
        public static GetClientPilotingConfigsDelegate GetClientPilotingConfigs;
        
        /// <summary>
        /// WMI static method <c>UpdateClientPilotingConfigs</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="isAccepted">WMI Property <c>IsAccepted</c> of type <c>bool</c>.</param>
        /// <param name="isEnabled">WMI Property <c>IsEnabled</c> of type <c>bool</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateClientPilotingConfigsDelegate(WmiContext wmiContext, bool isAccepted = default, bool isEnabled = default, string targetCollectionId = default);
        /// <summary>
        /// WMI static method <c>UpdateClientPilotingConfigs</c>.
        /// </summary>
        public static UpdateClientPilotingConfigsDelegate UpdateClientPilotingConfigs;
        
        /// <summary>
        /// WMI static method <c>UpdateConsoleUsageData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="consoleUsageData">WMI Property <c>ConsoleUsageData</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateConsoleUsageDataDelegate(WmiContext wmiContext,  SmsConsoleUsageData consoleUsageData = default);
        /// <summary>
        /// WMI static method <c>UpdateConsoleUsageData</c>.
        /// </summary>
        public static UpdateConsoleUsageDataDelegate UpdateConsoleUsageData;
        
        /// <summary>
        /// WMI static method <c>SendAdminConsoleUsage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="adminConsoleUsageXml">WMI Property <c>AdminConsoleUsageXml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SendAdminConsoleUsageDelegate(WmiContext wmiContext, string adminConsoleUsageXml = default);
        /// <summary>
        /// WMI static method <c>SendAdminConsoleUsage</c>.
        /// </summary>
        public static SendAdminConsoleUsageDelegate SendAdminConsoleUsage;
        
        /// <summary>
        /// WMI static method <c>SendConsoleCrashInfo</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="consoleCrashInfoXml">WMI Property <c>ConsoleCrashInfoXml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SendConsoleCrashInfoDelegate(WmiContext wmiContext, string consoleCrashInfoXml = default);
        /// <summary>
        /// WMI static method <c>SendConsoleCrashInfo</c>.
        /// </summary>
        public static SendConsoleCrashInfoDelegate SendConsoleCrashInfo;
        
        /// <summary>
        /// WMI static method <c>SetAuthenticationLevel</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="authenticationLevel">WMI Property <c>AuthenticationLevel</c> of type <c>uint</c>.</param>
        /// <param name="exceptionList">WMI Property <c>ExceptionList</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetAuthenticationLevelDelegate(WmiContext wmiContext, uint authenticationLevel = default, ICollection<string> exceptionList = default);
        /// <summary>
        /// WMI static method <c>SetAuthenticationLevel</c>.
        /// </summary>
        public static SetAuthenticationLevelDelegate SetAuthenticationLevel;
        
        /// <summary>
        /// WMI static method <c>PromoteToActive</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="serverFqdn">WMI Property <c>ServerFQDN</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint PromoteToActiveDelegate(WmiContext wmiContext, string serverFqdn = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>PromoteToActive</c>.
        /// </summary>
        public static PromoteToActiveDelegate PromoteToActive;
        
        /// <summary>
        /// WMI static method <c>RunPrereqCheck</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RunPrereqCheckDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>RunPrereqCheck</c>.
        /// </summary>
        public static RunPrereqCheckDelegate RunPrereqCheck;
        
        /// <summary>
        /// WMI static method <c>IsBitLockerCertDeployed</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsBitLockerCertDeployedDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>IsBitLockerCertDeployed</c>.
        /// </summary>
        public static IsBitLockerCertDeployedDelegate IsBitLockerCertDeployed;
        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public uint BuildNumber { get; set; }
        /// <summary>
        /// WMI Property ContentLibraryLocation
        /// </summary>
        public string ContentLibraryLocation { get; set; }
        /// <summary>
        /// WMI Property ContentLibraryMoveProgress
        /// </summary>
        public uint ContentLibraryMoveProgress { get; set; }
        /// <summary>
        /// WMI Property ContentLibraryStatus
        /// </summary>
        public uint ContentLibraryStatus { get; set; }
        /// <summary>
        /// WMI Property Features
        /// </summary>
        public string Features { get; set; }
        /// <summary>
        /// WMI Property InstallDir
        /// </summary>
        public string InstallDir { get; set; }
        /// <summary>
        /// WMI Property Mode
        /// </summary>
        public uint Mode { get; set; }
        /// <summary>
        /// WMI Property ReportingSiteCode
        /// </summary>
        public string ReportingSiteCode { get; set; }
        /// <summary>
        /// WMI Property RequestedStatus
        /// </summary>
        public uint RequestedStatus { get; set; }
        /// <summary>
        /// WMI Property SecondarySiteCMUpdateStatus
        /// </summary>
        public uint SecondarySiteCmUpdateStatus { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TimeZoneInfo
        /// </summary>
        public string TimeZoneInfo { get; set; }
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
