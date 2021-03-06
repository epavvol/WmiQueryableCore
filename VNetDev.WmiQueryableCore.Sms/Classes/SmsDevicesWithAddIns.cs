using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DevicesWithAddIns
    /// </summary>
    [WmiClass(Name = "SMS_DevicesWithAddIns")]
    public class SmsDevicesWithAddIns
    {
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
