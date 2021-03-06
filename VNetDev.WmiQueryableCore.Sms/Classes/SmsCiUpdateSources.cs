using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIUpdateSources
    /// </summary>
    [WmiClass(Name = "SMS_CIUpdateSources")]
    public class SmsCiUpdateSources
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateModified
        /// </summary>
        public DateTime DateModified { get; set; }
        /// <summary>
        /// WMI Property MinSourceVersion
        /// </summary>
        public uint MinSourceVersion { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property UpdateSource_ID
        /// </summary>
        [WmiProperty(Name = "UpdateSource_ID")]
        public uint UpdateSourceId { get; set; }
    }
}
