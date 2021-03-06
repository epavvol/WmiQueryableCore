using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DefaultBoundaryGroup
    /// </summary>
    [WmiClass(Name = "SMS_DefaultBoundaryGroup")]
    public class SmsDefaultBoundaryGroup
    {
        /// <summary>
        /// WMI method <c>AddBoundary</c> describing delegate.
        /// <param name="boundaryId">WMI Property <c>BoundaryID</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddBoundaryDelegate(ICollection<uint> boundaryId = default);
        /// <summary>
        /// WMI method <c>AddBoundary</c>.
        /// </summary>
        public AddBoundaryDelegate AddBoundary;
        
        /// <summary>
        /// WMI method <c>RemoveBoundary</c> describing delegate.
        /// <param name="boundaryId">WMI Property <c>BoundaryID</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveBoundaryDelegate(ICollection<uint> boundaryId = default);
        /// <summary>
        /// WMI method <c>RemoveBoundary</c>.
        /// </summary>
        public RemoveBoundaryDelegate RemoveBoundary;
        
        /// <summary>
        /// WMI method <c>AddSiteSystem</c> describing delegate.
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="serverNalPath">WMI Property <c>ServerNALPath</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddSiteSystemDelegate(ICollection<uint> flags = default, ICollection<string> serverNalPath = default);
        /// <summary>
        /// WMI method <c>AddSiteSystem</c>.
        /// </summary>
        public AddSiteSystemDelegate AddSiteSystem;
        
        /// <summary>
        /// WMI method <c>RemoveSiteSystem</c> describing delegate.
        /// <param name="serverNalPath">WMI Property <c>ServerNALPath</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveSiteSystemDelegate(ICollection<string> serverNalPath = default);
        /// <summary>
        /// WMI method <c>RemoveSiteSystem</c>.
        /// </summary>
        public RemoveSiteSystemDelegate RemoveSiteSystem;
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
        public string DefaultSiteCode { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupGUID
        /// </summary>
        public string GroupGuid { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property MemberCount
        /// </summary>
        public uint MemberCount { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ModifiedOn
        /// </summary>
        public DateTime ModifiedOn { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Shared
        /// </summary>
        public bool Shared { get; set; }
        /// <summary>
        /// WMI Property SiteSystemCount
        /// </summary>
        public uint SiteSystemCount { get; set; }
    }
}
