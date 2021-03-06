using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceMethods
    /// </summary>
    [WmiClass(Name = "SMS_DeviceMethods")]
    public class SmsDeviceMethods
    {
        /// <summary>
        /// WMI static method <c>SyncNow</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SyncNowDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>SyncNow</c>.
        /// </summary>
        public static SyncNowDelegate SyncNow;
        
        /// <summary>
        /// WMI static method <c>RequestWipe</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="easIdentities">WMI Property <c>EASIdentities</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestWipeDelegate(WmiContext wmiContext, ICollection<string> easIdentities = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>RequestWipe</c>.
        /// </summary>
        public static RequestWipeDelegate RequestWipe;
        
        /// <summary>
        /// WMI static method <c>RequestPersistWipe</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="easIdentities">WMI Property <c>EASIdentities</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestPersistWipeDelegate(WmiContext wmiContext, ICollection<string> easIdentities = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>RequestPersistWipe</c>.
        /// </summary>
        public static RequestPersistWipeDelegate RequestPersistWipe;
        
        /// <summary>
        /// WMI static method <c>CancelWipe</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelWipeDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>CancelWipe</c>.
        /// </summary>
        public static CancelWipeDelegate CancelWipe;
        
        /// <summary>
        /// WMI static method <c>AllowAccess</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="easIdentities">WMI Property <c>EASIdentities</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AllowAccessDelegate(WmiContext wmiContext, ICollection<string> easIdentities = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>AllowAccess</c>.
        /// </summary>
        public static AllowAccessDelegate AllowAccess;
        
        /// <summary>
        /// WMI static method <c>BlockAccess</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="easIdentities">WMI Property <c>EASIdentities</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint BlockAccessDelegate(WmiContext wmiContext, ICollection<string> easIdentities = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>BlockAccess</c>.
        /// </summary>
        public static BlockAccessDelegate BlockAccess;
        
        /// <summary>
        /// WMI static method <c>RequestRetire</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestRetireDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>RequestRetire</c>.
        /// </summary>
        public static RequestRetireDelegate RequestRetire;
        
        /// <summary>
        /// WMI static method <c>CancelRetire</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelRetireDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>CancelRetire</c>.
        /// </summary>
        public static CancelRetireDelegate CancelRetire;
    }
}
