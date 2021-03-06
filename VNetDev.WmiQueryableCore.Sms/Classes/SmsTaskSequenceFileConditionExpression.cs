using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_FileConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_FileConditionExpression")]
    public class SmsTaskSequenceFileConditionExpression
    {
        /// <summary>
        /// WMI Property DateTime
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// WMI Property DateTimeOperator
        /// </summary>
        public string DateTimeOperator { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VersionOperator
        /// </summary>
        public string VersionOperator { get; set; }
    }
}
