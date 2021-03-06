using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_RestoreUserStateAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_RestoreUserStateAction")]
    public class SmsTaskSequenceRestoreUserStateAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ConfigFiles
        /// </summary>
        public ICollection<string> ConfigFiles { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property ContinueOnRestore
        /// </summary>
        public bool ContinueOnRestore { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableVerboseLogging
        /// </summary>
        public bool EnableVerboseLogging { get; set; }
        /// <summary>
        /// WMI Property LocalAccountPassword
        /// </summary>
        public string LocalAccountPassword { get; set; }
        /// <summary>
        /// WMI Property LocalAccounts
        /// </summary>
        public bool LocalAccounts { get; set; }
        /// <summary>
        /// WMI Property Mode
        /// </summary>
        public string Mode { get; set; }
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
        /// <summary>
        /// WMI Property UsmtRestorePackageID
        /// </summary>
        public string UsmtRestorePackageId { get; set; }
    }
}
