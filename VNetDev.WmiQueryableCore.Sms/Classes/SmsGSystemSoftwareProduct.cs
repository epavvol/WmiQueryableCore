using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SoftwareProduct
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SoftwareProduct")]
    public class SmsGSystemSoftwareProduct
    {
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property ProductId
        /// </summary>
        public uint ProductId { get; set; }
        /// <summary>
        /// WMI Property ProductLanguage
        /// </summary>
        public uint ProductLanguage { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
