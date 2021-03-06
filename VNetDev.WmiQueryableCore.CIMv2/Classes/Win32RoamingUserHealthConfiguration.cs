using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_RoamingUserHealthConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_RoamingUserHealthConfiguration")]
    public class Win32RoamingUserHealthConfiguration
    {
        /// <summary>
        /// WMI Property HealthStatusForTempProfiles
        /// </summary>
        public byte HealthStatusForTempProfiles { get; set; }

        /// <summary>
        /// WMI Property LastProfileDownloadIntervalCautionInHours
        /// </summary>
        public ushort LastProfileDownloadIntervalCautionInHours { get; set; }

        /// <summary>
        /// WMI Property LastProfileDownloadIntervalUnhealthyInHours
        /// </summary>
        public ushort LastProfileDownloadIntervalUnhealthyInHours { get; set; }

        /// <summary>
        /// WMI Property LastProfileUploadIntervalCautionInHours
        /// </summary>
        public ushort LastProfileUploadIntervalCautionInHours { get; set; }

        /// <summary>
        /// WMI Property LastProfileUploadIntervalUnhealthyInHours
        /// </summary>
        public ushort LastProfileUploadIntervalUnhealthyInHours { get; set; }
    }
}