using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShadowContext
    /// </summary>
    [WmiClass(Name = "Win32_ShadowContext")]
    public class Win32ShadowContext
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ClientAccessible
        /// </summary>
        public bool ClientAccessible { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Differential
        /// </summary>
        public bool Differential { get; set; }

        /// <summary>
        /// WMI Property ExposedLocally
        /// </summary>
        public bool ExposedLocally { get; set; }

        /// <summary>
        /// WMI Property ExposedRemotely
        /// </summary>
        public bool ExposedRemotely { get; set; }

        /// <summary>
        /// WMI Property HardwareAssisted
        /// </summary>
        public bool HardwareAssisted { get; set; }

        /// <summary>
        /// WMI Property Imported
        /// </summary>
        public bool Imported { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NoAutoRelease
        /// </summary>
        public bool NoAutoRelease { get; set; }

        /// <summary>
        /// WMI Property NotSurfaced
        /// </summary>
        public bool NotSurfaced { get; set; }

        /// <summary>
        /// WMI Property NoWriters
        /// </summary>
        public bool NoWriters { get; set; }

        /// <summary>
        /// WMI Property Persistent
        /// </summary>
        public bool Persistent { get; set; }

        /// <summary>
        /// WMI Property Plex
        /// </summary>
        public bool Plex { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property Transportable
        /// </summary>
        public bool Transportable { get; set; }
    }
}