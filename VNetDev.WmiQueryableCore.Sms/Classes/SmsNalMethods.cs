using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_NAL_Methods
    /// </summary>
    [WmiClass(Name = "SMS_NAL_Methods")]
    public class SmsNalMethods
    {
        /// <summary>
        /// WMI static method <c>PackNALPath</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="displayQualifiers">WMI Property <c>DisplayQualifiers</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="nalType">WMI Property <c>NALType</c> of type <c>string</c>.</param>
        /// <param name="networkConnectionQualifiers">WMI Property <c>NetworkConnectionQualifiers</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="networkOsPath">WMI Property <c>NetworkOSPath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint PackNalPathDelegate(WmiContext wmiContext, ICollection<string> displayQualifiers = default, string nalType = default, ICollection<string> networkConnectionQualifiers = default, string networkOsPath = default);
        /// <summary>
        /// WMI static method <c>PackNALPath</c>.
        /// </summary>
        public static PackNalPathDelegate PackNalPath;
        
        /// <summary>
        /// WMI static method <c>UnPackNALPath</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nalPath">WMI Property <c>NALPath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UnPackNalPathDelegate(WmiContext wmiContext, string nalPath = default);
        /// <summary>
        /// WMI static method <c>UnPackNALPath</c>.
        /// </summary>
        public static UnPackNalPathDelegate UnPackNalPath;
    }
}
