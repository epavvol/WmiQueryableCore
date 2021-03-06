using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ODBCAttribute
    /// </summary>
    [WmiClass(Name = "Win32_ODBCAttribute")]
    public class Win32OdbcAttribute
    {
        /// <summary>
        /// WMI Property Attribute
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Driver
        /// </summary>
        public string Driver { get; set; }

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