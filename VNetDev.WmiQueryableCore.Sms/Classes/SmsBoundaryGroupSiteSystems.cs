using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BoundaryGroupSiteSystems
    /// </summary>
    [WmiClass(Name = "SMS_BoundaryGroupSiteSystems")]
    public class SmsBoundaryGroupSiteSystems
    {
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ServerNALPath
        /// </summary>
        public string ServerNalPath { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
