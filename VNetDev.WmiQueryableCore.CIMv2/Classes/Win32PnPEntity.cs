using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PnPEntity
    /// </summary>
    [WmiClass(Name = "Win32_PnPEntity")]
    public class Win32PnPEntity
    {
        /// <summary>
        /// WMI method <c>Disable</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DisableDelegate();

        /// <summary>
        /// WMI method <c>Enable</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableDelegate();

        /// <summary>
        /// WMI method <c>GetDeviceProperties</c> describing delegate.
        /// <param name="devicePropertyKeys">WMI Property <c>devicePropertyKeys</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetDevicePropertiesDelegate(ICollection<string> devicePropertyKeys = default);

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
        /// WMI method <c>Disable</c>.
        /// </summary>
        public DisableDelegate Disable;

        /// <summary>
        /// WMI method <c>Enable</c>.
        /// </summary>
        public EnableDelegate Enable;

        /// <summary>
        /// WMI method <c>GetDeviceProperties</c>.
        /// </summary>
        public GetDevicePropertiesDelegate GetDeviceProperties;

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
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ClassGuid
        /// </summary>
        public string ClassGuid { get; set; }

        /// <summary>
        /// WMI Property CompatibleID
        /// </summary>
        public ICollection<string> CompatibleId { get; set; }

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
        /// WMI Property HardwareID
        /// </summary>
        public ICollection<string> HardwareId { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PNPClass
        /// </summary>
        public string PnpClass { get; set; }

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
        /// WMI Property Present
        /// </summary>
        public bool Present { get; set; }

        /// <summary>
        /// WMI Property Service
        /// </summary>
        public string Service { get; set; }

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
    }
}