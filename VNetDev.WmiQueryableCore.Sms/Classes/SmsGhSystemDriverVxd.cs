using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_DRIVER_VXD
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_DRIVER_VXD")]
    public class SmsGhSystemDriverVxd
    {
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
        /// WMI Property Control
        /// </summary>
        public string Control { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceDescriptorBlock
        /// </summary>
        public string DeviceDescriptorBlock { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IdentificationCode
        /// </summary>
        public string IdentificationCode { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
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
        /// WMI Property PM_API
        /// </summary>
        [WmiProperty(Name = "PM_API")]
        public string PmApi { get; set; }
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
        /// WMI Property ServiceTableSize
        /// </summary>
        public uint ServiceTableSize { get; set; }
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
        /// WMI Property V86_API
        /// </summary>
        [WmiProperty(Name = "V86_API")]
        public string V86Api { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
