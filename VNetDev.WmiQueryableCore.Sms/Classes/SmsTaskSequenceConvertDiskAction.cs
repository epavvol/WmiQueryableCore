using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ConvertDiskAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ConvertDiskAction")]
    public class SmsTaskSequenceConvertDiskAction
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
        /// WMI Property DiskIndex
        /// </summary>
        public uint DiskIndex { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
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
    }
}
