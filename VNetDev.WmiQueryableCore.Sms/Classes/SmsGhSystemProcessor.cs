using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_PROCESSOR
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_PROCESSOR")]
    public class SmsGhSystemProcessor
    {
        /// <summary>
        /// WMI Property AddressWidth
        /// </summary>
        public uint AddressWidth { get; set; }
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public uint Architecture { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BrandID
        /// </summary>
        public uint BrandId { get; set; }
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
        /// WMI Property CPUHash
        /// </summary>
        public string CpuHash { get; set; }
        /// <summary>
        /// WMI Property CPUKey
        /// </summary>
        public string CpuKey { get; set; }
        /// <summary>
        /// WMI Property CpuStatus
        /// </summary>
        public uint CpuStatus { get; set; }
        /// <summary>
        /// WMI Property CurrentClockSpeed
        /// </summary>
        public uint CurrentClockSpeed { get; set; }
        /// <summary>
        /// WMI Property CurrentVoltage
        /// </summary>
        public uint CurrentVoltage { get; set; }
        /// <summary>
        /// WMI Property DataWidth
        /// </summary>
        public uint DataWidth { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property ExtClock
        /// </summary>
        public uint ExtClock { get; set; }
        /// <summary>
        /// WMI Property Family
        /// </summary>
        public uint Family { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property Is64Bit
        /// </summary>
        public uint Is64Bit { get; set; }
        /// <summary>
        /// WMI Property IsHyperthreadCapable
        /// </summary>
        public uint IsHyperthreadCapable { get; set; }
        /// <summary>
        /// WMI Property IsHyperthreadEnabled
        /// </summary>
        public uint IsHyperthreadEnabled { get; set; }
        /// <summary>
        /// WMI Property IsMobile
        /// </summary>
        public uint IsMobile { get; set; }
        /// <summary>
        /// WMI Property IsTrustedExecutionCapable
        /// </summary>
        public uint IsTrustedExecutionCapable { get; set; }
        /// <summary>
        /// WMI Property IsVitualizationCapable
        /// </summary>
        public uint IsVitualizationCapable { get; set; }
        /// <summary>
        /// WMI Property L2CacheSize
        /// </summary>
        public uint L2CacheSize { get; set; }
        /// <summary>
        /// WMI Property L2CacheSpeed
        /// </summary>
        public uint L2CacheSpeed { get; set; }
        /// <summary>
        /// WMI Property L3CacheSize
        /// </summary>
        public uint L3CacheSize { get; set; }
        /// <summary>
        /// WMI Property L3CacheSpeed
        /// </summary>
        public uint L3CacheSpeed { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property Level
        /// </summary>
        public uint Level { get; set; }
        /// <summary>
        /// WMI Property LoadPercentage
        /// </summary>
        public uint LoadPercentage { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MaxClockSpeed
        /// </summary>
        public uint MaxClockSpeed { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NormSpeed
        /// </summary>
        public uint NormSpeed { get; set; }
        /// <summary>
        /// WMI Property NumberOfCores
        /// </summary>
        public uint NumberOfCores { get; set; }
        /// <summary>
        /// WMI Property NumberOfLogicalProcessors
        /// </summary>
        public uint NumberOfLogicalProcessors { get; set; }
        /// <summary>
        /// WMI Property OtherFamilyDescription
        /// </summary>
        public string OtherFamilyDescription { get; set; }
        /// <summary>
        /// WMI Property PartOfDomain
        /// </summary>
        public uint PartOfDomain { get; set; }
        /// <summary>
        /// WMI Property PCache
        /// </summary>
        public uint PCache { get; set; }
        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property ProcessorId
        /// </summary>
        public string ProcessorId { get; set; }
        /// <summary>
        /// WMI Property ProcessorType
        /// </summary>
        public uint ProcessorType { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Revision
        /// </summary>
        public uint Revision { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Role
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// WMI Property SocketDesignation
        /// </summary>
        public string SocketDesignation { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property Stepping
        /// </summary>
        public string Stepping { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UniqueId
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// WMI Property UpgradeMethod
        /// </summary>
        public uint UpgradeMethod { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VoltageCaps
        /// </summary>
        public uint VoltageCaps { get; set; }
        /// <summary>
        /// WMI Property Workgroup
        /// </summary>
        public string Workgroup { get; set; }
    }
}
