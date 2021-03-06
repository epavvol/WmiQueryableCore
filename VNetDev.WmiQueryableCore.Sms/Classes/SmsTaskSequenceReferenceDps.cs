using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequenceReferenceDps
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequenceReferenceDps")]
    public class SmsTaskSequenceReferenceDps
    {
        /// <summary>
        /// WMI Property Hash
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property ServerNALPath
        /// </summary>
        public string ServerNalPath { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceVersion
        /// </summary>
        public uint SourceVersion { get; set; }
        /// <summary>
        /// WMI Property TaskSequenceID
        /// </summary>
        public string TaskSequenceId { get; set; }
    }
}
