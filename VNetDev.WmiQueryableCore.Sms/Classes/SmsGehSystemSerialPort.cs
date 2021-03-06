using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SERIAL_PORT
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SERIAL_PORT")]
    public class SmsGehSystemSerialPort
    {
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property Binary
        /// </summary>
        public uint Binary { get; set; }
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
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
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
        public uint OsAutoDiscovered { get; set; }
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
        /// WMI Property ProtocolSupported
        /// </summary>
        public uint ProtocolSupported { get; set; }
        /// <summary>
        /// WMI Property ProviderType
        /// </summary>
        public string ProviderType { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SettableBaudRate
        /// </summary>
        public uint SettableBaudRate { get; set; }
        /// <summary>
        /// WMI Property SettableDataBits
        /// </summary>
        public uint SettableDataBits { get; set; }
        /// <summary>
        /// WMI Property SettableFlowControl
        /// </summary>
        public uint SettableFlowControl { get; set; }
        /// <summary>
        /// WMI Property SettableParity
        /// </summary>
        public uint SettableParity { get; set; }
        /// <summary>
        /// WMI Property SettableParityCheck
        /// </summary>
        public uint SettableParityCheck { get; set; }
        /// <summary>
        /// WMI Property SettableRLSD
        /// </summary>
        public uint SettableRlsd { get; set; }
        /// <summary>
        /// WMI Property SettableStopBits
        /// </summary>
        public uint SettableStopBits { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property Supports16BitMode
        /// </summary>
        public uint Supports16BitMode { get; set; }
        /// <summary>
        /// WMI Property SupportsDTRDSR
        /// </summary>
        public uint SupportsDtrdsr { get; set; }
        /// <summary>
        /// WMI Property SupportsElapsedTimeouts
        /// </summary>
        public uint SupportsElapsedTimeouts { get; set; }
        /// <summary>
        /// WMI Property SupportsIntTimeouts
        /// </summary>
        public uint SupportsIntTimeouts { get; set; }
        /// <summary>
        /// WMI Property SupportsParityCheck
        /// </summary>
        public uint SupportsParityCheck { get; set; }
        /// <summary>
        /// WMI Property SupportsRLSD
        /// </summary>
        public uint SupportsRlsd { get; set; }
        /// <summary>
        /// WMI Property SupportsRTSCTS
        /// </summary>
        public uint SupportsRtscts { get; set; }
        /// <summary>
        /// WMI Property SupportsSpecialCharacters
        /// </summary>
        public uint SupportsSpecialCharacters { get; set; }
        /// <summary>
        /// WMI Property SupportsXOnXOff
        /// </summary>
        public uint SupportsXOnXOff { get; set; }
        /// <summary>
        /// WMI Property SupportsXOnXOffSet
        /// </summary>
        public uint SupportsXOnXOffSet { get; set; }
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
    }
}
