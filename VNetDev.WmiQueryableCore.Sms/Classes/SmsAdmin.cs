using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Admin
    /// </summary>
    [WmiClass(Name = "SMS_Admin")]
    public class SmsAdmin
    {
        /// <summary>
        /// WMI static method <c>GetAdminExtendedData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetAdminExtendedDataDelegate(WmiContext wmiContext, uint type = default);
        /// <summary>
        /// WMI static method <c>GetAdminExtendedData</c>.
        /// </summary>
        public static GetAdminExtendedDataDelegate GetAdminExtendedData;
        /// <summary>
        /// WMI Property AccountType
        /// </summary>
        public uint AccountType { get; set; }
        /// <summary>
        /// WMI Property AdminID
        /// </summary>
        public uint AdminId { get; set; }
        /// <summary>
        /// WMI Property AdminSid
        /// </summary>
        public string AdminSid { get; set; }
        /// <summary>
        /// WMI Property Categories
        /// </summary>
        public ICollection<string> Categories { get; set; }
        /// <summary>
        /// WMI Property CategoryNames
        /// </summary>
        public ICollection<string> CategoryNames { get; set; }
        /// <summary>
        /// WMI Property CollectionNames
        /// </summary>
        public ICollection<string> CollectionNames { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property DistinguishedName
        /// </summary>
        public string DistinguishedName { get; set; }
        /// <summary>
        /// WMI Property ExtendedData
        /// </summary>
        public ICollection<SmsAdminExtendedData> ExtendedData { get; set; }
        /// <summary>
        /// WMI Property IsCovered
        /// </summary>
        public bool IsCovered { get; set; }
        /// <summary>
        /// WMI Property IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// WMI Property IsGroup
        /// </summary>
        public bool IsGroup { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastModifiedDate
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property LogonName
        /// </summary>
        public string LogonName { get; set; }
        /// <summary>
        /// WMI Property Permissions
        /// </summary>
        public ICollection<SmsAPermission> Permissions { get; set; }
        /// <summary>
        /// WMI Property RoleNames
        /// </summary>
        public ICollection<string> RoleNames { get; set; }
        /// <summary>
        /// WMI Property Roles
        /// </summary>
        public ICollection<string> Roles { get; set; }
        /// <summary>
        /// WMI Property SKey
        /// </summary>
        public string SKey { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
