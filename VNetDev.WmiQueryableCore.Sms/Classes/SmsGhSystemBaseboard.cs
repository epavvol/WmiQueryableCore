using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_BASEBOARD
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_BASEBOARD")]
    public class SmsGhSystemBaseboard
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ConfigOptions
        /// </summary>
        public string ConfigOptions { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HostingBoard
        /// </summary>
        public uint HostingBoard { get; set; }
        /// <summary>
        /// WMI Property HotSwappable
        /// </summary>
        public uint HotSwappable { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
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
        /// WMI Property Product
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// WMI Property Removable
        /// </summary>
        public uint Removable { get; set; }
        /// <summary>
        /// WMI Property Replaceable
        /// </summary>
        public uint Replaceable { get; set; }
        /// <summary>
        /// WMI Property RequirementsDescription
        /// </summary>
        public string RequirementsDescription { get; set; }
        /// <summary>
        /// WMI Property RequiresDaughterBoard
        /// </summary>
        public uint RequiresDaughterBoard { get; set; }
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
        /// WMI Property SlotLayout
        /// </summary>
        public string SlotLayout { get; set; }
        /// <summary>
        /// WMI Property SpecialRequirements
        /// </summary>
        public uint SpecialRequirements { get; set; }
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
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
