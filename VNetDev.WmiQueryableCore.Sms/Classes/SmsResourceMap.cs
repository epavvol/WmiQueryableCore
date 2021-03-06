using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ResourceMap
    /// </summary>
    [WmiClass(Name = "SMS_ResourceMap")]
    public class SmsResourceMap
    {
        /// <summary>
        /// WMI static method <c>Refresh</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>Refresh</c>.
        /// </summary>
        public static RefreshDelegate Refresh;
        
        /// <summary>
        /// WMI static method <c>GetClassesWithData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="history">WMI Property <c>History</c> of type <c>bool</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClassesWithDataDelegate(WmiContext wmiContext, bool history = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>GetClassesWithData</c>.
        /// </summary>
        public static GetClassesWithDataDelegate GetClassesWithData;
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property ResourceClassName
        /// </summary>
        public string ResourceClassName { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
    }
}
