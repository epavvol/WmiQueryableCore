using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_PRINTER_DEVICE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_PRINTER_DEVICE")]
    public class SmsGSystemPrinterDevice
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public uint Attributes { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property AveragePagesPerMinute
        /// </summary>
        public uint AveragePagesPerMinute { get; set; }
        /// <summary>
        /// WMI Property Capabilities
        /// </summary>
        public string Capabilities { get; set; }
        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public string CapabilityDescriptions { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
        /// <summary>
        /// WMI Property DefaultPriority
        /// </summary>
        public uint DefaultPriority { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DetectedErrorState
        /// </summary>
        public uint DetectedErrorState { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DriverName
        /// </summary>
        public string DriverName { get; set; }
        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property JobCountSinceLastReset
        /// </summary>
        public uint JobCountSinceLastReset { get; set; }
        /// <summary>
        /// WMI Property LanguagesSupported
        /// </summary>
        public string LanguagesSupported { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PaperSizesSupported
        /// </summary>
        public string PaperSizesSupported { get; set; }
        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }
        /// <summary>
        /// WMI Property PortName
        /// </summary>
        public string PortName { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property PrinterPaperNames
        /// </summary>
        public string PrinterPaperNames { get; set; }
        /// <summary>
        /// WMI Property PrinterState
        /// </summary>
        public uint PrinterState { get; set; }
        /// <summary>
        /// WMI Property PrinterStatus
        /// </summary>
        public uint PrinterStatus { get; set; }
        /// <summary>
        /// WMI Property PrintJobDataType
        /// </summary>
        public string PrintJobDataType { get; set; }
        /// <summary>
        /// WMI Property PrintProcessor
        /// </summary>
        public string PrintProcessor { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SeparatorFile
        /// </summary>
        public string SeparatorFile { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }
        /// <summary>
        /// WMI Property SpoolEnabled
        /// </summary>
        public uint SpoolEnabled { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UntilTime
        /// </summary>
        public DateTime UntilTime { get; set; }
        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }
    }
}
