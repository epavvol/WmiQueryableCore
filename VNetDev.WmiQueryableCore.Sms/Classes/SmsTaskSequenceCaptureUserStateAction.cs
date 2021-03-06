using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_CaptureUserStateAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_CaptureUserStateAction")]
    public class SmsTaskSequenceCaptureUserStateAction
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
        /// WMI Property ContinueOnLockedFiles
        /// </summary>
        public bool ContinueOnLockedFiles { get; set; }
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
        /// WMI Property FileAccess
        /// </summary>
        public string FileAccess { get; set; }
        /// <summary>
        /// WMI Property Mode
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OfflineUserState
        /// </summary>
        public bool OfflineUserState { get; set; }
        /// <summary>
        /// WMI Property SkipEncryptedFiles
        /// </summary>
        public bool SkipEncryptedFiles { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property UseHardlinks
        /// </summary>
        public bool UseHardlinks { get; set; }
        /// <summary>
        /// WMI Property UsmtPackageID
        /// </summary>
        public string UsmtPackageId { get; set; }
    }
}
