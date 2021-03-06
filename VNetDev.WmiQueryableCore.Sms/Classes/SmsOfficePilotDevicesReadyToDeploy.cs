using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficePilotDevicesReadyToDeploy
    /// </summary>
    [WmiClass(Name = "SMS_OfficePilotDevicesReadyToDeploy")]
    public class SmsOfficePilotDevicesReadyToDeploy
    {
        /// <summary>
        /// WMI Property AddInHealthSource
        /// </summary>
        public uint AddInHealthSource { get; set; }
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
        /// WMI Property DeploymentReadiness
        /// </summary>
        public uint DeploymentReadiness { get; set; }
        /// <summary>
        /// WMI Property MacroHealthSource
        /// </summary>
        public uint MacroHealthSource { get; set; }
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
