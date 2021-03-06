using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UserMachineIntelligence
    /// </summary>
    [WmiClass(Name = "SMS_UserMachineIntelligence")]
    public class SmsUserMachineIntelligence
    {
        /// <summary>
        /// WMI Property ConsoleMinutes
        /// </summary>
        public uint ConsoleMinutes { get; set; }
        /// <summary>
        /// WMI Property LastLoginTime
        /// </summary>
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// WMI Property LoginCount
        /// </summary>
        public uint LoginCount { get; set; }
        /// <summary>
        /// WMI Property ResourceClientType
        /// </summary>
        public uint ResourceClientType { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceName
        /// </summary>
        public string ResourceName { get; set; }
        /// <summary>
        /// WMI Property UniqueUserName
        /// </summary>
        public string UniqueUserName { get; set; }
    }
}
