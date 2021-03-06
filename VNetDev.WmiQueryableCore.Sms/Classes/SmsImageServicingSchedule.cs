using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageServicingSchedule
    /// </summary>
    [WmiClass(Name = "SMS_ImageServicingSchedule")]
    public class SmsImageServicingSchedule
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public int Action { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property LastRunDateTime
        /// </summary>
        public DateTime LastRunDateTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property RemoveSupersededUpdates
        /// </summary>
        public bool RemoveSupersededUpdates { get; set; }
        /// <summary>
        /// WMI Property Schedule
        /// </summary>
        public string Schedule { get; set; }
        /// <summary>
        /// WMI Property ScheduleID
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// WMI Property UpdateDP
        /// </summary>
        public bool UpdateDp { get; set; }
    }
}
