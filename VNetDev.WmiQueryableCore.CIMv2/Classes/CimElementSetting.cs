using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ElementSetting
    /// </summary>
    [WmiClass(Name = "CIM_ElementSetting")]
    public class CimElementSetting
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}