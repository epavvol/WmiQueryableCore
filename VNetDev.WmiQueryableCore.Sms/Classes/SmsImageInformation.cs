using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageInformation
    /// </summary>
    [WmiClass(Name = "SMS_ImageInformation")]
    public class SmsImageInformation
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public uint Architecture { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public string CreationDate { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property HALType
        /// </summary>
        public string HalType { get; set; }
        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property OSVersion
        /// </summary>
        public string OsVersion { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property ProductType
        /// </summary>
        public string ProductType { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
