using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupMembers
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupMembers")]
    public class SmsDpGroupMembers
    {
        /// <summary>
        /// WMI Property DPNALPath
        /// </summary>
        public string DpnalPath { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
    }
}
