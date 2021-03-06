using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Boundary
    /// </summary>
    [WmiClass(Name = "SMS_Boundary")]
    public class SmsBoundary
    {
        /// <summary>
        /// WMI Property BoundaryFlags
        /// </summary>
        public uint BoundaryFlags { get; set; }
        /// <summary>
        /// WMI Property BoundaryID
        /// </summary>
        public uint BoundaryId { get; set; }
        /// <summary>
        /// WMI Property BoundaryType
        /// </summary>
        public uint BoundaryType { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedOn
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// WMI Property DefaultSiteCode
        /// </summary>
        public ICollection<string> DefaultSiteCode { get; set; }
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property GroupCount
        /// </summary>
        public uint GroupCount { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ModifiedOn
        /// </summary>
        public DateTime ModifiedOn { get; set; }
        /// <summary>
        /// WMI Property SiteSystems
        /// </summary>
        public ICollection<string> SiteSystems { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
