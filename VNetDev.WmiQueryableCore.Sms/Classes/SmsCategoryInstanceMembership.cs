using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CategoryInstanceMembership
    /// </summary>
    [WmiClass(Name = "SMS_CategoryInstanceMembership")]
    public class SmsCategoryInstanceMembership
    {
        /// <summary>
        /// WMI Property CategoryInstanceID
        /// </summary>
        public uint CategoryInstanceId { get; set; }
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
