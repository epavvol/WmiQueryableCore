using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MAMStoreApplication
    /// </summary>
    [WmiClass(Name = "SMS_MAMStoreApplication")]
    public class SmsMamStoreApplication
    {
        /// <summary>
        /// WMI Property IdentityIdentifier
        /// </summary>
        public string IdentityIdentifier { get; set; }
        /// <summary>
        /// WMI Property IsManagedBrowser
        /// </summary>
        public bool IsManagedBrowser { get; set; }
        /// <summary>
        /// WMI Property MAMSDKVersion
        /// </summary>
        public string MamsdkVersion { get; set; }
        /// <summary>
        /// WMI Property PinToProfile
        /// </summary>
        public bool PinToProfile { get; set; }
        /// <summary>
        /// WMI Property StoreApplicationIdentifier
        /// </summary>
        public string StoreApplicationIdentifier { get; set; }
        /// <summary>
        /// WMI Property StoreIdentifier
        /// </summary>
        public uint StoreIdentifier { get; set; }
    }
}
