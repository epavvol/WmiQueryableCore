using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_JoinDomainWorkgroupAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_JoinDomainWorkgroupAction")]
    public class SmsTaskSequenceJoinDomainWorkgroupAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DomainName
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// WMI Property DomainOUName
        /// </summary>
        public string DomainOuName { get; set; }
        /// <summary>
        /// WMI Property DomainPassword
        /// </summary>
        public string DomainPassword { get; set; }
        /// <summary>
        /// WMI Property DomainUsername
        /// </summary>
        public string DomainUsername { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SkipReboot
        /// </summary>
        public bool SkipReboot { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property WorkgroupName
        /// </summary>
        public string WorkgroupName { get; set; }
    }
}
