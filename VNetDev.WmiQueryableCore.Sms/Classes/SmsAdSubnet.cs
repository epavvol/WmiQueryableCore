using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADSubnet
    /// </summary>
    [WmiClass(Name = "SMS_ADSubnet")]
    public class SmsAdSubnet
    {
        /// <summary>
        /// WMI Property ADSubnetDescription
        /// </summary>
        public string AdSubnetDescription { get; set; }
        /// <summary>
        /// WMI Property ADSubnetLocation
        /// </summary>
        public string AdSubnetLocation { get; set; }
        /// <summary>
        /// WMI Property ADSubnetName
        /// </summary>
        public string AdSubnetName { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property ForestID
        /// </summary>
        public uint ForestId { get; set; }
        /// <summary>
        /// WMI Property LastDiscoveryTime
        /// </summary>
        public DateTime LastDiscoveryTime { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public uint SiteId { get; set; }
        /// <summary>
        /// WMI Property SubnetID
        /// </summary>
        public uint SubnetId { get; set; }
    }
}
