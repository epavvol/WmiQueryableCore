using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationJobEntityRelation
    /// </summary>
    [WmiClass(Name = "SMS_MigrationJobEntityRelation")]
    public class SmsMigrationJobEntityRelation
    {
        /// <summary>
        /// WMI Property EntityID
        /// </summary>
        public uint EntityId { get; set; }
        /// <summary>
        /// WMI Property EntityName
        /// </summary>
        public string EntityName { get; set; }
        /// <summary>
        /// WMI Property EntityRichStatus
        /// </summary>
        public int EntityRichStatus { get; set; }
        /// <summary>
        /// WMI Property EntityStatus
        /// </summary>
        public int EntityStatus { get; set; }
        /// <summary>
        /// WMI Property JobEntityStatus
        /// </summary>
        public int JobEntityStatus { get; set; }
        /// <summary>
        /// WMI Property JobID
        /// </summary>
        public uint JobId { get; set; }
        /// <summary>
        /// WMI Property MessageCode
        /// </summary>
        public int MessageCode { get; set; }
        /// <summary>
        /// WMI Property MessageDetail1
        /// </summary>
        public string MessageDetail1 { get; set; }
        /// <summary>
        /// WMI Property MessageDetail2
        /// </summary>
        public string MessageDetail2 { get; set; }
        /// <summary>
        /// WMI Property MessageDetail3
        /// </summary>
        public string MessageDetail3 { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
