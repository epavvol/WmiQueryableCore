using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupPackages
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupPackages")]
    public class SmsDpGroupPackages
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property PkgID
        /// </summary>
        public string PkgId { get; set; }
    }
}
