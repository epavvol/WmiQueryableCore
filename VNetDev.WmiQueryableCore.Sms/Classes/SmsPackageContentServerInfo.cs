using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageContentServerInfo
    /// </summary>
    [WmiClass(Name = "SMS_PackageContentServerInfo")]
    public class SmsPackageContentServerInfo
    {
        /// <summary>
        /// WMI Property ContentServerID
        /// </summary>
        public string ContentServerId { get; set; }
        /// <summary>
        /// WMI Property ContentServerSecurityID
        /// </summary>
        public string ContentServerSecurityId { get; set; }
        /// <summary>
        /// WMI Property ContentServerType
        /// </summary>
        public uint ContentServerType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DPType
        /// </summary>
        public uint DpType { get; set; }
        /// <summary>
        /// WMI Property IsBitsEnabled
        /// </summary>
        public uint IsBitsEnabled { get; set; }
        /// <summary>
        /// WMI Property IsPeerDP
        /// </summary>
        public uint IsPeerDp { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
    }
}
