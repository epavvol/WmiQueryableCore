using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CacheMemory
    /// </summary>
    [WmiClass(Name = "CIM_CacheMemory")]
    public class CimCacheMemory
    {
        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property Access
        /// </summary>
        public ushort Access { get; set; }

        /// <summary>
        /// WMI Property AdditionalErrorData
        /// </summary>
        public ICollection<byte> AdditionalErrorData { get; set; }

        /// <summary>
        /// WMI Property Associativity
        /// </summary>
        public ushort Associativity { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BlockSize
        /// </summary>
        public ulong BlockSize { get; set; }

        /// <summary>
        /// WMI Property CacheSpeed
        /// </summary>
        public uint CacheSpeed { get; set; }

        /// <summary>
        /// WMI Property CacheType
        /// </summary>
        public ushort CacheType { get; set; }

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
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CorrectableError
        /// </summary>
        public bool CorrectableError { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentSRAM
        /// </summary>
        public ICollection<ushort> CurrentSram { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property EndingAddress
        /// </summary>
        public ulong EndingAddress { get; set; }

        /// <summary>
        /// WMI Property ErrorAccess
        /// </summary>
        public ushort ErrorAccess { get; set; }

        /// <summary>
        /// WMI Property ErrorAddress
        /// </summary>
        public ulong ErrorAddress { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorCorrectType
        /// </summary>
        public ushort ErrorCorrectType { get; set; }

        /// <summary>
        /// WMI Property ErrorData
        /// </summary>
        public ICollection<byte> ErrorData { get; set; }

        /// <summary>
        /// WMI Property ErrorDataOrder
        /// </summary>
        public ushort ErrorDataOrder { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property ErrorInfo
        /// </summary>
        public ushort ErrorInfo { get; set; }

        /// <summary>
        /// WMI Property ErrorMethodology
        /// </summary>
        public string ErrorMethodology { get; set; }

        /// <summary>
        /// WMI Property ErrorResolution
        /// </summary>
        public ulong ErrorResolution { get; set; }

        /// <summary>
        /// WMI Property ErrorTime
        /// </summary>
        public DateTime ErrorTime { get; set; }

        /// <summary>
        /// WMI Property ErrorTransferSize
        /// </summary>
        public uint ErrorTransferSize { get; set; }

        /// <summary>
        /// WMI Property FlushTimer
        /// </summary>
        public uint FlushTimer { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InstalledSize
        /// </summary>
        public uint InstalledSize { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property Level
        /// </summary>
        public ushort Level { get; set; }

        /// <summary>
        /// WMI Property LineSize
        /// </summary>
        public uint LineSize { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public ushort Location { get; set; }

        /// <summary>
        /// WMI Property MaxCacheSize
        /// </summary>
        public uint MaxCacheSize { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NumberOfBlocks
        /// </summary>
        public ulong NumberOfBlocks { get; set; }

        /// <summary>
        /// WMI Property OtherErrorDescription
        /// </summary>
        public string OtherErrorDescription { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property Purpose
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// WMI Property ReadPolicy
        /// </summary>
        public ushort ReadPolicy { get; set; }

        /// <summary>
        /// WMI Property ReplacementPolicy
        /// </summary>
        public ushort ReplacementPolicy { get; set; }

        /// <summary>
        /// WMI Property StartingAddress
        /// </summary>
        public ulong StartingAddress { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SupportedSRAM
        /// </summary>
        public ICollection<ushort> SupportedSram { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemLevelAddress
        /// </summary>
        public bool SystemLevelAddress { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property WritePolicy
        /// </summary>
        public ushort WritePolicy { get; set; }
    }
}