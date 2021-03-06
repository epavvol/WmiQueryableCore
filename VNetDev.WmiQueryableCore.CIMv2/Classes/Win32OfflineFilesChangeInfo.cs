using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesChangeInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesChangeInfo")]
    public class Win32OfflineFilesChangeInfo
    {
        /// <summary>
        /// WMI Property CreatedOffline
        /// </summary>
        public bool CreatedOffline { get; set; }

        /// <summary>
        /// WMI Property DeletedOffline
        /// </summary>
        public bool DeletedOffline { get; set; }

        /// <summary>
        /// WMI Property Dirty
        /// </summary>
        public bool Dirty { get; set; }

        /// <summary>
        /// WMI Property ModifiedAttributes
        /// </summary>
        public bool ModifiedAttributes { get; set; }

        /// <summary>
        /// WMI Property ModifiedData
        /// </summary>
        public bool ModifiedData { get; set; }

        /// <summary>
        /// WMI Property ModifiedTime
        /// </summary>
        public bool ModifiedTime { get; set; }
    }
}