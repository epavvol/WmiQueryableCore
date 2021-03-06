using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_PackageInfo
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_PackageInfo")]
    public class SmsTaskSequencePackageInfo
    {
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageId
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PkgType
        /// </summary>
        public uint PkgType { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public uint Size { get; set; }
    }
}
