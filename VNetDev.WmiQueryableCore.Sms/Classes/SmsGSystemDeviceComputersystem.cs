using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_COMPUTERSYSTEM
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_COMPUTERSYSTEM")]
    public class SmsGSystemDeviceComputersystem
    {
        /// <summary>
        /// WMI Property CellularTechnology
        /// </summary>
        public string CellularTechnology { get; set; }
        /// <summary>
        /// WMI Property DeviceClientID
        /// </summary>
        public string DeviceClientId { get; set; }
        /// <summary>
        /// WMI Property DeviceManufacturer
        /// </summary>
        public string DeviceManufacturer { get; set; }
        /// <summary>
        /// WMI Property DeviceModel
        /// </summary>
        public string DeviceModel { get; set; }
        /// <summary>
        /// WMI Property DMVersion
        /// </summary>
        public string DmVersion { get; set; }
        /// <summary>
        /// WMI Property FirmwareVersion
        /// </summary>
        public string FirmwareVersion { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HardwareVersion
        /// </summary>
        public string HardwareVersion { get; set; }
        /// <summary>
        /// WMI Property IMEI
        /// </summary>
        public string Imei { get; set; }
        /// <summary>
        /// WMI Property IMSI
        /// </summary>
        public string Imsi { get; set; }
        /// <summary>
        /// WMI Property IsActivationLockEnabled
        /// </summary>
        public uint IsActivationLockEnabled { get; set; }
        /// <summary>
        /// WMI Property Jailbroken
        /// </summary>
        public uint Jailbroken { get; set; }
        /// <summary>
        /// WMI Property MEID
        /// </summary>
        public string Meid { get; set; }
        /// <summary>
        /// WMI Property OEM
        /// </summary>
        public string Oem { get; set; }
        /// <summary>
        /// WMI Property PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// WMI Property PlatformType
        /// </summary>
        public string PlatformType { get; set; }
        /// <summary>
        /// WMI Property ProcessorArchitecture
        /// </summary>
        public uint ProcessorArchitecture { get; set; }
        /// <summary>
        /// WMI Property ProcessorLevel
        /// </summary>
        public uint ProcessorLevel { get; set; }
        /// <summary>
        /// WMI Property ProcessorRevision
        /// </summary>
        public uint ProcessorRevision { get; set; }
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
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
        /// WMI Property SoftwareVersion
        /// </summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// WMI Property SubscriberCarrierNetwork
        /// </summary>
        public string SubscriberCarrierNetwork { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
