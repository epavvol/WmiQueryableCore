using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientAdvertisementSummary
    /// </summary>
    [WmiClass(Name = "SMS_ClientAdvertisementSummary")]
    public class SmsClientAdvertisementSummary
    {
        /// <summary>
        /// WMI Property Accepted
        /// </summary>
        public uint Accepted { get; set; }
        /// <summary>
        /// WMI Property Activity1day
        /// </summary>
        public uint Activity1day { get; set; }
        /// <summary>
        /// WMI Property Activity30days
        /// </summary>
        public uint Activity30days { get; set; }
        /// <summary>
        /// WMI Property Activity7days
        /// </summary>
        public uint Activity7days { get; set; }
        /// <summary>
        /// WMI Property AdvertFlags
        /// </summary>
        public uint AdvertFlags { get; set; }
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property AdvertisementName
        /// </summary>
        public string AdvertisementName { get; set; }
        /// <summary>
        /// WMI Property Failed
        /// </summary>
        public uint Failed { get; set; }
        /// <summary>
        /// WMI Property HealthyAccepted
        /// </summary>
        public uint HealthyAccepted { get; set; }
        /// <summary>
        /// WMI Property HealthyFailed
        /// </summary>
        public uint HealthyFailed { get; set; }
        /// <summary>
        /// WMI Property HealthyNotStarted
        /// </summary>
        public uint HealthyNotStarted { get; set; }
        /// <summary>
        /// WMI Property HealthyRetrying
        /// </summary>
        public uint HealthyRetrying { get; set; }
        /// <summary>
        /// WMI Property HealthyRunning
        /// </summary>
        public uint HealthyRunning { get; set; }
        /// <summary>
        /// WMI Property HealthySucceeded
        /// </summary>
        public uint HealthySucceeded { get; set; }
        /// <summary>
        /// WMI Property HealthyTargeted
        /// </summary>
        public uint HealthyTargeted { get; set; }
        /// <summary>
        /// WMI Property HealthyWaiting
        /// </summary>
        public uint HealthyWaiting { get; set; }
        /// <summary>
        /// WMI Property NotStarted
        /// </summary>
        public uint NotStarted { get; set; }
        /// <summary>
        /// WMI Property PackageFlags
        /// </summary>
        public uint PackageFlags { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Retrying
        /// </summary>
        public uint Retrying { get; set; }
        /// <summary>
        /// WMI Property Running
        /// </summary>
        public uint Running { get; set; }
        /// <summary>
        /// WMI Property Succeeded
        /// </summary>
        public uint Succeeded { get; set; }
        /// <summary>
        /// WMI Property Targeted
        /// </summary>
        public uint Targeted { get; set; }
        /// <summary>
        /// WMI Property Waiting
        /// </summary>
        public uint Waiting { get; set; }
    }
}
