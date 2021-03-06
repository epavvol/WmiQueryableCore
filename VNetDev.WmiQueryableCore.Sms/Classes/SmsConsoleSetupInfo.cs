using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConsoleSetupInfo
    /// </summary>
    [WmiClass(Name = "SMS_ConsoleSetupInfo")]
    public class SmsConsoleSetupInfo
    {
        /// <summary>
        /// WMI Property ComponentTypeID
        /// </summary>
        public byte ComponentTypeId { get; set; }
        /// <summary>
        /// WMI Property FileHash
        /// </summary>
        public string FileHash { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property HashAlgorithm
        /// </summary>
        public string HashAlgorithm { get; set; }
        /// <summary>
        /// WMI Property IsSigned
        /// </summary>
        public bool IsSigned { get; set; }
    }
}
