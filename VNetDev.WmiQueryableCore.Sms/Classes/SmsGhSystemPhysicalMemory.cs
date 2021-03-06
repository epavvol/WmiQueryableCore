using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_PHYSICAL_MEMORY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_PHYSICAL_MEMORY")]
    public class SmsGhSystemPhysicalMemory
    {
        /// <summary>
        /// WMI Property BankLabel
        /// </summary>
        public string BankLabel { get; set; }
        /// <summary>
        /// WMI Property Capacity
        /// </summary>
        public ulong Capacity { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }
        /// <summary>
        /// WMI Property DataWidth
        /// </summary>
        public uint DataWidth { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceLocator
        /// </summary>
        public string DeviceLocator { get; set; }
        /// <summary>
        /// WMI Property FormFactor
        /// </summary>
        public uint FormFactor { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HotSwappable
        /// </summary>
        public uint HotSwappable { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property InterleaveDataDepth
        /// </summary>
        public uint InterleaveDataDepth { get; set; }
        /// <summary>
        /// WMI Property InterleavePosition
        /// </summary>
        public uint InterleavePosition { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MemoryType
        /// </summary>
        public uint MemoryType { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OtherIdentifyingInfo
        /// </summary>
        public string OtherIdentifyingInfo { get; set; }
        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }
        /// <summary>
        /// WMI Property PositionInRow
        /// </summary>
        public uint PositionInRow { get; set; }
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
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// WMI Property Speed
        /// </summary>
        public uint Speed { get; set; }
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
        /// WMI Property TotalWidth
        /// </summary>
        public uint TotalWidth { get; set; }
        /// <summary>
        /// WMI Property TypeDetail
        /// </summary>
        public uint TypeDetail { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
