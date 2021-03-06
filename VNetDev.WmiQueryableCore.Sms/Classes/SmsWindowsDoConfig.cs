using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WindowsDOConfig
    /// </summary>
    [WmiClass(Name = "SMS_WindowsDOConfig")]
    public class SmsWindowsDoConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property CollectDODownloadData
        /// </summary>
        public bool CollectDoDownloadData { get; set; }
        /// <summary>
        /// WMI Property DODataCollectionInterval
        /// </summary>
        public uint DoDataCollectionInterval { get; set; }
        /// <summary>
        /// WMI Property EnableWindowsDO
        /// </summary>
        public bool EnableWindowsDo { get; set; }
        /// <summary>
        /// WMI Property StampDOINC
        /// </summary>
        public bool StampDoinc { get; set; }
    }
}
