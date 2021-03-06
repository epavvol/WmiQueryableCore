using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_AMT_AGENT
    /// </summary>
    [WmiClass(Name = "SMS_G_System_AMT_AGENT")]
    public class SmsGSystemAmtAgent
    {
        /// <summary>
        /// WMI Property AMT
        /// </summary>
        public string Amt { get; set; }
        /// <summary>
        /// WMI Property AMTApps
        /// </summary>
        public string AmtApps { get; set; }
        /// <summary>
        /// WMI Property BiosVersion
        /// </summary>
        public string BiosVersion { get; set; }
        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public string BuildNumber { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public uint DeviceId { get; set; }
        /// <summary>
        /// WMI Property Flash
        /// </summary>
        public string Flash { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LegacyMode
        /// </summary>
        public string LegacyMode { get; set; }
        /// <summary>
        /// WMI Property Netstack
        /// </summary>
        public string Netstack { get; set; }
        /// <summary>
        /// WMI Property ProvisionMode
        /// </summary>
        public uint ProvisionMode { get; set; }
        /// <summary>
        /// WMI Property ProvisionState
        /// </summary>
        public uint ProvisionState { get; set; }
        /// <summary>
        /// WMI Property RecoveryBuildNum
        /// </summary>
        public string RecoveryBuildNum { get; set; }
        /// <summary>
        /// WMI Property RecoveryVersion
        /// </summary>
        public string RecoveryVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Sku
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TLSMode
        /// </summary>
        public uint TlsMode { get; set; }
        /// <summary>
        /// WMI Property VendorID
        /// </summary>
        public string VendorId { get; set; }
        /// <summary>
        /// WMI Property ZTCEnabled
        /// </summary>
        public uint ZtcEnabled { get; set; }
    }
}
