using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_NT_EVENTLOG_FILE
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_NT_EVENTLOG_FILE")]
    public class SmsGhSystemNtEventlogFile
    {
        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }
        /// <summary>
        /// WMI Property Archive
        /// </summary>
        public uint Archive { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property Compressed
        /// </summary>
        public uint Compressed { get; set; }
        /// <summary>
        /// WMI Property CompressionMethod
        /// </summary>
        public string CompressionMethod { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Drive
        /// </summary>
        public string Drive { get; set; }
        /// <summary>
        /// WMI Property EightDotThreeFileName
        /// </summary>
        public string EightDotThreeFileName { get; set; }
        /// <summary>
        /// WMI Property Encrypted
        /// </summary>
        public uint Encrypted { get; set; }
        /// <summary>
        /// WMI Property EncryptionMethod
        /// </summary>
        public string EncryptionMethod { get; set; }
        /// <summary>
        /// WMI Property Extension
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public ulong FileSize { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// WMI Property FSName
        /// </summary>
        public string FsName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Hidden
        /// </summary>
        public uint Hidden { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property InUseCount
        /// </summary>
        public string InUseCount { get; set; }
        /// <summary>
        /// WMI Property LastAccessed
        /// </summary>
        public DateTime LastAccessed { get; set; }
        /// <summary>
        /// WMI Property LastModified
        /// </summary>
        public DateTime LastModified { get; set; }
        /// <summary>
        /// WMI Property LogfileName
        /// </summary>
        public string LogfileName { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MaxFileSize
        /// </summary>
        public uint MaxFileSize { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfRecords
        /// </summary>
        public uint NumberOfRecords { get; set; }
        /// <summary>
        /// WMI Property OverwriteOutDated
        /// </summary>
        public uint OverwriteOutDated { get; set; }
        /// <summary>
        /// WMI Property OverWritePolicy
        /// </summary>
        public string OverWritePolicy { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// WMI Property Readable
        /// </summary>
        public uint Readable { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Sources
        /// </summary>
        public string Sources { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property System
        /// </summary>
        public uint System { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property Writeable
        /// </summary>
        public uint Writeable { get; set; }
    }
}
