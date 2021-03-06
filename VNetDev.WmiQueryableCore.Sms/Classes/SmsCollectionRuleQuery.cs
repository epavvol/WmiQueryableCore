using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionRuleQuery
    /// </summary>
    [WmiClass(Name = "SMS_CollectionRuleQuery")]
    public class SmsCollectionRuleQuery
    {
        /// <summary>
        /// WMI static method <c>ValidateQuery</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="wqlQuery">WMI Property <c>WQLQuery</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool ValidateQueryDelegate(WmiContext wmiContext, string wqlQuery = default);
        /// <summary>
        /// WMI static method <c>ValidateQuery</c>.
        /// </summary>
        public static ValidateQueryDelegate ValidateQuery;
        /// <summary>
        /// WMI Property QueryExpression
        /// </summary>
        public string QueryExpression { get; set; }
        /// <summary>
        /// WMI Property QueryID
        /// </summary>
        public uint QueryId { get; set; }
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
    }
}
