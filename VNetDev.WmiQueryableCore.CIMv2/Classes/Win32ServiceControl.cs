using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ServiceControl
    /// </summary>
    [WmiClass(Name = "Win32_ServiceControl")]
    public class Win32ServiceControl
    {
        /// <summary>
        /// WMI Property Arguments
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Event
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property Wait
        /// </summary>
        public ushort Wait { get; set; }
    }
}