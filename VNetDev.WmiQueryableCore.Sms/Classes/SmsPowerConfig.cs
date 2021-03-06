using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PowerConfig
    /// </summary>
    [WmiClass(Name = "SMS_PowerConfig")]
    public class SmsPowerConfig
    {
        /// <summary>
        /// WMI Property ConfigID
        /// </summary>
        public string ConfigId { get; set; }
        /// <summary>
        /// WMI Property DurationInSec
        /// </summary>
        public uint DurationInSec { get; set; }
        /// <summary>
        /// WMI Property NonPeakPowerPlan
        /// </summary>
        public string NonPeakPowerPlan { get; set; }
        /// <summary>
        /// WMI Property PeakPowerPlan
        /// </summary>
        public string PeakPowerPlan { get; set; }
        /// <summary>
        /// WMI Property PeakStartTimeHoursMin
        /// </summary>
        public string PeakStartTimeHoursMin { get; set; }
        /// <summary>
        /// WMI Property WakeUpTimeHoursMin
        /// </summary>
        public string WakeUpTimeHoursMin { get; set; }
    }
}
