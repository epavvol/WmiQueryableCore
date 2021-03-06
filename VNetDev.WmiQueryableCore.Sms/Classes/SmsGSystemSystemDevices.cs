using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SYSTEM_DEVICES
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SYSTEM_DEVICES")]
    public class SmsGSystemSystemDevices
    {
        /// <summary>
        /// WMI Property CompatibleIDs
        /// </summary>
        public string CompatibleIDs { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HardwareIDs
        /// </summary>
        public string HardwareIDs { get; set; }
        /// <summary>
        /// WMI Property IsPnP
        /// </summary>
        public uint IsPnP { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
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
