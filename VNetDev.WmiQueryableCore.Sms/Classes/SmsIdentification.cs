using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Identification
    /// </summary>
    [WmiClass(Name = "SMS_Identification")]
    public class SmsIdentification
    {
        /// <summary>
        /// WMI static method <c>GetCurrentUser</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetCurrentUserDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetCurrentUser</c>.
        /// </summary>
        public static GetCurrentUserDelegate GetCurrentUser;
        
        /// <summary>
        /// WMI static method <c>GetProviderVersion</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetProviderVersionDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetProviderVersion</c>.
        /// </summary>
        public static GetProviderVersionDelegate GetProviderVersion;
        
        /// <summary>
        /// WMI static method <c>GetSiteID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSiteIdDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSiteID</c>.
        /// </summary>
        public static GetSiteIdDelegate GetSiteId;
        
        /// <summary>
        /// WMI static method <c>GetFileBinary</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="blockNumber">WMI Property <c>blockNumber</c> of type <c>uint</c>.</param>
        /// <param name="fileName">WMI Property <c>FileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetFileBinaryDelegate(WmiContext wmiContext, uint blockNumber = default, string fileName = default);
        /// <summary>
        /// WMI static method <c>GetFileBinary</c>.
        /// </summary>
        public static GetFileBinaryDelegate GetFileBinary;
        
        /// <summary>
        /// WMI static method <c>IsCurrentBranch</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsCurrentBranchDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>IsCurrentBranch</c>.
        /// </summary>
        public static IsCurrentBranchDelegate IsCurrentBranch;
        
        /// <summary>
        /// WMI static method <c>GetSiteType</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSiteTypeDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSiteType</c>.
        /// </summary>
        public static GetSiteTypeDelegate GetSiteType;
        /// <summary>
        /// WMI Property License
        /// </summary>
        public uint License { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property MonthlyReleaseVersion
        /// </summary>
        public uint MonthlyReleaseVersion { get; set; }
        /// <summary>
        /// WMI Property Reserved
        /// </summary>
        public uint Reserved { get; set; }
        /// <summary>
        /// WMI Property ServiceAccountName
        /// </summary>
        public string ServiceAccountName { get; set; }
        /// <summary>
        /// WMI Property SMSAvailableConsoleVersion
        /// </summary>
        public string SmsAvailableConsoleVersion { get; set; }
        /// <summary>
        /// WMI Property SMSBuildNumber
        /// </summary>
        public uint SmsBuildNumber { get; set; }
        /// <summary>
        /// WMI Property SMSMinBuildNumber
        /// </summary>
        public uint SmsMinBuildNumber { get; set; }
        /// <summary>
        /// WMI Property SMSProviderServer
        /// </summary>
        public string SmsProviderServer { get; set; }
        /// <summary>
        /// WMI Property SMSSiteServer
        /// </summary>
        public string SmsSiteServer { get; set; }
        /// <summary>
        /// WMI Property SMSVersion
        /// </summary>
        public string SmsVersion { get; set; }
        /// <summary>
        /// WMI Property SupportID
        /// </summary>
        public string SupportId { get; set; }
        /// <summary>
        /// WMI Property ThisSiteCode
        /// </summary>
        public string ThisSiteCode { get; set; }
        /// <summary>
        /// WMI Property ThisSiteName
        /// </summary>
        public string ThisSiteName { get; set; }
        /// <summary>
        /// WMI Property UIManifestHash
        /// </summary>
        public string UiManifestHash { get; set; }
        /// <summary>
        /// WMI Property UIManifestHashAlgorithm
        /// </summary>
        public string UiManifestHashAlgorithm { get; set; }
        /// <summary>
        /// WMI Property UIUpdateManifestHash
        /// </summary>
        public string UiUpdateManifestHash { get; set; }
        /// <summary>
        /// WMI Property UIUpdateManifestHashAlgorithm
        /// </summary>
        public string UiUpdateManifestHashAlgorithm { get; set; }
    }
}
