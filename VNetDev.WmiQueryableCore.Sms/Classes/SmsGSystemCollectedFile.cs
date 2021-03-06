using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_CollectedFile
    /// </summary>
    [WmiClass(Name = "SMS_G_System_CollectedFile")]
    public class SmsGSystemCollectedFile
    {
        /// <summary>
        /// WMI Property CollectionDate
        /// </summary>
        public DateTime CollectionDate { get; set; }
        /// <summary>
        /// WMI Property FileData
        /// </summary>
        public ICollection<byte> FileData { get; set; }
        /// <summary>
        /// WMI Property FileModifyDate
        /// </summary>
        public DateTime FileModifyDate { get; set; }
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
        public uint FileSize { get; set; }
        /// <summary>
        /// WMI Property IsDiagnostic
        /// </summary>
        public bool IsDiagnostic { get; set; }
        /// <summary>
        /// WMI Property LocalFilePath
        /// </summary>
        public string LocalFilePath { get; set; }
        /// <summary>
        /// WMI Property ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
    }
}
