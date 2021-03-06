using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_SummaryHistory
    /// </summary>
    [WmiClass(Name = "SMS_CH_SummaryHistory")]
    public class SmsChSummaryHistory
    {
        /// <summary>
        /// WMI Property ClientsActive
        /// </summary>
        public uint ClientsActive { get; set; }
        /// <summary>
        /// WMI Property ClientsActiveHealthyOrActiveNoResults
        /// </summary>
        public uint ClientsActiveHealthyOrActiveNoResults { get; set; }
        /// <summary>
        /// WMI Property ClientsHealthy
        /// </summary>
        public uint ClientsHealthy { get; set; }
        /// <summary>
        /// WMI Property ClientsInactive
        /// </summary>
        public uint ClientsInactive { get; set; }
        /// <summary>
        /// WMI Property ClientsRemediationSuccess
        /// </summary>
        public uint ClientsRemediationSuccess { get; set; }
        /// <summary>
        /// WMI Property ClientsRemediationTotal
        /// </summary>
        public uint ClientsRemediationTotal { get; set; }
        /// <summary>
        /// WMI Property ClientsTotal
        /// </summary>
        public uint ClientsTotal { get; set; }
        /// <summary>
        /// WMI Property ClientsUnhealthy
        /// </summary>
        public uint ClientsUnhealthy { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
