using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_OFFICE_VBARULEVIOLATION
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_OFFICE_VBARULEVIOLATION")]
    public class SmsGehSystemOfficeVbaruleviolation
    {
        /// <summary>
        /// WMI Property FileCount
        /// </summary>
        public uint FileCount { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property OfficeApp
        /// </summary>
        public string OfficeApp { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property RuleId
        /// </summary>
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
