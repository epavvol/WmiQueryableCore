using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_FeatureExtension
    /// </summary>
    [WmiClass(Name = "SMS_FeatureExtension")]
    public class SmsFeatureExtension
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FeatureId
        /// </summary>
        public string FeatureId { get; set; }
        /// <summary>
        /// WMI Property IsExposed
        /// </summary>
        public bool IsExposed { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
