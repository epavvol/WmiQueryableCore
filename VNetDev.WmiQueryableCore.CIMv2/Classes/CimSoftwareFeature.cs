using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SoftwareFeature
    /// </summary>
    [WmiClass(Name = "CIM_SoftwareFeature")]
    public class CimSoftwareFeature
    {
        /// <summary>
        /// WMI method <c>Configure</c> describing delegate.
        /// <param name="installState">WMI Property <c>InstallState</c> of type <c>ushort</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ConfigureDelegate(ushort installState = default);

        /// <summary>
        /// WMI method <c>Reinstall</c> describing delegate.
        /// <param name="reinstallMode">WMI Property <c>ReinstallMode</c> of type <c>ushort</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ReinstallDelegate(ushort reinstallMode = default);

        /// <summary>
        /// WMI method <c>Configure</c>.
        /// </summary>
        public ConfigureDelegate Configure;

        /// <summary>
        /// WMI method <c>Reinstall</c>.
        /// </summary>
        public ReinstallDelegate Reinstall;

        /// <summary>
        /// WMI Property Accesses
        /// </summary>
        public ushort Accesses { get; set; }

        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public ushort Attributes { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property IdentifyingNumber
        /// </summary>
        public string IdentifyingNumber { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InstallState
        /// </summary>
        public short InstallState { get; set; }

        /// <summary>
        /// WMI Property LastUse
        /// </summary>
        public DateTime LastUse { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}