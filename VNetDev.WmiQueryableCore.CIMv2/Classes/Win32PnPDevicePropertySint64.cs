using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PnPDevicePropertySint64
    /// </summary>
    [WmiClass(Name = "Win32_PnPDevicePropertySint64")]
    public class Win32PnPDevicePropertySint64
    {
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public long Data { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// WMI Property KeyName
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}