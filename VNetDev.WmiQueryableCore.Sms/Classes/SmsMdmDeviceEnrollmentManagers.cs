using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMDeviceEnrollmentManagers
    /// </summary>
    [WmiClass(Name = "SMS_MDMDeviceEnrollmentManagers")]
    public class SmsMdmDeviceEnrollmentManagers
    {
        /// <summary>
        /// WMI static method <c>InsertMultipleResourceIds</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceIds">WMI Property <c>ResourceIds</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InsertMultipleResourceIdsDelegate(WmiContext wmiContext, ICollection<uint> resourceIds = default);
        /// <summary>
        /// WMI static method <c>InsertMultipleResourceIds</c>.
        /// </summary>
        public static InsertMultipleResourceIdsDelegate InsertMultipleResourceIds;
        
        /// <summary>
        /// WMI static method <c>RemoveMultipleResourceIds</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceIds">WMI Property <c>ResourceIds</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveMultipleResourceIdsDelegate(WmiContext wmiContext, ICollection<uint> resourceIds = default);
        /// <summary>
        /// WMI static method <c>RemoveMultipleResourceIds</c>.
        /// </summary>
        public static RemoveMultipleResourceIdsDelegate RemoveMultipleResourceIds;
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
