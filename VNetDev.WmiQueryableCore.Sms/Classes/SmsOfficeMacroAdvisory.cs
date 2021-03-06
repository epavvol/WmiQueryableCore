using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficeMacroAdvisory
    /// </summary>
    [WmiClass(Name = "SMS_OfficeMacroAdvisory")]
    public class SmsOfficeMacroAdvisory
    {
        /// <summary>
        /// WMI Property Issue
        /// </summary>
        public string Issue { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RuleDescription
        /// </summary>
        public string RuleDescription { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public string Severity { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public string SiteId { get; set; }
    }
}
