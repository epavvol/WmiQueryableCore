using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE_DEVICESUMMARY
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE_DEVICESUMMARY")]
    public class SmsGSystemOfficeDevicesummary
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsProPlusInstalled
        /// </summary>
        public uint IsProPlusInstalled { get; set; }
        /// <summary>
        /// WMI Property IsTelemetryEnabled
        /// </summary>
        public uint IsTelemetryEnabled { get; set; }
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
