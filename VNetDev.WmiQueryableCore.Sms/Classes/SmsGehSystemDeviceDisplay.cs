using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_DEVICE_DISPLAY
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_DEVICE_DISPLAY")]
    public class SmsGehSystemDeviceDisplay
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }
        /// <summary>
        /// WMI Property NumberOfColors
        /// </summary>
        public string NumberOfColors { get; set; }
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
        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }
    }
}
