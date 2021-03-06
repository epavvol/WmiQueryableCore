using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_FullCollectionMembership
    /// </summary>
    [WmiClass(Name = "SMS_FullCollectionMembership")]
    public class SmsFullCollectionMembership
    {
        /// <summary>
        /// WMI Property AMTFullVersion
        /// </summary>
        public string AmtFullVersion { get; set; }
        /// <summary>
        /// WMI Property AMTStatus
        /// </summary>
        public uint AmtStatus { get; set; }
        /// <summary>
        /// WMI Property ClientCertType
        /// </summary>
        public uint ClientCertType { get; set; }
        /// <summary>
        /// WMI Property ClientType
        /// </summary>
        public uint ClientType { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property DeviceCategory
        /// </summary>
        public string DeviceCategory { get; set; }
        /// <summary>
        /// WMI Property DeviceOwner
        /// </summary>
        public uint DeviceOwner { get; set; }
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property IsAlwaysInternet
        /// </summary>
        public bool IsAlwaysInternet { get; set; }
        /// <summary>
        /// WMI Property IsApproved
        /// </summary>
        public uint IsApproved { get; set; }
        /// <summary>
        /// WMI Property IsAssigned
        /// </summary>
        public bool IsAssigned { get; set; }
        /// <summary>
        /// WMI Property IsBlocked
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// WMI Property IsClient
        /// </summary>
        public bool IsClient { get; set; }
        /// <summary>
        /// WMI Property IsDecommissioned
        /// </summary>
        public bool IsDecommissioned { get; set; }
        /// <summary>
        /// WMI Property IsDirect
        /// </summary>
        public bool IsDirect { get; set; }
        /// <summary>
        /// WMI Property IsInternetEnabled
        /// </summary>
        public bool IsInternetEnabled { get; set; }
        /// <summary>
        /// WMI Property IsObsolete
        /// </summary>
        public bool IsObsolete { get; set; }
        /// <summary>
        /// WMI Property IsVirtualMachine
        /// </summary>
        public bool IsVirtualMachine { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property SuppressAutoProvision
        /// </summary>
        public bool SuppressAutoProvision { get; set; }
    }
}
