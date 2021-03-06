using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_APermission
    /// </summary>
    [WmiClass(Name = "SMS_APermission")]
    public class SmsAPermission
    {
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
        /// WMI Property RoleID
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
    }
}
