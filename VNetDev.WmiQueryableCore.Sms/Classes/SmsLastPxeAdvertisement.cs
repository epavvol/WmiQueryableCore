using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_LastPXEAdvertisement
    /// </summary>
    [WmiClass(Name = "SMS_LastPXEAdvertisement")]
    public class SmsLastPxeAdvertisement
    {
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property LastPXEAdvertisementTime
        /// </summary>
        public DateTime LastPxeAdvertisementTime { get; set; }
        /// <summary>
        /// WMI Property NetbiosName
        /// </summary>
        public string NetbiosName { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SMBIOSGUID
        /// </summary>
        public string Smbiosguid { get; set; }
    }
}
