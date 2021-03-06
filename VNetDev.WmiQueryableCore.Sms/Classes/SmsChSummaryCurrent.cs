using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_SummaryCurrent
    /// </summary>
    [WmiClass(Name = "SMS_CH_SummaryCurrent")]
    public class SmsChSummaryCurrent
    {
        /// <summary>
        /// WMI Property ClientsActive
        /// </summary>
        public uint ClientsActive { get; set; }
        /// <summary>
        /// WMI Property ClientsHealthUnknown
        /// </summary>
        public uint ClientsHealthUnknown { get; set; }
        /// <summary>
        /// WMI Property ClientsHealthy
        /// </summary>
        public uint ClientsHealthy { get; set; }
        /// <summary>
        /// WMI Property ClientsHealthyActive
        /// </summary>
        public uint ClientsHealthyActive { get; set; }
        /// <summary>
        /// WMI Property ClientsHealthyInactive
        /// </summary>
        public uint ClientsHealthyInactive { get; set; }
        /// <summary>
        /// WMI Property ClientsInactive
        /// </summary>
        public uint ClientsInactive { get; set; }
        /// <summary>
        /// WMI Property ClientsInactiveUsingIntune
        /// </summary>
        public uint ClientsInactiveUsingIntune { get; set; }
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
        /// WMI Property ClientsUnhealthyActive
        /// </summary>
        public uint ClientsUnhealthyActive { get; set; }
        /// <summary>
        /// WMI Property ClientsUnhealthyInactive
        /// </summary>
        public uint ClientsUnhealthyInactive { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
    }
}
