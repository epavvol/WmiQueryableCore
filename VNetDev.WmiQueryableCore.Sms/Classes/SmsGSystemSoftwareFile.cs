using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SoftwareFile
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SoftwareFile")]
    public class SmsGSystemSoftwareFile
    {
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property FileCount
        /// </summary>
        public uint FileCount { get; set; }
        /// <summary>
        /// WMI Property FileDescription
        /// </summary>
        public string FileDescription { get; set; }
        /// <summary>
        /// WMI Property FileID
        /// </summary>
        public long FileId { get; set; }
        /// <summary>
        /// WMI Property FileModifiedDate
        /// </summary>
        public DateTime FileModifiedDate { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FilePath
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public long FileSize { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// WMI Property ProductId
        /// </summary>
        public uint ProductId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
