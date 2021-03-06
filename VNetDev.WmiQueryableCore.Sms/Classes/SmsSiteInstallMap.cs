using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteInstallMap
    /// </summary>
    [WmiClass(Name = "SMS_SiteInstallMap")]
    public class SmsSiteInstallMap
    {
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
        /// WMI Property IMapData
        /// </summary>
        public string IMapData { get; set; }
    }
}
