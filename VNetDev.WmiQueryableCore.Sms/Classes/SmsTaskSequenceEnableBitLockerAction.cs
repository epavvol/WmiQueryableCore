using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_EnableBitLockerAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_EnableBitLockerAction")]
    public class SmsTaskSequenceEnableBitLockerAction
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
        /// WMI Property CreateRecoveryPassword
        /// </summary>
        public string CreateRecoveryPassword { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EncryptFullDisk
        /// </summary>
        public bool EncryptFullDisk { get; set; }
        /// <summary>
        /// WMI Property Mode
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PIN
        /// </summary>
        public string Pin { get; set; }
        /// <summary>
        /// WMI Property StartupKeyDrive
        /// </summary>
        public string StartupKeyDrive { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property TargetDrive
        /// </summary>
        public string TargetDrive { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property WaitForEncryption
        /// </summary>
        public bool WaitForEncryption { get; set; }
    }
}
