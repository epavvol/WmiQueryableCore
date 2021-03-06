using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_NetworkAdapter
    /// </summary>
    [WmiClass(Name = "CIM_NetworkAdapter")]
    public class CimNetworkAdapter
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
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property AdapterType
        /// </summary>
        public string AdapterType { get; set; }

        /// <summary>
        /// WMI Property AdapterTypeId
        /// </summary>
        public ushort AdapterTypeId { get; set; }

        /// <summary>
        /// WMI Property AutoSense
        /// </summary>
        public bool AutoSense { get; set; }

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
        /// WMI Property GUID
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Installed
        /// </summary>
        public bool Installed { get; set; }

        /// <summary>
        /// WMI Property InterfaceIndex
        /// </summary>
        public uint InterfaceIndex { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxNumberControlled
        /// </summary>
        public uint MaxNumberControlled { get; set; }

        /// <summary>
        /// WMI Property MaxSpeed
        /// </summary>
        public ulong MaxSpeed { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NetConnectionID
        /// </summary>
        public string NetConnectionId { get; set; }

        /// <summary>
        /// WMI Property NetConnectionStatus
        /// </summary>
        public ushort NetConnectionStatus { get; set; }

        /// <summary>
        /// WMI Property NetEnabled
        /// </summary>
        public bool NetEnabled { get; set; }

        /// <summary>
        /// WMI Property NetworkAddresses
        /// </summary>
        public ICollection<string> NetworkAddresses { get; set; }

        /// <summary>
        /// WMI Property PermanentAddress
        /// </summary>
        public string PermanentAddress { get; set; }

        /// <summary>
        /// WMI Property PhysicalAdapter
        /// </summary>
        public bool PhysicalAdapter { get; set; }

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
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// WMI Property ServiceName
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// WMI Property Speed
        /// </summary>
        public ulong Speed { get; set; }

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
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }
    }
}