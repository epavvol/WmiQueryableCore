using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WhatsNewFeature
    /// </summary>
    [WmiClass(Name = "SMS_WhatsNewFeature")]
    public class SmsWhatsNewFeature
    {
        /// <summary>
        /// WMI static method <c>GetFeatures</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="localeId">WMI Property <c>LocaleID</c> of type <c>uint</c>.</param>
        /// <param name="maxMilestone">WMI Property <c>MaxMilestone</c> of type <c>uint</c>.</param>
        /// <param name="minMilestone">WMI Property <c>MinMilestone</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetFeaturesDelegate(WmiContext wmiContext, uint localeId = default, uint maxMilestone = default, uint minMilestone = default);
        /// <summary>
        /// WMI static method <c>GetFeatures</c>.
        /// </summary>
        public static GetFeaturesDelegate GetFeatures;
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Milestone
        /// </summary>
        public uint Milestone { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Scenarios
        /// </summary>
        public ICollection<object> Scenarios { get; set; }
    }
}
