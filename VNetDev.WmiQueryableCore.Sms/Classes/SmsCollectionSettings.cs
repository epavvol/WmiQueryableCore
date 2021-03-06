using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionSettings
    /// </summary>
    [WmiClass(Name = "SMS_CollectionSettings")]
    public class SmsCollectionSettings
    {
        /// <summary>
        /// WMI Property AMTAutoProvisionEnabled
        /// </summary>
        public bool AmtAutoProvisionEnabled { get; set; }
        /// <summary>
        /// WMI Property ClusterCount
        /// </summary>
        public uint ClusterCount { get; set; }
        /// <summary>
        /// WMI Property ClusterPercentage
        /// </summary>
        public uint ClusterPercentage { get; set; }
        /// <summary>
        /// WMI Property ClusterTimeout
        /// </summary>
        public uint ClusterTimeout { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionVariablePrecedence
        /// </summary>
        public uint CollectionVariablePrecedence { get; set; }
        /// <summary>
        /// WMI Property CollectionVariables
        /// </summary>
        public ICollection<object> CollectionVariables { get; set; }
        /// <summary>
        /// WMI Property LastModificationTime
        /// </summary>
        public DateTime LastModificationTime { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property PollingInterval
        /// </summary>
        public uint PollingInterval { get; set; }
        /// <summary>
        /// WMI Property PollingIntervalEnabled
        /// </summary>
        public bool PollingIntervalEnabled { get; set; }
        /// <summary>
        /// WMI Property PostAction
        /// </summary>
        public string PostAction { get; set; }
        /// <summary>
        /// WMI Property PowerConfigs
        /// </summary>
        public ICollection<object> PowerConfigs { get; set; }
        /// <summary>
        /// WMI Property PreAction
        /// </summary>
        public string PreAction { get; set; }
        /// <summary>
        /// WMI Property RebootCountdown
        /// </summary>
        public uint RebootCountdown { get; set; }
        /// <summary>
        /// WMI Property RebootCountdownEnabled
        /// </summary>
        public bool RebootCountdownEnabled { get; set; }
        /// <summary>
        /// WMI Property RebootCountdownFinalWindow
        /// </summary>
        public uint RebootCountdownFinalWindow { get; set; }
        /// <summary>
        /// WMI Property ServiceWindows
        /// </summary>
        public ICollection<object> ServiceWindows { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property UseCluster
        /// </summary>
        public uint UseCluster { get; set; }
        /// <summary>
        /// WMI Property UseClusterPercentage
        /// </summary>
        public uint UseClusterPercentage { get; set; }
    }
}
