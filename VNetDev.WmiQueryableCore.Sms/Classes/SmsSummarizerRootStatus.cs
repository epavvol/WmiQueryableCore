using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SummarizerRootStatus
    /// </summary>
    [WmiClass(Name = "SMS_SummarizerRootStatus")]
    public class SmsSummarizerRootStatus
    {
        /// <summary>
        /// WMI static method <c>GetTallyIntervals</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="componentName">WMI Property <c>ComponentName</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetTallyIntervalsDelegate(WmiContext wmiContext, string componentName = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>GetTallyIntervals</c>.
        /// </summary>
        public static GetTallyIntervalsDelegate GetTallyIntervals;
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
    }
}
