using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SecuredCategoryMembership
    /// </summary>
    [WmiClass(Name = "SMS_SecuredCategoryMembership")]
    public class SmsSecuredCategoryMembership
    {
        /// <summary>
        /// WMI static method <c>AddMemberships</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="categoryIDs">WMI Property <c>CategoryIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectIDs">WMI Property <c>ObjectIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectTypeIDs">WMI Property <c>ObjectTypeIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddMembershipsDelegate(WmiContext wmiContext, ICollection<string> categoryIDs = default, ICollection<string> objectIDs = default, ICollection<uint> objectTypeIDs = default);
        /// <summary>
        /// WMI static method <c>AddMemberships</c>.
        /// </summary>
        public static AddMembershipsDelegate AddMemberships;
        
        /// <summary>
        /// WMI static method <c>RemoveMemberships</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="categoryIDs">WMI Property <c>CategoryIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectIDs">WMI Property <c>ObjectIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectTypeIDs">WMI Property <c>ObjectTypeIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveMembershipsDelegate(WmiContext wmiContext, ICollection<string> categoryIDs = default, ICollection<string> objectIDs = default, ICollection<uint> objectTypeIDs = default);
        /// <summary>
        /// WMI static method <c>RemoveMemberships</c>.
        /// </summary>
        public static RemoveMembershipsDelegate RemoveMemberships;
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// WMI Property ObjectKey
        /// </summary>
        public string ObjectKey { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
    }
}
