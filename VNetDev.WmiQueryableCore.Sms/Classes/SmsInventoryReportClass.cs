using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_InventoryReportClass
    /// </summary>
    [WmiClass(Name = "SMS_InventoryReportClass")]
    public class SmsInventoryReportClass
    {
        /// <summary>
        /// WMI Property Filter
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// WMI Property ReportProperties
        /// </summary>
        public ICollection<string> ReportProperties { get; set; }
        /// <summary>
        /// WMI Property SMSClassID
        /// </summary>
        public string SmsClassId { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
    }
}
