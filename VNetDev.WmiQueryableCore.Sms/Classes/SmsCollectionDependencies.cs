using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionDependencies
    /// </summary>
    [WmiClass(Name = "SMS_CollectionDependencies")]
    public class SmsCollectionDependencies
    {
        /// <summary>
        /// WMI Property DependentCollectionID
        /// </summary>
        public string DependentCollectionId { get; set; }
        /// <summary>
        /// WMI Property RelationshipType
        /// </summary>
        public uint RelationshipType { get; set; }
        /// <summary>
        /// WMI Property SourceCollectionID
        /// </summary>
        public string SourceCollectionId { get; set; }
    }
}
