using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NetworkConnection
    /// </summary>
    [WmiClass(Name = "Win32_NetworkConnection")]
    public class Win32NetworkConnection
    {
        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// WMI Property ConnectionState
        /// </summary>
        public string ConnectionState { get; set; }

        /// <summary>
        /// WMI Property ConnectionType
        /// </summary>
        public string ConnectionType { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DisplayType
        /// </summary>
        public string DisplayType { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LocalName
        /// </summary>
        public string LocalName { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Persistent
        /// </summary>
        public bool Persistent { get; set; }

        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// WMI Property RemoteName
        /// </summary>
        public string RemoteName { get; set; }

        /// <summary>
        /// WMI Property RemotePath
        /// </summary>
        public string RemotePath { get; set; }

        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}