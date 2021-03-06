using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WindowsAnalyticsConfig
    /// </summary>
    [WmiClass(Name = "SMS_WindowsAnalyticsConfig")]
    public class SmsWindowsAnalyticsConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property WACommercialID
        /// </summary>
        public string WaCommercialId { get; set; }
        /// <summary>
        /// WMI Property WAEnable
        /// </summary>
        public uint WaEnable { get; set; }
        /// <summary>
        /// WMI Property WAIEOptInlevel
        /// </summary>
        public uint WaieOptInlevel { get; set; }
        /// <summary>
        /// WMI Property WAOptInDownlevel
        /// </summary>
        public uint WaOptInDownlevel { get; set; }
        /// <summary>
        /// WMI Property WATelLevel
        /// </summary>
        public uint WaTelLevel { get; set; }
    }
}
