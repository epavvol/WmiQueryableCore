using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Role
    /// </summary>
    [WmiClass(Name = "SMS_Role")]
    public class SmsRole
    {
        /// <summary>
        /// WMI static method <c>ExportRole</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="roleId">WMI Property <c>RoleID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ExportRoleDelegate(WmiContext wmiContext, string roleId = default);
        /// <summary>
        /// WMI static method <c>ExportRole</c>.
        /// </summary>
        public static ExportRoleDelegate ExportRole;
        
        /// <summary>
        /// WMI static method <c>ImportRole</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="overwrittenExisted">WMI Property <c>OverwrittenExisted</c> of type <c>bool</c>.</param>
        /// <param name="rolesXml">WMI Property <c>RolesXml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportRoleDelegate(WmiContext wmiContext, bool overwrittenExisted = default, string rolesXml = default);
        /// <summary>
        /// WMI static method <c>ImportRole</c>.
        /// </summary>
        public static ImportRoleDelegate ImportRole;
        /// <summary>
        /// WMI Property CopiedFromID
        /// </summary>
        public string CopiedFromId { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// WMI Property IsBuiltIn
        /// </summary>
        public bool IsBuiltIn { get; set; }
        /// <summary>
        /// WMI Property IsSecAdminRole
        /// </summary>
        public bool IsSecAdminRole { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastModifiedDate
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property NumberOfAdmins
        /// </summary>
        public uint NumberOfAdmins { get; set; }
        /// <summary>
        /// WMI Property Operations
        /// </summary>
        public  ICollection<SmsARoleOperation> Operations { get; set; }
        /// <summary>
        /// WMI Property RoleDescription
        /// </summary>
        public string RoleDescription { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
