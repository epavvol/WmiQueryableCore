using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ODBCSourceAttribute
    /// </summary>
    [WmiClass(Name = "Win32_ODBCSourceAttribute")]
    public class Win32OdbcSourceAttribute
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
        /// WMI Property DataSource
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

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