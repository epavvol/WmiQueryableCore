using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_POWER
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_POWER")]
    public class SmsGSystemDevicePower
    {
        /// <summary>
        /// WMI Property BacklightACTimeout
        /// </summary>
        public uint BacklightAcTimeout { get; set; }
        /// <summary>
        /// WMI Property BacklightBatTimeout
        /// </summary>
        public uint BacklightBatTimeout { get; set; }
        /// <summary>
        /// WMI Property BackupPercent
        /// </summary>
        public uint BackupPercent { get; set; }
        /// <summary>
        /// WMI Property BatteryPercent
        /// </summary>
        public uint BatteryPercent { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
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
