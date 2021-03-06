using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_MDM_DEVDETAIL_EXT01
    /// </summary>
    [WmiClass(Name = "SMS_G_System_MDM_DEVDETAIL_EXT01")]
    public class SmsGSystemMdmDevdetailExt01
    {
        /// <summary>
        /// WMI Property DeviceHardwareData
        /// </summary>
        public string DeviceHardwareData { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstanceID
        /// </summary>
        public string InstanceId { get; set; }
        /// <summary>
        /// WMI Property ParentID
        /// </summary>
        public string ParentId { get; set; }
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
        /// WMI Property WLANMACAddress
        /// </summary>
        public string WlanmacAddress { get; set; }
    }
}
