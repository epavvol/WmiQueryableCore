using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_INFO
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_INFO")]
    public class SmsGSystemDeviceInfo
    {
        /// <summary>
        /// WMI Property CertExpiry
        /// </summary>
        public string CertExpiry { get; set; }
        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property OS
        /// </summary>
        public string Os { get; set; }
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
