using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDeploymentCollectionBucket
    /// </summary>
    [WmiClass(Name = "SMS_ClientDeploymentCollectionBucket")]
    public class SmsClientDeploymentCollectionBucket
    {
        /// <summary>
        /// WMI Property BaselineType
        /// </summary>
        public uint BaselineType { get; set; }
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
