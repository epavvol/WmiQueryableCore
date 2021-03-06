using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ProductCheck
    /// </summary>
    [WmiClass(Name = "Win32_ProductCheck")]
    public class Win32ProductCheck
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }
    }
}