using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SOFTWARE_LICENSING_SERVICE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SOFTWARE_LICENSING_SERVICE")]
    public class SmsGehSystemSoftwareLicensingService
    {
        /// <summary>
        /// WMI Property ClientMachineID
        /// </summary>
        public string ClientMachineId { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsKeyManagementServiceMachine
        /// </summary>
        public uint IsKeyManagementServiceMachine { get; set; }
        /// <summary>
        /// WMI Property KeyManagementServiceCurrentCount
        /// </summary>
        public uint KeyManagementServiceCurrentCount { get; set; }
        /// <summary>
        /// WMI Property KeyManagementServiceMachine
        /// </summary>
        public string KeyManagementServiceMachine { get; set; }
        /// <summary>
        /// WMI Property KeyManagementServiceProductKeyID
        /// </summary>
        public string KeyManagementServiceProductKeyId { get; set; }
        /// <summary>
        /// WMI Property PolicyCacheRefreshRequired
        /// </summary>
        public uint PolicyCacheRefreshRequired { get; set; }
        /// <summary>
        /// WMI Property RequiredClientCount
        /// </summary>
        public uint RequiredClientCount { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VLActivationInterval
        /// </summary>
        public uint VlActivationInterval { get; set; }
        /// <summary>
        /// WMI Property VLRenewalInterval
        /// </summary>
        public uint VlRenewalInterval { get; set; }
    }
}
