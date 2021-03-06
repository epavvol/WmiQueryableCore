using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionPermission
    /// </summary>
    [WmiClass(Name = "SMS_CollectionPermission")]
    public class SmsCollectionPermission
    {
        /// <summary>
        /// WMI Property AdminID
        /// </summary>
        public uint AdminId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
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
