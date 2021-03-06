using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WindowsServicingBusinessReadyUpdates
    /// </summary>
    [WmiClass(Name = "SMS_WindowsServicingBusinessReadyUpdates")]
    public class SmsWindowsServicingBusinessReadyUpdates
    {
        /// <summary>
        /// WMI Property UpdateID
        /// </summary>
        public string UpdateId { get; set; }
    }
}
