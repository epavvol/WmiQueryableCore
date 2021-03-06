using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_CAPABILITIES
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_CAPABILITIES")]
    public class SmsGSystemPowerManagementCapabilities
    {
        /// <summary>
        /// WMI Property ApmPresent
        /// </summary>
        public uint ApmPresent { get; set; }
        /// <summary>
        /// WMI Property BatteriesAreShortTerm
        /// </summary>
        public uint BatteriesAreShortTerm { get; set; }
        /// <summary>
        /// WMI Property FullWake
        /// </summary>
        public uint FullWake { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LidPresent
        /// </summary>
        public uint LidPresent { get; set; }
        /// <summary>
        /// WMI Property MinDeviceWakeState
        /// </summary>
        public string MinDeviceWakeState { get; set; }
        /// <summary>
        /// WMI Property PreferredPMProfile
        /// </summary>
        public uint PreferredPmProfile { get; set; }
        /// <summary>
        /// WMI Property ProcessorThrottle
        /// </summary>
        public uint ProcessorThrottle { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property RtcWake
        /// </summary>
        public string RtcWake { get; set; }
        /// <summary>
        /// WMI Property SystemBatteriesPresent
        /// </summary>
        public uint SystemBatteriesPresent { get; set; }
        /// <summary>
        /// WMI Property SystemS1
        /// </summary>
        public uint SystemS1 { get; set; }
        /// <summary>
        /// WMI Property SystemS2
        /// </summary>
        public uint SystemS2 { get; set; }
        /// <summary>
        /// WMI Property SystemS3
        /// </summary>
        public uint SystemS3 { get; set; }
        /// <summary>
        /// WMI Property SystemS4
        /// </summary>
        public uint SystemS4 { get; set; }
        /// <summary>
        /// WMI Property SystemS5
        /// </summary>
        public uint SystemS5 { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UpsPresent
        /// </summary>
        public uint UpsPresent { get; set; }
        /// <summary>
        /// WMI Property VideoDimPresent
        /// </summary>
        public uint VideoDimPresent { get; set; }
    }
}
