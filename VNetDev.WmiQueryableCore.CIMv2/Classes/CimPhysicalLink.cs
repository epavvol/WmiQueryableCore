using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_PhysicalLink
    /// </summary>
    [WmiClass(Name = "CIM_PhysicalLink")]
    public class CimPhysicalLink
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Length
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxLength
        /// </summary>
        public double MaxLength { get; set; }

        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public ushort MediaType { get; set; }

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
        public bool PoweredOn { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property Wired
        /// </summary>
        public bool Wired { get; set; }
    }
}