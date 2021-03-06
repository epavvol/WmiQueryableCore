using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_PASSWORD
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_PASSWORD")]
    public class SmsGSystemDevicePassword
    {
        /// <summary>
        /// WMI Property AllowRecoveryPassword
        /// </summary>
        public uint AllowRecoveryPassword { get; set; }
        /// <summary>
        /// WMI Property AutolockTimeout
        /// </summary>
        public uint AutolockTimeout { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public uint Enabled { get; set; }
        /// <summary>
        /// WMI Property Expiration
        /// </summary>
        public uint Expiration { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property History
        /// </summary>
        public uint History { get; set; }
        /// <summary>
        /// WMI Property MaxAttemptsBeforeWipe
        /// </summary>
        public uint MaxAttemptsBeforeWipe { get; set; }
        /// <summary>
        /// WMI Property MinComplexChars
        /// </summary>
        public uint MinComplexChars { get; set; }
        /// <summary>
        /// WMI Property MinLength
        /// </summary>
        public uint MinLength { get; set; }
        /// <summary>
        /// WMI Property PasswordQuality
        /// </summary>
        public uint PasswordQuality { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
