using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CombinedUserResources
    /// </summary>
    [WmiClass(Name = "SMS_CombinedUserResources")]
    public class SmsCombinedUserResources
    {
        /// <summary>
        /// WMI Property CloudUserID
        /// </summary>
        public string CloudUserId { get; set; }
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
    }
}
