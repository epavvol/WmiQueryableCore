using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_SetupWindowsAndSMSAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_SetupWindowsAndSMSAction")]
    public class SmsTaskSequenceSetupWindowsAndSmsAction
    {
        /// <summary>
        /// WMI Property ClientInstallProperties
        /// </summary>
        public string ClientInstallProperties { get; set; }
        /// <summary>
        /// WMI Property ClientPackageID
        /// </summary>
        public string ClientPackageId { get; set; }
        /// <summary>
        /// WMI Property ClientPreProductionPackageID
        /// </summary>
        public string ClientPreProductionPackageId { get; set; }
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
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
    }
}
