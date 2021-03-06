using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionBucket
    /// </summary>
    [WmiClass(Name = "SMS_CollectionBucket")]
    public class SmsCollectionBucket
    {
        /// <summary>
        /// WMI Property Bucket
        /// </summary>
        public string Bucket { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public uint FeatureType { get; set; }
    }
}
