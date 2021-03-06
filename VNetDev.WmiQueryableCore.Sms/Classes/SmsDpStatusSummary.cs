using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPStatusSummary
    /// </summary>
    [WmiClass(Name = "SMS_DPStatusSummary")]
    public class SmsDpStatusSummary
    {
        /// <summary>
        /// WMI static method <c>UpdateSummaryData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateSummaryDataDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>UpdateSummaryData</c>.
        /// </summary>
        public static UpdateSummaryDataDelegate UpdateSummaryData;
        /// <summary>
        /// WMI Property DeploymentType
        /// </summary>
        public uint DeploymentType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public uint NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public uint NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberInstalled
        /// </summary>
        public uint NumberInstalled { get; set; }
        /// <summary>
        /// WMI Property NumberUnknown
        /// </summary>
        public uint NumberUnknown { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
    }
}
