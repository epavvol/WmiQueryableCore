using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareConversionRules
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareConversionRules")]
    public class SmsSoftwareConversionRules
    {
        /// <summary>
        /// WMI Property ConvertType
        /// </summary>
        public string ConvertType { get; set; }
        /// <summary>
        /// WMI Property NewName
        /// </summary>
        public string NewName { get; set; }
        /// <summary>
        /// WMI Property OriginalName
        /// </summary>
        public string OriginalName { get; set; }
        /// <summary>
        /// WMI Property RuleId
        /// </summary>
        public uint RuleId { get; set; }
    }
}
