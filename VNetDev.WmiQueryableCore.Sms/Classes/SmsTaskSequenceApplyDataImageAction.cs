using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ApplyDataImageAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ApplyDataImageAction")]
    public class SmsTaskSequenceApplyDataImageAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DestinationDisk
        /// </summary>
        public uint DestinationDisk { get; set; }
        /// <summary>
        /// WMI Property DestinationLogicalDrive
        /// </summary>
        public string DestinationLogicalDrive { get; set; }
        /// <summary>
        /// WMI Property DestinationPartition
        /// </summary>
        public uint DestinationPartition { get; set; }
        /// <summary>
        /// WMI Property DestinationVariable
        /// </summary>
        public string DestinationVariable { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property ImageIndex
        /// </summary>
        public uint ImageIndex { get; set; }
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property WipeDestinationPartition
        /// </summary>
        public bool WipeDestinationPartition { get; set; }
    }
}
