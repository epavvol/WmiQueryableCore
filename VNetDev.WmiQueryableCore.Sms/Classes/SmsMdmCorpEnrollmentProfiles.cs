using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMCorpEnrollmentProfiles
    /// </summary>
    [WmiClass(Name = "SMS_MDMCorpEnrollmentProfiles")]
    public class SmsMdmCorpEnrollmentProfiles
    {
        /// <summary>
        /// WMI Property ConfigurationUrl
        /// </summary>
        public string ConfigurationUrl { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property Department
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceCount
        /// </summary>
        public uint DeviceCount { get; set; }
        /// <summary>
        /// WMI Property EnrollmentProgram
        /// </summary>
        public uint EnrollmentProgram { get; set; }
        /// <summary>
        /// WMI Property IsDefault
        /// </summary>
        public uint IsDefault { get; set; }
        /// <summary>
        /// WMI Property IsUserChallenge
        /// </summary>
        public uint IsUserChallenge { get; set; }
        /// <summary>
        /// WMI Property ModifiedTime
        /// </summary>
        public DateTime ModifiedTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PlatformType
        /// </summary>
        public uint PlatformType { get; set; }
        /// <summary>
        /// WMI Property ProfileId
        /// </summary>
        public string ProfileId { get; set; }
        /// <summary>
        /// WMI Property ProfileSettings
        /// </summary>
        public string ProfileSettings { get; set; }
        /// <summary>
        /// WMI Property SupervisionMode
        /// </summary>
        public uint SupervisionMode { get; set; }
    }
}
