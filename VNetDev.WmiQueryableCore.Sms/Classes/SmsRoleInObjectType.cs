using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_RoleInObjectType
    /// </summary>
    [WmiClass(Name = "SMS_RoleInObjectType")]
    public class SmsRoleInObjectType
    {
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public string RoleId { get; set; }
    }
}
