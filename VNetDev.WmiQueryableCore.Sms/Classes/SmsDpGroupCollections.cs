using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupCollections
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupCollections")]
    public class SmsDpGroupCollections
    {
        /// <summary>
        /// WMI Property CollectionDescription
        /// </summary>
        public string CollectionDescription { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionMemberCount
        /// </summary>
        public uint CollectionMemberCount { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property GroupDescription
        /// </summary>
        public string GroupDescription { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property GroupName
        /// </summary>
        public string GroupName { get; set; }
    }
}
