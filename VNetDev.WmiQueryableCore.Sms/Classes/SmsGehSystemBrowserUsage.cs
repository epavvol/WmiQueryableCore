using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_BROWSER_USAGE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_BROWSER_USAGE")]
    public class SmsGehSystemBrowserUsage
    {
        /// <summary>
        /// WMI Property BrowserName
        /// </summary>
        public string BrowserName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UsagePercentage
        /// </summary>
        public uint UsagePercentage { get; set; }
    }
}
