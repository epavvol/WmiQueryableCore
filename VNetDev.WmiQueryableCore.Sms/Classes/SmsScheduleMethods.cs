using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ScheduleMethods
    /// </summary>
    [WmiClass(Name = "SMS_ScheduleMethods")]
    public class SmsScheduleMethods
    {
        /// <summary>
        /// WMI static method <c>WriteToString</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tokenData">WMI Property <c>TokenData</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint WriteToStringDelegate(WmiContext wmiContext,  ICollection<SmsScheduleToken> tokenData = default);
        /// <summary>
        /// WMI static method <c>WriteToString</c>.
        /// </summary>
        public static WriteToStringDelegate WriteToString;
        
        /// <summary>
        /// WMI static method <c>ReadFromString</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="stringData">WMI Property <c>StringData</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReadFromStringDelegate(WmiContext wmiContext, string stringData = default);
        /// <summary>
        /// WMI static method <c>ReadFromString</c>.
        /// </summary>
        public static ReadFromStringDelegate ReadFromString;
    }
}
