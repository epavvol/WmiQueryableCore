using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequencePackageReference_All
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequencePackageReference_All")]
    public class SmsTaskSequencePackageReferenceAll
    {
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property RefPackageID
        /// </summary>
        public string RefPackageId { get; set; }
    }
}
