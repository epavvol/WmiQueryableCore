using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_RbacSecuredObject
    /// </summary>
    [WmiClass(Name = "SMS_RbacSecuredObject")]
    public class SmsRbacSecuredObject
    {
        /// <summary>
        /// WMI static method <c>UserHasPermissions</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectPath">WMI Property <c>ObjectPath</c> of type <c>object</c>.</param>
        /// <param name="permissions">WMI Property <c>Permissions</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool UserHasPermissionsDelegate(WmiContext wmiContext, object objectPath = default, uint permissions = default);
        /// <summary>
        /// WMI static method <c>UserHasPermissions</c>.
        /// </summary>
        public static UserHasPermissionsDelegate UserHasPermissions;
        
        /// <summary>
        /// WMI static method <c>GetCollectionsWithResourcePermissions</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="permissions">WMI Property <c>Permissions</c> of type <c>uint</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetCollectionsWithResourcePermissionsDelegate(WmiContext wmiContext, uint permissions = default, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>GetCollectionsWithResourcePermissions</c>.
        /// </summary>
        public static GetCollectionsWithResourcePermissionsDelegate GetCollectionsWithResourcePermissions;
        
        /// <summary>
        /// WMI static method <c>GetAvailableScopes</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="roleIDs">WMI Property <c>RoleIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="scopeTypeId">WMI Property <c>ScopeTypeID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetAvailableScopesDelegate(WmiContext wmiContext, ICollection<string> roleIDs = default, uint scopeTypeId = default);
        /// <summary>
        /// WMI static method <c>GetAvailableScopes</c>.
        /// </summary>
        public static GetAvailableScopesDelegate GetAvailableScopes;
        
        /// <summary>
        /// WMI static method <c>GetUserList</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectPath">WMI Property <c>ObjectPath</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetUserListDelegate(WmiContext wmiContext, object objectPath = default);
        /// <summary>
        /// WMI static method <c>GetUserList</c>.
        /// </summary>
        public static GetUserListDelegate GetUserList;
        /// <summary>
        /// WMI Property AvailableInstanceOperations
        /// </summary>
        public uint AvailableInstanceOperations { get; set; }
        /// <summary>
        /// WMI Property AvailableTypeOperations
        /// </summary>
        public uint AvailableTypeOperations { get; set; }
        /// <summary>
        /// WMI Property GrantedOperations
        /// </summary>
        public uint GrantedOperations { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeName
        /// </summary>
        public string ObjectTypeName { get; set; }
        /// <summary>
        /// WMI Property Operations
        /// </summary>
        public  ICollection<SmsOperation> Operations { get; set; }
    }
}
