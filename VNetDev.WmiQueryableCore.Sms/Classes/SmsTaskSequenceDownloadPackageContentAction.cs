using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_DownloadPackageContentAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_DownloadPackageContentAction")]
    public class SmsTaskSequenceDownloadPackageContentAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueDownloadOnError
        /// </summary>
        public bool ContinueDownloadOnError { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DestinationCustomPath
        /// </summary>
        public string DestinationCustomPath { get; set; }
        /// <summary>
        /// WMI Property DestinationLocationType
        /// </summary>
        public string DestinationLocationType { get; set; }
        /// <summary>
        /// WMI Property DestinationVariable
        /// </summary>
        public string DestinationVariable { get; set; }
        /// <summary>
        /// WMI Property DownloadPackages
        /// </summary>
        public string DownloadPackages { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumPackages
        /// </summary>
        public uint NumPackages { get; set; }
        /// <summary>
        /// WMI Property PackageInfo
        /// </summary>
        public ICollection<object> PackageInfo { get; set; }
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
