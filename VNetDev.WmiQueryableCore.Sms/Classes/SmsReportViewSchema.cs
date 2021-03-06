using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ReportViewSchema
    /// </summary>
    [WmiClass(Name = "SMS_ReportViewSchema")]
    public class SmsReportViewSchema
    {
        /// <summary>
        /// WMI method <c>GetSampleValues</c> describing delegate.
        /// <param name="filter">WMI Property <c>Filter</c> of type <c>string</c>.</param>
        /// <param name="rangeBegin">WMI Property <c>RangeBegin</c> of type <c>uint</c>.</param>
        /// <param name="rangeEnd">WMI Property <c>RangeEnd</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetSampleValuesDelegate(string filter = default, uint rangeBegin = default, uint rangeEnd = default);
        /// <summary>
        /// WMI method <c>GetSampleValues</c>.
        /// </summary>
        public GetSampleValuesDelegate GetSampleValues;
        /// <summary>
        /// WMI Property IsStringType
        /// </summary>
        public bool IsStringType { get; set; }
        /// <summary>
        /// WMI Property ViewColumnName
        /// </summary>
        public string ViewColumnName { get; set; }
        /// <summary>
        /// WMI Property ViewName
        /// </summary>
        public string ViewName { get; set; }
    }
}
