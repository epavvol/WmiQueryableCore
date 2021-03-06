using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficeProplusReadiness
    /// </summary>
    [WmiClass(Name = "SMS_OfficeProplusReadiness")]
    public class SmsOfficeProplusReadiness
    {
        /// <summary>
        /// WMI Property AddinAdoptionStatus
        /// </summary>
        public uint AddinAdoptionStatus { get; set; }
        /// <summary>
        /// WMI Property AddInCompatibility
        /// </summary>
        public uint AddInCompatibility { get; set; }
        /// <summary>
        /// WMI Property AddinInventory
        /// </summary>
        public uint AddinInventory { get; set; }
        /// <summary>
        /// WMI Property AddinSupportStatus
        /// </summary>
        public uint AddinSupportStatus { get; set; }
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property MacroCompatibility
        /// </summary>
        public uint MacroCompatibility { get; set; }
        /// <summary>
        /// WMI Property MacroInventory
        /// </summary>
        public uint MacroInventory { get; set; }
        /// <summary>
        /// WMI Property MacroStatus
        /// </summary>
        public uint MacroStatus { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OfficeInstallGroup
        /// </summary>
        public uint OfficeInstallGroup { get; set; }
        /// <summary>
        /// WMI Property ReadyForProplus
        /// </summary>
        public uint ReadyForProplus { get; set; }
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
    }
}
