using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_UAComputerStatus
    /// </summary>
    [WmiClass(Name = "SMS_G_System_UAComputerStatus")]
    public class SmsGSystemUaComputerStatus
    {
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property UpgradeAnalyticsStatus
        /// </summary>
        public uint UpgradeAnalyticsStatus { get; set; }
    }
}
