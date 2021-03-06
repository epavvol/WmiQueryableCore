using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_PartitionSettings
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_PartitionSettings")]
    public class SmsTaskSequencePartitionSettings
    {
        /// <summary>
        /// WMI Property AssignVolumeLetter
        /// </summary>
        public bool AssignVolumeLetter { get; set; }
        /// <summary>
        /// WMI Property Bootable
        /// </summary>
        public bool Bootable { get; set; }
        /// <summary>
        /// WMI Property FileSystem
        /// </summary>
        public string FileSystem { get; set; }
        /// <summary>
        /// WMI Property QuickFormat
        /// </summary>
        public bool QuickFormat { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public uint Size { get; set; }
        /// <summary>
        /// WMI Property SizeUnits
        /// </summary>
        public string SizeUnits { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// WMI Property VolumeLetterVariable
        /// </summary>
        public string VolumeLetterVariable { get; set; }
        /// <summary>
        /// WMI Property VolumeName
        /// </summary>
        public string VolumeName { get; set; }
    }
}
