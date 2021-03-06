using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceCollectionMember
    /// </summary>
    [WmiClass(Name = "SMS_DeviceCollectionMember")]
    public class SmsDeviceCollectionMember
    {
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property LimitToCollectionID
        /// </summary>
        public string LimitToCollectionId { get; set; }
        /// <summary>
        /// WMI Property LimitToCollectionName
        /// </summary>
        public string LimitToCollectionName { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public string SiteId { get; set; }
    }
}
