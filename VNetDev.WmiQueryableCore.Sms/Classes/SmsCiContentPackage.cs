using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIContentPackage
    /// </summary>
    [WmiClass(Name = "SMS_CIContentPackage")]
    public class SmsCiContentPackage
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_SecuredTypeID
        /// </summary>
        [WmiProperty(Name = "CI_SecuredTypeID")]
        public uint CiSecuredTypeId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
    }
}
