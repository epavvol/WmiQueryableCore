using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShadowProvider
    /// </summary>
    [WmiClass(Name = "Win32_ShadowProvider")]
    public class Win32ShadowProvider
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CLSID
        /// </summary>
        public string Clsid { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property VersionID
        /// </summary>
        public string VersionId { get; set; }
    }
}