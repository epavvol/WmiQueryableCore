using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ApplicationSystem
    /// </summary>
    [WmiClass(Name = "CIM_ApplicationSystem")]
    public class CimApplicationSystem
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

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
        /// WMI Property NameFormat
        /// </summary>
        public string NameFormat { get; set; }

        /// <summary>
        /// WMI Property PrimaryOwnerContact
        /// </summary>
        public string PrimaryOwnerContact { get; set; }

        /// <summary>
        /// WMI Property PrimaryOwnerName
        /// </summary>
        public string PrimaryOwnerName { get; set; }

        /// <summary>
        /// WMI Property Roles
        /// </summary>
        public ICollection<string> Roles { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}