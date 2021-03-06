using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_TPM
    /// </summary>
    [WmiClass(Name = "SMS_G_System_TPM")]
    public class SmsGSystemTpm
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsActivated_InitialValue
        /// </summary>
        [WmiProperty(Name = "IsActivated_InitialValue")]
        public uint IsActivatedInitialValue { get; set; }
        /// <summary>
        /// WMI Property IsEnabled_InitialValue
        /// </summary>
        [WmiProperty(Name = "IsEnabled_InitialValue")]
        public uint IsEnabledInitialValue { get; set; }
        /// <summary>
        /// WMI Property IsOwned_InitialValue
        /// </summary>
        [WmiProperty(Name = "IsOwned_InitialValue")]
        public uint IsOwnedInitialValue { get; set; }
        /// <summary>
        /// WMI Property ManufacturerId
        /// </summary>
        public uint ManufacturerId { get; set; }
        /// <summary>
        /// WMI Property ManufacturerVersion
        /// </summary>
        public string ManufacturerVersion { get; set; }
        /// <summary>
        /// WMI Property ManufacturerVersionInfo
        /// </summary>
        public string ManufacturerVersionInfo { get; set; }
        /// <summary>
        /// WMI Property PhysicalPresenceVersionInfo
        /// </summary>
        public string PhysicalPresenceVersionInfo { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SpecVersion
        /// </summary>
        public string SpecVersion { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
