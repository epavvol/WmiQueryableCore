using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PnPDevicePropertyDateTime
    /// </summary>
    [WmiClass(Name = "Win32_PnPDevicePropertyDateTime")]
    public class Win32PnPDevicePropertyDateTime
    {
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public DateTime Data { get; set; }

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