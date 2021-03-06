using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ApplyNetworkSettingsAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ApplyNetworkSettingsAction")]
    public class SmsTaskSequenceApplyNetworkSettingsAction
    {
        /// <summary>
        /// WMI Property Adapters
        /// </summary>
        public ICollection<object> Adapters { get; set; }
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DNSDomain
        /// </summary>
        public string DnsDomain { get; set; }
        /// <summary>
        /// WMI Property DNSSuffixSearchOrder
        /// </summary>
        public ICollection<string> DnsSuffixSearchOrder { get; set; }
        /// <summary>
        /// WMI Property DomainName
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// WMI Property DomainOUName
        /// </summary>
        public string DomainOuName { get; set; }
        /// <summary>
        /// WMI Property DomainPassword
        /// </summary>
        public string DomainPassword { get; set; }
        /// <summary>
        /// WMI Property DomainUsername
        /// </summary>
        public string DomainUsername { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableTCPIPFiltering
        /// </summary>
        public bool EnableTcpipFiltering { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NetworkJoinType
        /// </summary>
        public uint NetworkJoinType { get; set; }
        /// <summary>
        /// WMI Property NumAdapters
        /// </summary>
        public uint NumAdapters { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property WorkgroupName
        /// </summary>
        public string WorkgroupName { get; set; }
    }
}
