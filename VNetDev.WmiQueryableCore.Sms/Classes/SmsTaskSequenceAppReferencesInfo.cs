using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequenceAppReferencesInfo
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequenceAppReferencesInfo")]
    public class SmsTaskSequenceAppReferencesInfo
    {
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property RefAppCI_ID
        /// </summary>
        [WmiProperty(Name = "RefAppCI_ID")]
        public int RefAppCiId { get; set; }
        /// <summary>
        /// WMI Property RefAppModelName
        /// </summary>
        public string RefAppModelName { get; set; }
        /// <summary>
        /// WMI Property RefAppPackageID
        /// </summary>
        public string RefAppPackageId { get; set; }
    }
}
