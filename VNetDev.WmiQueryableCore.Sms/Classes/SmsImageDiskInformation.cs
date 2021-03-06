using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageDiskInformation
    /// </summary>
    [WmiClass(Name = "SMS_ImageDiskInformation")]
    public class SmsImageDiskInformation
    {
        /// <summary>
        /// WMI Property DiskIndex
        /// </summary>
        public uint DiskIndex { get; set; }
        /// <summary>
        /// WMI Property DiskStyle
        /// </summary>
        public string DiskStyle { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PartitionFileSystem
        /// </summary>
        public string PartitionFileSystem { get; set; }
        /// <summary>
        /// WMI Property PartitionIndex
        /// </summary>
        public uint PartitionIndex { get; set; }
        /// <summary>
        /// WMI Property PartitionIsBoot
        /// </summary>
        public bool PartitionIsBoot { get; set; }
        /// <summary>
        /// WMI Property PartitionLabel
        /// </summary>
        public string PartitionLabel { get; set; }
        /// <summary>
        /// WMI Property PartitionOffset
        /// </summary>
        public long PartitionOffset { get; set; }
        /// <summary>
        /// WMI Property PartitionSize
        /// </summary>
        public long PartitionSize { get; set; }
        /// <summary>
        /// WMI Property PartitionStyle
        /// </summary>
        public string PartitionStyle { get; set; }
        /// <summary>
        /// WMI Property PartitionType
        /// </summary>
        public string PartitionType { get; set; }
    }
}
