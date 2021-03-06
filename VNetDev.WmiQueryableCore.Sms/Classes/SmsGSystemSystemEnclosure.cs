using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SYSTEM_ENCLOSURE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SYSTEM_ENCLOSURE")]
    public class SmsGSystemSystemEnclosure
    {
        /// <summary>
        /// WMI Property AudibleAlarm
        /// </summary>
        public uint AudibleAlarm { get; set; }
        /// <summary>
        /// WMI Property BreachDescription
        /// </summary>
        public string BreachDescription { get; set; }
        /// <summary>
        /// WMI Property CableManagementStrategy
        /// </summary>
        public string CableManagementStrategy { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ChassisTypes
        /// </summary>
        public string ChassisTypes { get; set; }
        /// <summary>
        /// WMI Property CurrentRequiredOrProduced
        /// </summary>
        public uint CurrentRequiredOrProduced { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HeatGeneration
        /// </summary>
        public uint HeatGeneration { get; set; }
        /// <summary>
        /// WMI Property HotSwappable
        /// </summary>
        public uint HotSwappable { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property LockPresent
        /// </summary>
        public uint LockPresent { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfPowerCords
        /// </summary>
        public uint NumberOfPowerCords { get; set; }
        /// <summary>
        /// WMI Property OtherIdentifyingInfo
        /// </summary>
        public string OtherIdentifyingInfo { get; set; }
        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }
        /// <summary>
        /// WMI Property PoweredOn
        /// </summary>
        public uint PoweredOn { get; set; }
        /// <summary>
        /// WMI Property Removable
        /// </summary>
        public uint Removable { get; set; }
        /// <summary>
        /// WMI Property Replaceable
        /// </summary>
        public uint Replaceable { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SecurityBreach
        /// </summary>
        public uint SecurityBreach { get; set; }
        /// <summary>
        /// WMI Property SecurityStatus
        /// </summary>
        public uint SecurityStatus { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property ServiceDescriptions
        /// </summary>
        public string ServiceDescriptions { get; set; }
        /// <summary>
        /// WMI Property ServicePhilosophy
        /// </summary>
        public string ServicePhilosophy { get; set; }
        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// WMI Property SMBIOSAssetTag
        /// </summary>
        public string SmbiosAssetTag { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TypeDescriptions
        /// </summary>
        public string TypeDescriptions { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VisibleAlarm
        /// </summary>
        public uint VisibleAlarm { get; set; }
    }
}
