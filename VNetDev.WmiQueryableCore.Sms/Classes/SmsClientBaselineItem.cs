using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientBaselineItem
    /// </summary>
    [WmiClass(Name = "SMS_ClientBaselineItem")]
    public class SmsClientBaselineItem
    {
        /// <summary>
        /// WMI Property BaselineFlags
        /// </summary>
        public uint BaselineFlags { get; set; }
        /// <summary>
        /// WMI Property BaselineItemID
        /// </summary>
        public uint BaselineItemId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Platform
        /// </summary>
        public uint Platform { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
