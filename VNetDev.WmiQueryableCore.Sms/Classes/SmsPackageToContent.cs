using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageToContent
    /// </summary>
    [WmiClass(Name = "SMS_PackageToContent")]
    public class SmsPackageToContent
    {
        /// <summary>
        /// WMI method <c>IsContentValid</c> describing delegate.
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool IsContentValidDelegate();
        /// <summary>
        /// WMI method <c>IsContentValid</c>.
        /// </summary>
        public IsContentValidDelegate IsContentValid;
        /// <summary>
        /// WMI Property ContentID
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// WMI Property ContentSubFolder
        /// </summary>
        public string ContentSubFolder { get; set; }
        /// <summary>
        /// WMI Property ContentUniqueID
        /// </summary>
        public string ContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContentVersionInPkg
        /// </summary>
        public int ContentVersionInPkg { get; set; }
        /// <summary>
        /// WMI Property MinPackageVersion
        /// </summary>
        public int MinPackageVersion { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property SecuredTypeID
        /// </summary>
        public uint SecuredTypeId { get; set; }
        /// <summary>
        /// WMI Property SecureObjectID
        /// </summary>
        public string SecureObjectId { get; set; }
    }
}
