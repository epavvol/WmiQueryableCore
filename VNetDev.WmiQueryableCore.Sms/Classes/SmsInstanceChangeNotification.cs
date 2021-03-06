using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_InstanceChangeNotification
    /// </summary>
    [WmiClass(Name = "SMS_InstanceChangeNotification")]
    public class SmsInstanceChangeNotification
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// WMI Property ClassName
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// WMI Property InstancePath
        /// </summary>
        public object InstancePath { get; set; }
        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> SecurityDescriptor { get; set; }
        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }
    }
}
