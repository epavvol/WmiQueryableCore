using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ActsAsSpare
    /// </summary>
    [WmiClass(Name = "CIM_ActsAsSpare")]
    public class CimActsAsSpare
    {
        /// <summary>
        /// WMI Property Group
        /// </summary>
        public object Group { get; set; }

        /// <summary>
        /// WMI Property HotStandby
        /// </summary>
        public bool HotStandby { get; set; }

        /// <summary>
        /// WMI Property Spare
        /// </summary>
        public object Spare { get; set; }
    }
}