using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_PC_BIOS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_PC_BIOS")]
    public class SmsGSystemPcBios
    {
        /// <summary>
        /// WMI Property BiosCharacteristics
        /// </summary>
        public string BiosCharacteristics { get; set; }
        /// <summary>
        /// WMI Property BIOSVersion
        /// </summary>
        public string BiosVersion { get; set; }
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
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IdentificationCode
        /// </summary>
        public string IdentificationCode { get; set; }
        /// <summary>
        /// WMI Property InstallableLanguages
        /// </summary>
        public uint InstallableLanguages { get; set; }
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
        public string ListOfLanguages { get; set; }
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
        public uint PrimaryBios { get; set; }
        /// <summary>
        /// WMI Property ReleaseDate
        /// </summary>
        public DateTime ReleaseDate { get; set; }
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
        /// WMI Property SMBIOSBIOSVersion
        /// </summary>
        public string SmbiosbiosVersion { get; set; }
        /// <summary>
        /// WMI Property SMBIOSMajorVersion
        /// </summary>
        public uint SmbiosMajorVersion { get; set; }
        /// <summary>
        /// WMI Property SMBIOSMinorVersion
        /// </summary>
        public uint SmbiosMinorVersion { get; set; }
        /// <summary>
        /// WMI Property SMBIOSPresent
        /// </summary>
        public uint SmbiosPresent { get; set; }
        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }
        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public uint SoftwareElementState { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property TargetOperatingSystem
        /// </summary>
        public uint TargetOperatingSystem { get; set; }
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
