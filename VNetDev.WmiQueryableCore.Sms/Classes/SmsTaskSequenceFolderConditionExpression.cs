using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_FolderConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_FolderConditionExpression")]
    public class SmsTaskSequenceFolderConditionExpression
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
    }
}
