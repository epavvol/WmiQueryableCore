using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientBaselineStatus
    /// </summary>
    [WmiClass(Name = "SMS_ClientBaselineStatus")]
    public class SmsClientBaselineStatus
    {
        /// <summary>
        /// WMI static method <c>GetClientBaselineStatusSummary</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="baselineType">WMI Property <c>BaselineType</c> of type <c>uint</c>.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientBaselineStatusSummaryDelegate(WmiContext wmiContext, uint baselineType = default, string collectionId = default);
        /// <summary>
        /// WMI static method <c>GetClientBaselineStatusSummary</c>.
        /// </summary>
        public static GetClientBaselineStatusSummaryDelegate GetClientBaselineStatusSummary;
        /// <summary>
        /// WMI Property BaselineType
        /// </summary>
        public uint BaselineType { get; set; }
        /// <summary>
        /// WMI Property InstalledClientVersion
        /// </summary>
        public string InstalledClientVersion { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
    }
}
