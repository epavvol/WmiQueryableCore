using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PnPSignedDriver
    /// </summary>
    [WmiClass(Name = "Win32_PnPSignedDriver")]
    public class Win32PnPSignedDriver
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ClassGuid
        /// </summary>
        public string ClassGuid { get; set; }

        /// <summary>
        /// WMI Property CompatID
        /// </summary>
        public string CompatId { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceClass
        /// </summary>
        public string DeviceClass { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// WMI Property DevLoader
        /// </summary>
        public string DevLoader { get; set; }

        /// <summary>
        /// WMI Property DriverDate
        /// </summary>
        public DateTime DriverDate { get; set; }

        /// <summary>
        /// WMI Property DriverName
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// WMI Property DriverProviderName
        /// </summary>
        public string DriverProviderName { get; set; }

        /// <summary>
        /// WMI Property DriverVersion
        /// </summary>
        public string DriverVersion { get; set; }

        /// <summary>
        /// WMI Property FriendlyName
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// WMI Property HardWareID
        /// </summary>
        public string HardWareId { get; set; }

        /// <summary>
        /// WMI Property InfName
        /// </summary>
        public string InfName { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property IsSigned
        /// </summary>
        public bool IsSigned { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PDO
        /// </summary>
        public string Pdo { get; set; }

        /// <summary>
        /// WMI Property Signer
        /// </summary>
        public string Signer { get; set; }

        /// <summary>
        /// WMI Property Started
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// WMI Property StartMode
        /// </summary>
        public string StartMode { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
    }
}