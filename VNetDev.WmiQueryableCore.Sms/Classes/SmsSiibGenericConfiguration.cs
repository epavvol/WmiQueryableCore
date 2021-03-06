using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SIIB_Generic_Configuration
    /// </summary>
    [WmiClass(Name = "SMS_SIIB_Generic_Configuration")]
    public class SmsSiibGenericConfiguration
    {
        /// <summary>
        /// WMI Property ConfigurationName
        /// </summary>
        public string ConfigurationName { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsSiiPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsSiiProperty> Props { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Units
        /// </summary>
        public ICollection<string> Units { get; set; }
    }
}
