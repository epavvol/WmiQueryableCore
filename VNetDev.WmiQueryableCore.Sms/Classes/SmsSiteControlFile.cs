using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteControlFile
    /// </summary>
    [WmiClass(Name = "SMS_SiteControlFile")]
    public class SmsSiteControlFile
    {
        /// <summary>
        /// WMI method <c>Commit</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CommitDelegate();
        /// <summary>
        /// WMI method <c>Commit</c>.
        /// </summary>
        public CommitDelegate Commit;
        
        /// <summary>
        /// WMI method <c>Refresh</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshDelegate();
        /// <summary>
        /// WMI method <c>Refresh</c>.
        /// </summary>
        public RefreshDelegate Refresh;
        
        /// <summary>
        /// WMI static method <c>CommitSCF</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CommitScfDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>CommitSCF</c>.
        /// </summary>
        public static CommitScfDelegate CommitScf;
        
        /// <summary>
        /// WMI static method <c>RefreshSCF</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshScfDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>RefreshSCF</c>.
        /// </summary>
        public static RefreshScfDelegate RefreshScf;
        
        /// <summary>
        /// WMI static method <c>GetCurrentVersion</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetCurrentVersionDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>GetCurrentVersion</c>.
        /// </summary>
        public static GetCurrentVersionDelegate GetCurrentVersion;
        
        /// <summary>
        /// WMI static method <c>GetSessionHandle</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSessionHandleDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSessionHandle</c>.
        /// </summary>
        public static GetSessionHandleDelegate GetSessionHandle;
        
        /// <summary>
        /// WMI static method <c>ReleaseSessionHandle</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sessionHandle">WMI Property <c>SessionHandle</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReleaseSessionHandleDelegate(WmiContext wmiContext, string sessionHandle = default);
        /// <summary>
        /// WMI static method <c>ReleaseSessionHandle</c>.
        /// </summary>
        public static ReleaseSessionHandleDelegate ReleaseSessionHandle;
        
        /// <summary>
        /// WMI static method <c>GetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNextIdDelegate(WmiContext wmiContext, string siteCode = default);
        /// <summary>
        /// WMI static method <c>GetNextID</c>.
        /// </summary>
        public static GetNextIdDelegate GetNextId;
        
        /// <summary>
        /// WMI static method <c>SetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nextId">WMI Property <c>NextID</c> of type <c>uint</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetNextIdDelegate(WmiContext wmiContext, uint nextId = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>SetNextID</c>.
        /// </summary>
        public static SetNextIdDelegate SetNextId;
        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public string BuildNumber { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property FormatVersion
        /// </summary>
        public string FormatVersion { get; set; }
        /// <summary>
        /// WMI Property SCFData
        /// </summary>
        public string ScfData { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public uint SerialNumber { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
