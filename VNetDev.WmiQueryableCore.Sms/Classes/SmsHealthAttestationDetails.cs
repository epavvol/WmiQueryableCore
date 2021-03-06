using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_HealthAttestationDetails
    /// </summary>
    [WmiClass(Name = "SMS_HealthAttestationDetails")]
    public class SmsHealthAttestationDetails
    {
        /// <summary>
        /// WMI Property AIKPresent
        /// </summary>
        public uint AikPresent { get; set; }
        /// <summary>
        /// WMI Property BitlockerStatus
        /// </summary>
        public int BitlockerStatus { get; set; }
        /// <summary>
        /// WMI Property BootDebuggingEnabled
        /// </summary>
        public uint BootDebuggingEnabled { get; set; }
        /// <summary>
        /// WMI Property CertRetrievalStatus
        /// </summary>
        public uint CertRetrievalStatus { get; set; }
        /// <summary>
        /// WMI Property CodeIntegrityEnabled
        /// </summary>
        public uint CodeIntegrityEnabled { get; set; }
        /// <summary>
        /// WMI Property DateIssued
        /// </summary>
        public DateTime DateIssued { get; set; }
        /// <summary>
        /// WMI Property DEPPolicy
        /// </summary>
        public ulong DepPolicy { get; set; }
        /// <summary>
        /// WMI Property DeviceItemKey
        /// </summary>
        public uint DeviceItemKey { get; set; }
        /// <summary>
        /// WMI Property ELAMDriverLoaded
        /// </summary>
        public uint ElamDriverLoaded { get; set; }
        /// <summary>
        /// WMI Property HASSupported
        /// </summary>
        public uint HasSupported { get; set; }
        /// <summary>
        /// WMI Property OSKernelDebuggingEnabled
        /// </summary>
        public uint OsKernelDebuggingEnabled { get; set; }
        /// <summary>
        /// WMI Property SafeMode
        /// </summary>
        public uint SafeMode { get; set; }
        /// <summary>
        /// WMI Property SecureBootEnabled
        /// </summary>
        public uint SecureBootEnabled { get; set; }
        /// <summary>
        /// WMI Property TestSigningEnabled
        /// </summary>
        public uint TestSigningEnabled { get; set; }
        /// <summary>
        /// WMI Property VSMEnabled
        /// </summary>
        public uint VsmEnabled { get; set; }
        /// <summary>
        /// WMI Property WinPE
        /// </summary>
        public uint WinPe { get; set; }
    }
}
