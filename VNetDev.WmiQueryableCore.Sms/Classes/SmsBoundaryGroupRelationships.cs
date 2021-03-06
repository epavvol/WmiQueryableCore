using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BoundaryGroupRelationships
    /// </summary>
    [WmiClass(Name = "SMS_BoundaryGroupRelationships")]
    public class SmsBoundaryGroupRelationships
    {
        /// <summary>
        /// WMI Property DestinationGroupID
        /// </summary>
        public uint DestinationGroupId { get; set; }
        /// <summary>
        /// WMI Property DestinationGroupName
        /// </summary>
        public string DestinationGroupName { get; set; }
        /// <summary>
        /// WMI Property FallbackDP
        /// </summary>
        public int FallbackDp { get; set; }
        /// <summary>
        /// WMI Property FallbackMP
        /// </summary>
        public int FallbackMp { get; set; }
        /// <summary>
        /// WMI Property FallbackSMP
        /// </summary>
        public int FallbackSmp { get; set; }
        /// <summary>
        /// WMI Property FallbackSUP
        /// </summary>
        public int FallbackSup { get; set; }
        /// <summary>
        /// WMI Property SourceGroupID
        /// </summary>
        public uint SourceGroupId { get; set; }
        /// <summary>
        /// WMI Property SourceGroupName
        /// </summary>
        public string SourceGroupName { get; set; }
    }
}
