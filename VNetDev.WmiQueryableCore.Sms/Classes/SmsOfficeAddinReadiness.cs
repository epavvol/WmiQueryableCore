using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficeAddinReadiness
    /// </summary>
    [WmiClass(Name = "SMS_OfficeAddinReadiness")]
    public class SmsOfficeAddinReadiness
    {
        /// <summary>
        /// WMI Property AddinReadiness
        /// </summary>
        public string AddinReadiness { get; set; }
        /// <summary>
        /// WMI Property AddinVersion
        /// </summary>
        public string AddinVersion { get; set; }
        /// <summary>
        /// WMI Property AdoptedVersionAvailable
        /// </summary>
        public uint AdoptedVersionAvailable { get; set; }
        /// <summary>
        /// WMI Property AdoptionStatus
        /// </summary>
        public string AdoptionStatus { get; set; }
        /// <summary>
        /// WMI Property AdoptionStatusInt
        /// </summary>
        public uint AdoptionStatusInt { get; set; }
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property DeviceCount
        /// </summary>
        public uint DeviceCount { get; set; }
        /// <summary>
        /// WMI Property EntityId
        /// </summary>
        public uint EntityId { get; set; }
        /// <summary>
        /// WMI Property FriendlyName
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// WMI Property IsFirstParty
        /// </summary>
        public uint IsFirstParty { get; set; }
        /// <summary>
        /// WMI Property IsInBox
        /// </summary>
        public uint IsInBox { get; set; }
        /// <summary>
        /// WMI Property IsNowBuiltIn
        /// </summary>
        public uint IsNowBuiltIn { get; set; }
        /// <summary>
        /// WMI Property IsPublic
        /// </summary>
        public uint IsPublic { get; set; }
        /// <summary>
        /// WMI Property IsRemovedFrom2016
        /// </summary>
        public uint IsRemovedFrom2016 { get; set; }
        /// <summary>
        /// WMI Property SupportStatementUrl
        /// </summary>
        public string SupportStatementUrl { get; set; }
        /// <summary>
        /// WMI Property SupportStatus
        /// </summary>
        public string SupportStatus { get; set; }
    }
}
