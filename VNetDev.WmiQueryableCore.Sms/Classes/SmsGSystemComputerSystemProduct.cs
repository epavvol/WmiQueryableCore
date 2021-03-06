using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_COMPUTER_SYSTEM_PRODUCT
    /// </summary>
    [WmiClass(Name = "SMS_G_System_COMPUTER_SYSTEM_PRODUCT")]
    public class SmsGSystemComputerSystemProduct
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IdentifyingNumber
        /// </summary>
        public string IdentifyingNumber { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SKUNumber
        /// </summary>
        public string SkuNumber { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UUID
        /// </summary>
        public string Uuid { get; set; }
        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
