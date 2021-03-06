using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdminUIContent
    /// </summary>
    [WmiClass(Name = "SMS_AdminUIContent")]
    public class SmsAdminUiContent
    {
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
