using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AIMLSParser
    /// </summary>
    [WmiClass(Name = "SMS_AIMLSParser")]
    public class SmsAimlsParser
    {
        /// <summary>
        /// WMI static method <c>Import</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="mlsFilepath">WMI Property <c>MLSFilepath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportDelegate(WmiContext wmiContext, uint flags = default, string mlsFilepath = default);
        /// <summary>
        /// WMI static method <c>Import</c>.
        /// </summary>
        public static ImportDelegate Import;
        
        /// <summary>
        /// WMI static method <c>GetStatus</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetStatusDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetStatus</c>.
        /// </summary>
        public static GetStatusDelegate GetStatus;
        
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
    }
}
