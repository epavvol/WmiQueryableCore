using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_MSIResource
    /// </summary>
    [WmiClass(Name = "Win32_MSIResource")]
    public class Win32MsiResource
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
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// WMI Property Property
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}