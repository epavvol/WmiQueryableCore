using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Permission
    /// </summary>
    [WmiClass(Name = "SMS_Permission")]
    public class SmsPermission
    {
        /// <summary>
        /// WMI Property AdminID
        /// </summary>
        public uint AdminId { get; set; }
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// WMI Property CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// WMI Property CategoryTypeID
        /// </summary>
        public uint CategoryTypeId { get; set; }
        /// <summary>
        /// WMI Property GrantedToCurrentUser
        /// </summary>
        public bool GrantedToCurrentUser { get; set; }
        /// <summary>
        /// WMI Property LogonName
        /// </summary>
        public string LogonName { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
    }
}
