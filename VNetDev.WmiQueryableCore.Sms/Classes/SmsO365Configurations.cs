using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_O365Configurations
    /// </summary>
    [WmiClass(Name = "SMS_O365Configurations")]
    public class SmsO365Configurations
    {
        /// <summary>
        /// WMI Property AutoUpgrade00
        /// </summary>
        public string AutoUpgrade00 { get; set; }
        /// <summary>
        /// WMI Property CCMManaged00
        /// </summary>
        public string CcmManaged00 { get; set; }
        /// <summary>
        /// WMI Property CDNBaseUrl00
        /// </summary>
        public string CdnBaseUrl00 { get; set; }
        /// <summary>
        /// WMI Property ClientCulture00
        /// </summary>
        public string ClientCulture00 { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property Platform00
        /// </summary>
        public string Platform00 { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public string SiteId { get; set; }
        /// <summary>
        /// WMI Property UpdatesEnabled00
        /// </summary>
        public string UpdatesEnabled00 { get; set; }
        /// <summary>
        /// WMI Property VersionToReport00
        /// </summary>
        public string VersionToReport00 { get; set; }
    }
}
