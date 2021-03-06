using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_QuickFixEngineering
    /// </summary>
    [WmiClass(Name = "Win32_QuickFixEngineering")]
    public class Win32QuickFixEngineering
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CSName
        /// </summary>
        public string CsName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property FixComments
        /// </summary>
        public string FixComments { get; set; }

        /// <summary>
        /// WMI Property HotFixID
        /// </summary>
        public string HotFixId { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InstalledBy
        /// </summary>
        public string InstalledBy { get; set; }

        /// <summary>
        /// WMI Property InstalledOn
        /// </summary>
        public string InstalledOn { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ServicePackInEffect
        /// </summary>
        public string ServicePackInEffect { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}