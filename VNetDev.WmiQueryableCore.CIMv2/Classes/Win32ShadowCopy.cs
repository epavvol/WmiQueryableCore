using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShadowCopy
    /// </summary>
    [WmiClass(Name = "Win32_ShadowCopy")]
    public class Win32ShadowCopy
    {
        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="context">WMI Property <c>Context</c> of type <c>string</c>.</param>
        /// <param name="volume">WMI Property <c>Volume</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, string context = default, string volume = default);

        /// <summary>
        /// WMI method <c>Revert</c> describing delegate.
        /// <param name="forceDismount">WMI Property <c>ForceDismount</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RevertDelegate(bool forceDismount = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI method <c>Revert</c>.
        /// </summary>
        public RevertDelegate Revert;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ClientAccessible
        /// </summary>
        public bool ClientAccessible { get; set; }

        /// <summary>
        /// WMI Property Count
        /// </summary>
        public uint Count { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceObject
        /// </summary>
        public string DeviceObject { get; set; }

        /// <summary>
        /// WMI Property Differential
        /// </summary>
        public bool Differential { get; set; }

        /// <summary>
        /// WMI Property ExposedLocally
        /// </summary>
        public bool ExposedLocally { get; set; }

        /// <summary>
        /// WMI Property ExposedName
        /// </summary>
        public string ExposedName { get; set; }

        /// <summary>
        /// WMI Property ExposedPath
        /// </summary>
        public string ExposedPath { get; set; }

        /// <summary>
        /// WMI Property ExposedRemotely
        /// </summary>
        public bool ExposedRemotely { get; set; }

        /// <summary>
        /// WMI Property HardwareAssisted
        /// </summary>
        public bool HardwareAssisted { get; set; }

        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// WMI Property Imported
        /// </summary>
        public bool Imported { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NoAutoRelease
        /// </summary>
        public bool NoAutoRelease { get; set; }

        /// <summary>
        /// WMI Property NotSurfaced
        /// </summary>
        public bool NotSurfaced { get; set; }

        /// <summary>
        /// WMI Property NoWriters
        /// </summary>
        public bool NoWriters { get; set; }

        /// <summary>
        /// WMI Property OriginatingMachine
        /// </summary>
        public string OriginatingMachine { get; set; }

        /// <summary>
        /// WMI Property Persistent
        /// </summary>
        public bool Persistent { get; set; }

        /// <summary>
        /// WMI Property Plex
        /// </summary>
        public bool Plex { get; set; }

        /// <summary>
        /// WMI Property ProviderID
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// WMI Property ServiceMachine
        /// </summary>
        public string ServiceMachine { get; set; }

        /// <summary>
        /// WMI Property SetID
        /// </summary>
        public string SetId { get; set; }

        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Transportable
        /// </summary>
        public bool Transportable { get; set; }

        /// <summary>
        /// WMI Property VolumeName
        /// </summary>
        public string VolumeName { get; set; }
    }
}