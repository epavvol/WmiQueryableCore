using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequencePackageReference_Flat
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequencePackageReference_Flat")]
    public class SmsTaskSequencePackageReferenceFlat
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Level
        /// </summary>
        public uint Level { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectName
        /// </summary>
        public string ObjectName { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property RefPackageID
        /// </summary>
        public string RefPackageId { get; set; }
        /// <summary>
        /// WMI Property SourceID
        /// </summary>
        public string SourceId { get; set; }
        /// <summary>
        /// WMI Property SourceSize
        /// </summary>
        public uint SourceSize { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
