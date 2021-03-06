using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_SiteAssignment
    /// </summary>
    [WmiClass(Name = "SMS_SCI_SiteAssignment")]
    public class SmsSciSiteAssignment
    {
        /// <summary>
        /// WMI Property AssignDetails
        /// </summary>
        public ICollection<string> AssignDetails { get; set; }
        /// <summary>
        /// WMI Property AssignTypes
        /// </summary>
        public ICollection<string> AssignTypes { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
