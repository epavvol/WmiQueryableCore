using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SearchFolder
    /// </summary>
    [WmiClass(Name = "SMS_SearchFolder")]
    public class SmsSearchFolder
    {
        /// <summary>
        /// WMI Property FolderId
        /// </summary>
        public uint FolderId { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property IsSystem
        /// </summary>
        public bool IsSystem { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property SearchString
        /// </summary>
        public string SearchString { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
