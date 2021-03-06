using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_CONFIGURATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_CONFIGURATION")]
    public class SmsGSystemPowerManagementConfiguration
    {
        /// <summary>
        /// WMI Property DurationInSec
        /// </summary>
        public uint DurationInSec { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property NonPeakPowerPlan
        /// </summary>
        public string NonPeakPowerPlan { get; set; }
        /// <summary>
        /// WMI Property NonPeakPowerPlanName
        /// </summary>
        public string NonPeakPowerPlanName { get; set; }
        /// <summary>
        /// WMI Property PeakPowerPlan
        /// </summary>
        public string PeakPowerPlan { get; set; }
        /// <summary>
        /// WMI Property PeakPowerPlanName
        /// </summary>
        public string PeakPowerPlanName { get; set; }
        /// <summary>
        /// WMI Property PeakStartTimeHoursMin
        /// </summary>
        public string PeakStartTimeHoursMin { get; set; }
        /// <summary>
        /// WMI Property PowerConfigID
        /// </summary>
        public string PowerConfigId { get; set; }
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
        /// WMI Property WakeUpTimeHoursMin
        /// </summary>
        public string WakeUpTimeHoursMin { get; set; }
    }
}
