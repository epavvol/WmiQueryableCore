using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OS_Details
    /// </summary>
    [WmiClass(Name = "SMS_OS_Details")]
    public class SmsOsDetails
    {
        /// <summary>
        /// WMI Property MaxVersion
        /// </summary>
        public string MaxVersion { get; set; }
        /// <summary>
        /// WMI Property MinVersion
        /// </summary>
        public string MinVersion { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Platform
        /// </summary>
        public string Platform { get; set; }
    }
}
