using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionDPStatus
    /// </summary>
    [WmiClass(Name = "SMS_DistributionDPStatus")]
    public class SmsDistributionDpStatus
    {
        /// <summary>
        /// WMI Property GroupCount
        /// </summary>
        public uint GroupCount { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public ulong Id { get; set; }
        /// <summary>
        /// WMI Property InsString1
        /// </summary>
        public string InsString1 { get; set; }
        /// <summary>
        /// WMI Property InsString10
        /// </summary>
        public string InsString10 { get; set; }
        /// <summary>
        /// WMI Property InsString2
        /// </summary>
        public string InsString2 { get; set; }
        /// <summary>
        /// WMI Property InsString3
        /// </summary>
        public string InsString3 { get; set; }
        /// <summary>
        /// WMI Property InsString4
        /// </summary>
        public string InsString4 { get; set; }
        /// <summary>
        /// WMI Property InsString5
        /// </summary>
        public string InsString5 { get; set; }
        /// <summary>
        /// WMI Property InsString6
        /// </summary>
        public string InsString6 { get; set; }
        /// <summary>
        /// WMI Property InsString7
        /// </summary>
        public string InsString7 { get; set; }
        /// <summary>
        /// WMI Property InsString8
        /// </summary>
        public string InsString8 { get; set; }
        /// <summary>
        /// WMI Property InsString9
        /// </summary>
        public string InsString9 { get; set; }
        /// <summary>
        /// WMI Property IsPeerDP
        /// </summary>
        public bool IsPeerDp { get; set; }
        /// <summary>
        /// WMI Property LastStatusID
        /// </summary>
        public ulong LastStatusId { get; set; }
        /// <summary>
        /// WMI Property LastUpdateDate
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
        /// <summary>
        /// WMI Property MessageCategory
        /// </summary>
        public uint MessageCategory { get; set; }
        /// <summary>
        /// WMI Property MessageFullID
        /// </summary>
        public uint MessageFullId { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property MessageSeverity
        /// </summary>
        public uint MessageSeverity { get; set; }
        /// <summary>
        /// WMI Property MessageState
        /// </summary>
        public uint MessageState { get; set; }
        /// <summary>
        /// WMI Property NalPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
