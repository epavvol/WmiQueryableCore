using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_MonitorResolution
    /// </summary>
    [WmiClass(Name = "CIM_MonitorResolution")]
    public class CimMonitorResolution
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
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }

        /// <summary>
        /// WMI Property MaxRefreshRate
        /// </summary>
        public uint MaxRefreshRate { get; set; }

        /// <summary>
        /// WMI Property MinRefreshRate
        /// </summary>
        public uint MinRefreshRate { get; set; }

        /// <summary>
        /// WMI Property RefreshRate
        /// </summary>
        public uint RefreshRate { get; set; }

        /// <summary>
        /// WMI Property ScanMode
        /// </summary>
        public ushort ScanMode { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }
    }
}