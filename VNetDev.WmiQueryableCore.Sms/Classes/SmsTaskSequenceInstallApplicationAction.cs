using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_InstallApplicationAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_InstallApplicationAction")]
    public class SmsTaskSequenceInstallApplicationAction
    {
        /// <summary>
        /// WMI Property AppInfo
        /// </summary>
        public ICollection<object> AppInfo { get; set; }
        /// <summary>
        /// WMI Property ApplicationName
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// WMI Property BaseVariableName
        /// </summary>
        public string BaseVariableName { get; set; }
        /// <summary>
        /// WMI Property ClearCache
        /// </summary>
        public bool ClearCache { get; set; }
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property ContinueOnInstallError
        /// </summary>
        public bool ContinueOnInstallError { get; set; }
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
        /// WMI Property NumApps
        /// </summary>
        public uint NumApps { get; set; }
        /// <summary>
        /// WMI Property RetryCount
        /// </summary>
        public string RetryCount { get; set; }
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
