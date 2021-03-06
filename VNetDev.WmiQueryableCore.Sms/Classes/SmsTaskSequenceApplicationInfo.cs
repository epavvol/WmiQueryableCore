using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ApplicationInfo
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ApplicationInfo")]
    public class SmsTaskSequenceApplicationInfo
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
