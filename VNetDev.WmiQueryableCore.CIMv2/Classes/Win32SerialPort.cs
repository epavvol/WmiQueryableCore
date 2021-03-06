using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SerialPort
    /// </summary>
    [WmiClass(Name = "Win32_SerialPort")]
    public class Win32SerialPort
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
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property Binary
        /// </summary>
        public bool Binary { get; set; }

        /// <summary>
        /// WMI Property Capabilities
        /// </summary>
        public ICollection<ushort> Capabilities { get; set; }

        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public ICollection<string> CapabilityDescriptions { get; set; }

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
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

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
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property MaxBaudRate
        /// </summary>
        public uint MaxBaudRate { get; set; }

        /// <summary>
        /// WMI Property MaximumInputBufferSize
        /// </summary>
        public uint MaximumInputBufferSize { get; set; }

        /// <summary>
        /// WMI Property MaximumOutputBufferSize
        /// </summary>
        public uint MaximumOutputBufferSize { get; set; }

        /// <summary>
        /// WMI Property MaxNumberControlled
        /// </summary>
        public uint MaxNumberControlled { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OSAutoDiscovered
        /// </summary>
        public bool OsAutoDiscovered { get; set; }

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
        /// WMI Property ProtocolSupported
        /// </summary>
        public ushort ProtocolSupported { get; set; }

        /// <summary>
        /// WMI Property ProviderType
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// WMI Property SettableBaudRate
        /// </summary>
        public bool SettableBaudRate { get; set; }

        /// <summary>
        /// WMI Property SettableDataBits
        /// </summary>
        public bool SettableDataBits { get; set; }

        /// <summary>
        /// WMI Property SettableFlowControl
        /// </summary>
        public bool SettableFlowControl { get; set; }

        /// <summary>
        /// WMI Property SettableParity
        /// </summary>
        public bool SettableParity { get; set; }

        /// <summary>
        /// WMI Property SettableParityCheck
        /// </summary>
        public bool SettableParityCheck { get; set; }

        /// <summary>
        /// WMI Property SettableRLSD
        /// </summary>
        public bool SettableRlsd { get; set; }

        /// <summary>
        /// WMI Property SettableStopBits
        /// </summary>
        public bool SettableStopBits { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property Supports16BitMode
        /// </summary>
        public bool Supports16BitMode { get; set; }

        /// <summary>
        /// WMI Property SupportsDTRDSR
        /// </summary>
        public bool SupportsDtrdsr { get; set; }

        /// <summary>
        /// WMI Property SupportsElapsedTimeouts
        /// </summary>
        public bool SupportsElapsedTimeouts { get; set; }

        /// <summary>
        /// WMI Property SupportsIntTimeouts
        /// </summary>
        public bool SupportsIntTimeouts { get; set; }

        /// <summary>
        /// WMI Property SupportsParityCheck
        /// </summary>
        public bool SupportsParityCheck { get; set; }

        /// <summary>
        /// WMI Property SupportsRLSD
        /// </summary>
        public bool SupportsRlsd { get; set; }

        /// <summary>
        /// WMI Property SupportsRTSCTS
        /// </summary>
        public bool SupportsRtscts { get; set; }

        /// <summary>
        /// WMI Property SupportsSpecialCharacters
        /// </summary>
        public bool SupportsSpecialCharacters { get; set; }

        /// <summary>
        /// WMI Property SupportsXOnXOff
        /// </summary>
        public bool SupportsXOnXOff { get; set; }

        /// <summary>
        /// WMI Property SupportsXOnXOffSet
        /// </summary>
        public bool SupportsXOnXOffSet { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }
    }
}