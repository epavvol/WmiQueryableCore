using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ExcludedMachineNetBIOSName
    /// </summary>
    [WmiClass(Name = "SMS_ExcludedMachineNetBIOSName")]
    public class SmsExcludedMachineNetBiosName
    {
        /// <summary>
        /// WMI Property NetBIOSName
        /// </summary>
        public string NetBiosName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
