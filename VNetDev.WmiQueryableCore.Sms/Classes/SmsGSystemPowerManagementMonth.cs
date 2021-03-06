using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_MONTH
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_MONTH")]
    public class SmsGSystemPowerManagementMonth
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property minutesComputerActive
        /// </summary>
        public uint MinutesComputerActive { get; set; }
        /// <summary>
        /// WMI Property minutesComputerOn
        /// </summary>
        public uint MinutesComputerOn { get; set; }
        /// <summary>
        /// WMI Property minutesComputerShutdown
        /// </summary>
        public uint MinutesComputerShutdown { get; set; }
        /// <summary>
        /// WMI Property minutesComputerSleep
        /// </summary>
        public uint MinutesComputerSleep { get; set; }
        /// <summary>
        /// WMI Property minutesMonitorOn
        /// </summary>
        public uint MinutesMonitorOn { get; set; }
        /// <summary>
        /// WMI Property minutesTotal
        /// </summary>
        public uint MinutesTotal { get; set; }
        /// <summary>
        /// WMI Property MonthStart
        /// </summary>
        public DateTime MonthStart { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TypeOfEvent
        /// </summary>
        public string TypeOfEvent { get; set; }
    }
}
