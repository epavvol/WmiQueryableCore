using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_POTSModem
    /// </summary>
    [WmiClass(Name = "Win32_POTSModem")]
    public class Win32PotsModem
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
        public ResetDelegate DoReset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property AnswerMode
        /// </summary>
        public ushort AnswerMode { get; set; }

        /// <summary>
        /// WMI Property AttachedTo
        /// </summary>
        public string AttachedTo { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BlindOff
        /// </summary>
        public string BlindOff { get; set; }

        /// <summary>
        /// WMI Property BlindOn
        /// </summary>
        public string BlindOn { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CompatibilityFlags
        /// </summary>
        public string CompatibilityFlags { get; set; }

        /// <summary>
        /// WMI Property CompressionInfo
        /// </summary>
        public ushort CompressionInfo { get; set; }

        /// <summary>
        /// WMI Property CompressionOff
        /// </summary>
        public string CompressionOff { get; set; }

        /// <summary>
        /// WMI Property CompressionOn
        /// </summary>
        public string CompressionOn { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property ConfigurationDialog
        /// </summary>
        public string ConfigurationDialog { get; set; }

        /// <summary>
        /// WMI Property CountriesSupported
        /// </summary>
        public ICollection<string> CountriesSupported { get; set; }

        /// <summary>
        /// WMI Property CountrySelected
        /// </summary>
        public string CountrySelected { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentPasswords
        /// </summary>
        public ICollection<string> CurrentPasswords { get; set; }

        /// <summary>
        /// WMI Property DCB
        /// </summary>
        public ICollection<byte> Dcb { get; set; }

        /// <summary>
        /// WMI Property Default
        /// </summary>
        public ICollection<byte> Default { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property DeviceLoader
        /// </summary>
        public string DeviceLoader { get; set; }

        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// WMI Property DialType
        /// </summary>
        public ushort DialType { get; set; }

        /// <summary>
        /// WMI Property DriverDate
        /// </summary>
        public DateTime DriverDate { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorControlForced
        /// </summary>
        public string ErrorControlForced { get; set; }

        /// <summary>
        /// WMI Property ErrorControlInfo
        /// </summary>
        public ushort ErrorControlInfo { get; set; }

        /// <summary>
        /// WMI Property ErrorControlOff
        /// </summary>
        public string ErrorControlOff { get; set; }

        /// <summary>
        /// WMI Property ErrorControlOn
        /// </summary>
        public string ErrorControlOn { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property FlowControlHard
        /// </summary>
        public string FlowControlHard { get; set; }

        /// <summary>
        /// WMI Property FlowControlOff
        /// </summary>
        public string FlowControlOff { get; set; }

        /// <summary>
        /// WMI Property FlowControlSoft
        /// </summary>
        public string FlowControlSoft { get; set; }

        /// <summary>
        /// WMI Property InactivityScale
        /// </summary>
        public string InactivityScale { get; set; }

        /// <summary>
        /// WMI Property InactivityTimeout
        /// </summary>
        public uint InactivityTimeout { get; set; }

        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }

        /// <summary>
        /// WMI Property IndexEx
        /// </summary>
        public string IndexEx { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property MaxBaudRateToPhone
        /// </summary>
        public uint MaxBaudRateToPhone { get; set; }

        /// <summary>
        /// WMI Property MaxBaudRateToSerialPort
        /// </summary>
        public uint MaxBaudRateToSerialPort { get; set; }

        /// <summary>
        /// WMI Property MaxNumberOfPasswords
        /// </summary>
        public ushort MaxNumberOfPasswords { get; set; }

        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// WMI Property ModemInfPath
        /// </summary>
        public string ModemInfPath { get; set; }

        /// <summary>
        /// WMI Property ModemInfSection
        /// </summary>
        public string ModemInfSection { get; set; }

        /// <summary>
        /// WMI Property ModulationBell
        /// </summary>
        public string ModulationBell { get; set; }

        /// <summary>
        /// WMI Property ModulationCCITT
        /// </summary>
        public string ModulationCcitt { get; set; }

        /// <summary>
        /// WMI Property ModulationScheme
        /// </summary>
        public ushort ModulationScheme { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PortSubClass
        /// </summary>
        public string PortSubClass { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property Prefix
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// WMI Property Properties
        /// </summary>
        public ICollection<byte> Properties { get; set; }

        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// WMI Property Pulse
        /// </summary>
        public string Pulse { get; set; }

        /// <summary>
        /// WMI Property Reset
        /// </summary>
        public string Reset { get; set; }

        /// <summary>
        /// WMI Property ResponsesKeyName
        /// </summary>
        public string ResponsesKeyName { get; set; }

        /// <summary>
        /// WMI Property RingsBeforeAnswer
        /// </summary>
        public byte RingsBeforeAnswer { get; set; }

        /// <summary>
        /// WMI Property SpeakerModeDial
        /// </summary>
        public string SpeakerModeDial { get; set; }

        /// <summary>
        /// WMI Property SpeakerModeOff
        /// </summary>
        public string SpeakerModeOff { get; set; }

        /// <summary>
        /// WMI Property SpeakerModeOn
        /// </summary>
        public string SpeakerModeOn { get; set; }

        /// <summary>
        /// WMI Property SpeakerModeSetup
        /// </summary>
        public string SpeakerModeSetup { get; set; }

        /// <summary>
        /// WMI Property SpeakerVolumeHigh
        /// </summary>
        public string SpeakerVolumeHigh { get; set; }

        /// <summary>
        /// WMI Property SpeakerVolumeInfo
        /// </summary>
        public ushort SpeakerVolumeInfo { get; set; }

        /// <summary>
        /// WMI Property SpeakerVolumeLow
        /// </summary>
        public string SpeakerVolumeLow { get; set; }

        /// <summary>
        /// WMI Property SpeakerVolumeMed
        /// </summary>
        public string SpeakerVolumeMed { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property StringFormat
        /// </summary>
        public string StringFormat { get; set; }

        /// <summary>
        /// WMI Property SupportsCallback
        /// </summary>
        public bool SupportsCallback { get; set; }

        /// <summary>
        /// WMI Property SupportsSynchronousConnect
        /// </summary>
        public bool SupportsSynchronousConnect { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property Terminator
        /// </summary>
        public string Terminator { get; set; }

        /// <summary>
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }

        /// <summary>
        /// WMI Property Tone
        /// </summary>
        public string Tone { get; set; }

        /// <summary>
        /// WMI Property VoiceSwitchFeature
        /// </summary>
        public string VoiceSwitchFeature { get; set; }
    }
}