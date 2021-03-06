using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DfsNode
    /// </summary>
    [WmiClass(Name = "Win32_DfsNode")]
    public class Win32DfsNode
    {
        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="dfsEntryPath">WMI Property <c>DfsEntryPath</c> of type <c>string</c>.</param>
        /// <param name="serverName">WMI Property <c>ServerName</c> of type <c>string</c>.</param>
        /// <param name="shareName">WMI Property <c>ShareName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, string description = default,
            string dfsEntryPath = default, string serverName = default, string shareName = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Root
        /// </summary>
        public bool Root { get; set; }

        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
    }
}