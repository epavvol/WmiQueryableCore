using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SoftwareElement
    /// </summary>
    [WmiClass(Name = "Win32_SoftwareElement")]
    public class Win32SoftwareElement
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public ushort Attributes { get; set; }

        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public string BuildNumber { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CodeSet
        /// </summary>
        public string CodeSet { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property IdentificationCode
        /// </summary>
        public string IdentificationCode { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InstallState
        /// </summary>
        public short InstallState { get; set; }

        /// <summary>
        /// WMI Property LanguageEdition
        /// </summary>
        public string LanguageEdition { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OtherTargetOS
        /// </summary>
        public string OtherTargetOs { get; set; }

        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property TargetOperatingSystem
        /// </summary>
        public ushort TargetOperatingSystem { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}