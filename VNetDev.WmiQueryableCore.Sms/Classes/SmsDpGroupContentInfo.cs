using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupContentInfo
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupContentInfo")]
    public class SmsDpGroupContentInfo
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property IsPredefinedPackage
        /// </summary>
        public bool IsPredefinedPackage { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property SourceSize
        /// </summary>
        public uint SourceSize { get; set; }
    }
}
