using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIContentFiles
    /// </summary>
    [WmiClass(Name = "SMS_CIContentFiles")]
    public class SmsCiContentFiles
    {
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContentID
        /// </summary>
        public uint ContentId { get; set; }
        /// <summary>
        /// WMI Property FileHash
        /// </summary>
        public string FileHash { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public long FileSize { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property ImportPath
        /// </summary>
        public string ImportPath { get; set; }
        /// <summary>
        /// WMI Property IsSigned
        /// </summary>
        public bool IsSigned { get; set; }
        /// <summary>
        /// WMI Property LanguageID
        /// </summary>
        public uint LanguageId { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property SourceURL
        /// </summary>
        public string SourceUrl { get; set; }
    }
}
