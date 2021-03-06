using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SettingContext
    /// </summary>
    [WmiClass(Name = "CIM_SettingContext")]
    public class CimSettingContext
    {
        /// <summary>
        /// WMI Property Context
        /// </summary>
        public object Context { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}