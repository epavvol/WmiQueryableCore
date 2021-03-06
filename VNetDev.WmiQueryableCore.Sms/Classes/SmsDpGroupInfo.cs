using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupInfo
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupInfo")]
    public class SmsDpGroupInfo
    {
        /// <summary>
        /// WMI Property AssignedContentCount
        /// </summary>
        public uint AssignedContentCount { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public uint FeatureType { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property MembersCount
        /// </summary>
        public uint MembersCount { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public uint NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public uint NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberSuccess
        /// </summary>
        public uint NumberSuccess { get; set; }
        /// <summary>
        /// WMI Property NumberUnknown
        /// </summary>
        public uint NumberUnknown { get; set; }
    }
}
