using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_BIOS
    /// </summary>
    [WmiClass(Name = "Win32_BIOS")]
    public class Win32Bios
    {
        /// <summary>
        /// WMI Property BiosCharacteristics
        /// </summary>
        public ICollection<ushort> BiosCharacteristics { get; set; }

        /// <summary>
        /// WMI Property BIOSVersion
        /// </summary>
        public ICollection<string> BiosVersion { get; set; }

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
        /// WMI Property CurrentLanguage
        /// </summary>
        public string CurrentLanguage { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property EmbeddedControllerMajorVersion
        /// </summary>
        public byte EmbeddedControllerMajorVersion { get; set; }

        /// <summary>
        /// WMI Property EmbeddedControllerMinorVersion
        /// </summary>
        public byte EmbeddedControllerMinorVersion { get; set; }

        /// <summary>
        /// WMI Property IdentificationCode
        /// </summary>
        public string IdentificationCode { get; set; }

        /// <summary>
        /// WMI Property InstallableLanguages
        /// </summary>
        public ushort InstallableLanguages { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LanguageEdition
        /// </summary>
        public string LanguageEdition { get; set; }

        /// <summary>
        /// WMI Property ListOfLanguages
        /// </summary>
        public ICollection<string> ListOfLanguages { get; set; }

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
        /// WMI Property PrimaryBIOS
        /// </summary>
        public bool PrimaryBios { get; set; }

        /// <summary>
        /// WMI Property ReleaseDate
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SMBIOSBIOSVersion
        /// </summary>
        public string SmbiosbiosVersion { get; set; }

        /// <summary>
        /// WMI Property SMBIOSMajorVersion
        /// </summary>
        public ushort SmbiosMajorVersion { get; set; }

        /// <summary>
        /// WMI Property SMBIOSMinorVersion
        /// </summary>
        public ushort SmbiosMinorVersion { get; set; }

        /// <summary>
        /// WMI Property SMBIOSPresent
        /// </summary>
        public bool SmbiosPresent { get; set; }

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
        /// WMI Property SystemBiosMajorVersion
        /// </summary>
        public byte SystemBiosMajorVersion { get; set; }

        /// <summary>
        /// WMI Property SystemBiosMinorVersion
        /// </summary>
        public byte SystemBiosMinorVersion { get; set; }

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