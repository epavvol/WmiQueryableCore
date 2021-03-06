using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Group
    /// </summary>
    [WmiClass(Name = "SMS_Group")]
    public class SmsGroup
    {
        /// <summary>
        /// WMI Property LastConnected
        /// </summary>
        public DateTime LastConnected { get; set; }
        /// <summary>
        /// WMI Property OnboardingState
        /// </summary>
        public uint OnboardingState { get; set; }
        /// <summary>
        /// WMI Property OrgId
        /// </summary>
        public string OrgId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SenseIsRunning
        /// </summary>
        public bool SenseIsRunning { get; set; }
    }
}
