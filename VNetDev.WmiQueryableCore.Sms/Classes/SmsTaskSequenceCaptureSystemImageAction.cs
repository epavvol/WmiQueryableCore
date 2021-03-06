using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_CaptureSystemImageAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_CaptureSystemImageAction")]
    public class SmsTaskSequenceCaptureSystemImageAction
    {
        /// <summary>
        /// WMI Property CaptureDestination
        /// </summary>
        public string CaptureDestination { get; set; }
        /// <summary>
        /// WMI Property CapturePassword
        /// </summary>
        public string CapturePassword { get; set; }
        /// <summary>
        /// WMI Property CaptureUsername
        /// </summary>
        public string CaptureUsername { get; set; }
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
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property ImageCreator
        /// </summary>
        public string ImageCreator { get; set; }
        /// <summary>
        /// WMI Property ImageDescription
        /// </summary>
        public string ImageDescription { get; set; }
        /// <summary>
        /// WMI Property ImageVersion
        /// </summary>
        public string ImageVersion { get; set; }
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
