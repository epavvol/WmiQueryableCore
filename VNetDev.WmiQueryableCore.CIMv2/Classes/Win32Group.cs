using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Group
    /// </summary>
    [WmiClass(Name = "Win32_Group")]
    public class Win32Group
    {
        /// <summary>
        /// WMI method <c>Rename</c> describing delegate.
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenameDelegate(string name = default);

        /// <summary>
        /// WMI method <c>Rename</c>.
        /// </summary>
        public RenameDelegate Rename;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LocalAccount
        /// </summary>
        public bool LocalAccount { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// WMI Property SIDType
        /// </summary>
        public byte SidType { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}