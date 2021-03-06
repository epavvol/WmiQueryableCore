using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_Reference
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_Reference")]
    public class SmsTaskSequenceReference
    {
        /// <summary>
        /// WMI Property Package
        /// </summary>
        public string Package { get; set; }
        /// <summary>
        /// WMI Property Program
        /// </summary>
        public string Program { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
