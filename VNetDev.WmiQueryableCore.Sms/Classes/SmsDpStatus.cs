using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPStatus
    /// </summary>
    [WmiClass(Name = "SMS_DPStatus")]
    public class SmsDpStatus
    {
        /// <summary>
        /// WMI Property AppCI
        /// </summary>
        public uint AppCi { get; set; }
        /// <summary>
        /// WMI Property Failed
        /// </summary>
        public uint Failed { get; set; }
        /// <summary>
        /// WMI Property Installed
        /// </summary>
        public uint Installed { get; set; }
        /// <summary>
        /// WMI Property LastUpdated
        /// </summary>
        public DateTime LastUpdated { get; set; }
        /// <summary>
        /// WMI Property PkgID
        /// </summary>
        public string PkgId { get; set; }
        /// <summary>
        /// WMI Property Retrying
        /// </summary>
        public uint Retrying { get; set; }
        /// <summary>
        /// WMI Property SoftwareName
        /// </summary>
        public string SoftwareName { get; set; }
    }
}
