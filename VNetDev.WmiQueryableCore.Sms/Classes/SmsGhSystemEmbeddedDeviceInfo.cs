using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_EMBEDDED_DEVICE_INFO
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_EMBEDDED_DEVICE_INFO")]
    public class SmsGhSystemEmbeddedDeviceInfo
    {
        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property OEMName
        /// </summary>
        public string OemName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
