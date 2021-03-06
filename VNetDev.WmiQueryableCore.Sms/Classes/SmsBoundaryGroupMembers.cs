using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BoundaryGroupMembers
    /// </summary>
    [WmiClass(Name = "SMS_BoundaryGroupMembers")]
    public class SmsBoundaryGroupMembers
    {
        /// <summary>
        /// WMI Property BoundaryID
        /// </summary>
        public uint BoundaryId { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
    }
}
