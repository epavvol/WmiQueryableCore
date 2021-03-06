using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SummarizationInterval
    /// </summary>
    [WmiClass(Name = "SMS_SummarizationInterval")]
    public class SmsSummarizationInterval
    {
        /// <summary>
        /// WMI Property IntervalStart
        /// </summary>
        public DateTime IntervalStart { get; set; }
        /// <summary>
        /// WMI Property TimeKey
        /// </summary>
        public uint TimeKey { get; set; }
    }
}
