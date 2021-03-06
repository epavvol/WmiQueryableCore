using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPStatusPerDP
    /// </summary>
    [WmiClass(Name = "SMS_DPStatusPerDP")]
    public class SmsDpStatusPerDp
    {
        /// <summary>
        /// WMI Property DPName
        /// </summary>
        public string DpName { get; set; }
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
        /// WMI Property Retrying
        /// </summary>
        public uint Retrying { get; set; }
        /// <summary>
        /// WMI Property SoftwareName
        /// </summary>
        public string SoftwareName { get; set; }
    }
}
