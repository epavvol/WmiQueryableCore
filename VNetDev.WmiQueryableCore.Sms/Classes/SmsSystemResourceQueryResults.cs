using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SystemResourceQueryResults
    /// </summary>
    [WmiClass(Name = "SMS_SystemResourceQueryResults")]
    public class SmsSystemResourceQueryResults
    {
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public uint CategoryId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TaskGUID
        /// </summary>
        public string TaskGuid { get; set; }
        /// <summary>
        /// WMI Property TaskID
        /// </summary>
        public uint TaskId { get; set; }
        /// <summary>
        /// WMI Property TaskName
        /// </summary>
        public string TaskName { get; set; }
    }
}
