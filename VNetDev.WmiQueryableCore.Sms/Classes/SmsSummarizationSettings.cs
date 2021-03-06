using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SummarizationSettings
    /// </summary>
    [WmiClass(Name = "SMS_SummarizationSettings")]
    public class SmsSummarizationSettings
    {
        /// <summary>
        /// WMI static method <c>GetSummarizationSettings</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <param name="summarizationType">WMI Property <c>SummarizationType</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSummarizationSettingsDelegate(WmiContext wmiContext, string siteCode = default, uint summarizationType = default);
        /// <summary>
        /// WMI static method <c>GetSummarizationSettings</c>.
        /// </summary>
        public static GetSummarizationSettingsDelegate GetSummarizationSettings;
        
        /// <summary>
        /// WMI static method <c>SetSummarizationSettings</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="firstIntervalMins">WMI Property <c>FirstIntervalMins</c> of type <c>uint</c>.</param>
        /// <param name="secondIntervalMins">WMI Property <c>SecondIntervalMins</c> of type <c>uint</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <param name="summarizationType">WMI Property <c>SummarizationType</c> of type <c>uint</c>.</param>
        /// <param name="thirdIntervalMins">WMI Property <c>ThirdIntervalMins</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetSummarizationSettingsDelegate(WmiContext wmiContext, uint firstIntervalMins = default, uint secondIntervalMins = default, string siteCode = default, uint summarizationType = default, uint thirdIntervalMins = default);
        /// <summary>
        /// WMI static method <c>SetSummarizationSettings</c>.
        /// </summary>
        public static SetSummarizationSettingsDelegate SetSummarizationSettings;
        /// <summary>
        /// WMI Property ComponentName
        /// </summary>
        public string ComponentName { get; set; }
    }
}
