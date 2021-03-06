using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AICategory
    /// </summary>
    [WmiClass(Name = "SMS_AICategory")]
    public class SmsAiCategory
    {
        /// <summary>
        /// WMI static method <c>GetSummary</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSummaryDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSummary</c>.
        /// </summary>
        public static GetSummaryDelegate GetSummary;
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public uint CategoryId { get; set; }
        /// <summary>
        /// WMI Property CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property IsLocal
        /// </summary>
        public bool IsLocal { get; set; }
        /// <summary>
        /// WMI Property LanguageID
        /// </summary>
        public uint LanguageId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
