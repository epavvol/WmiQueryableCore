using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SystemResource
    /// </summary>
    [WmiClass(Name = "CIM_SystemResource")]
    public class CimSystemResource
    {
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
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SystemVariable
        /// </summary>
        public bool SystemVariable { get; set; }

        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// WMI Property VariableValue
        /// </summary>
        public string VariableValue { get; set; }
    }
}