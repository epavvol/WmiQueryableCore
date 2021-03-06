using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficePilotAddInsHealth
    /// </summary>
    [WmiClass(Name = "SMS_OfficePilotAddInsHealth")]
    public class SmsOfficePilotAddInsHealth
    {
        /// <summary>
        /// WMI Property ActiveDevices
        /// </summary>
        public uint ActiveDevices { get; set; }
        /// <summary>
        /// WMI Property AddInHealthStatusReason
        /// </summary>
        public uint AddInHealthStatusReason { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CrashRate
        /// </summary>
        public float CrashRate { get; set; }
        /// <summary>
        /// WMI Property DeviceCount
        /// </summary>
        public uint DeviceCount { get; set; }
        /// <summary>
        /// WMI Property LoadFailureRate
        /// </summary>
        public float LoadFailureRate { get; set; }
        /// <summary>
        /// WMI Property LoadHealth
        /// </summary>
        public uint LoadHealth { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OverallHealth
        /// </summary>
        public uint OverallHealth { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property RunHealth
        /// </summary>
        public uint RunHealth { get; set; }
        /// <summary>
        /// WMI Property SupportStatement
        /// </summary>
        public string SupportStatement { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
