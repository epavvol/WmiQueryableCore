using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_SubTasksequence
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_SubTasksequence")]
    public class SmsTaskSequenceSubTasksequence
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property TsName
        /// </summary>
        public string TsName { get; set; }
        /// <summary>
        /// WMI Property TsPackageID
        /// </summary>
        public string TsPackageId { get; set; }
        /// <summary>
        /// WMI Property TsReferenceApplications
        /// </summary>
        public string TsReferenceApplications { get; set; }
        /// <summary>
        /// WMI Property TsReferencePackages
        /// </summary>
        public string TsReferencePackages { get; set; }
    }
}
