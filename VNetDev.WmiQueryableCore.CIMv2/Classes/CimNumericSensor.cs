using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_NumericSensor
    /// </summary>
    [WmiClass(Name = "CIM_NumericSensor")]
    public class CimNumericSensor
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
        /// WMI Property Accuracy
        /// </summary>
        public int Accuracy { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

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
        /// WMI Property CurrentReading
        /// </summary>
        public int CurrentReading { get; set; }

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
        /// WMI Property IsLinear
        /// </summary>
        public bool IsLinear { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property LowerThresholdCritical
        /// </summary>
        public int LowerThresholdCritical { get; set; }

        /// <summary>
        /// WMI Property LowerThresholdFatal
        /// </summary>
        public int LowerThresholdFatal { get; set; }

        /// <summary>
        /// WMI Property LowerThresholdNonCritical
        /// </summary>
        public int LowerThresholdNonCritical { get; set; }

        /// <summary>
        /// WMI Property MaxReadable
        /// </summary>
        public int MaxReadable { get; set; }

        /// <summary>
        /// WMI Property MinReadable
        /// </summary>
        public int MinReadable { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NominalReading
        /// </summary>
        public int NominalReading { get; set; }

        /// <summary>
        /// WMI Property NormalMax
        /// </summary>
        public int NormalMax { get; set; }

        /// <summary>
        /// WMI Property NormalMin
        /// </summary>
        public int NormalMin { get; set; }

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
        /// WMI Property Resolution
        /// </summary>
        public uint Resolution { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property Tolerance
        /// </summary>
        public int Tolerance { get; set; }

        /// <summary>
        /// WMI Property UpperThresholdCritical
        /// </summary>
        public int UpperThresholdCritical { get; set; }

        /// <summary>
        /// WMI Property UpperThresholdFatal
        /// </summary>
        public int UpperThresholdFatal { get; set; }

        /// <summary>
        /// WMI Property UpperThresholdNonCritical
        /// </summary>
        public int UpperThresholdNonCritical { get; set; }
    }
}