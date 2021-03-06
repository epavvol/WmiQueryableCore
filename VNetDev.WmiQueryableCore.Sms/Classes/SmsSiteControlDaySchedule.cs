using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteControlDaySchedule
    /// </summary>
    [WmiClass(Name = "SMS_SiteControlDaySchedule")]
    public class SmsSiteControlDaySchedule
    {
        /// <summary>
        /// WMI Property Backup
        /// </summary>
        public ICollection<bool> Backup { get; set; }
        /// <summary>
        /// WMI Property HourUsage
        /// </summary>
        public ICollection<uint> HourUsage { get; set; }
        /// <summary>
        /// WMI Property update
        /// </summary>
        public bool Update { get; set; }
    }
}
