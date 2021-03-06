using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ContextMethods
    /// </summary>
    [WmiClass(Name = "SMS_ContextMethods")]
    public class SmsContextMethods
    {
        /// <summary>
        /// WMI static method <c>GetContextHandle</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetContextHandleDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetContextHandle</c>.
        /// </summary>
        public static GetContextHandleDelegate GetContextHandle;
        
        /// <summary>
        /// WMI static method <c>ClearContextHandle</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="contextHandle">WMI Property <c>ContextHandle</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearContextHandleDelegate(WmiContext wmiContext, string contextHandle = default);
        /// <summary>
        /// WMI static method <c>ClearContextHandle</c>.
        /// </summary>
        public static ClearContextHandleDelegate ClearContextHandle;
    }
}
