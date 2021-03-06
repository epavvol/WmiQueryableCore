using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficePilotDevicesHealth
    /// </summary>
    [WmiClass(Name = "SMS_OfficePilotDevicesHealth")]
    public class SmsOfficePilotDevicesHealth
    {
        /// <summary>
        /// WMI Property AddInHealthStatus
        /// </summary>
        public uint AddInHealthStatus { get; set; }
        /// <summary>
        /// WMI Property AddInInventory
        /// </summary>
        public uint AddInInventory { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property MacroHealthStatus
        /// </summary>
        public uint MacroHealthStatus { get; set; }
        /// <summary>
        /// WMI Property MacroInventory
        /// </summary>
        public uint MacroInventory { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OverallHealthStatus
        /// </summary>
        public uint OverallHealthStatus { get; set; }
        /// <summary>
        /// WMI Property Reason
        /// </summary>
        public uint Reason { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
    }
}
