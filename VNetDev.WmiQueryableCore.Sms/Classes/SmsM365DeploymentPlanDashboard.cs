using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365DeploymentPlanDashboard
    /// </summary>
    [WmiClass(Name = "SMS_M365DeploymentPlanDashboard")]
    public class SmsM365DeploymentPlanDashboard
    {
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DeploymentPlanState
        /// </summary>
        public uint DeploymentPlanState { get; set; }
        /// <summary>
        /// WMI Property M365DeploymentPlanID
        /// </summary>
        public string M365DeploymentPlanId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumDevices
        /// </summary>
        public uint NumDevices { get; set; }
        /// <summary>
        /// WMI Property PilotCollectionID
        /// </summary>
        public uint PilotCollectionId { get; set; }
        /// <summary>
        /// WMI Property PilotCollectionName
        /// </summary>
        public string PilotCollectionName { get; set; }
        /// <summary>
        /// WMI Property PilotCollectionSiteID
        /// </summary>
        public string PilotCollectionSiteId { get; set; }
        /// <summary>
        /// WMI Property ProductionCollectionID
        /// </summary>
        public uint ProductionCollectionId { get; set; }
        /// <summary>
        /// WMI Property ProductionCollectionName
        /// </summary>
        public string ProductionCollectionName { get; set; }
        /// <summary>
        /// WMI Property ProductionCollectionSiteID
        /// </summary>
        public string ProductionCollectionSiteId { get; set; }
        /// <summary>
        /// WMI Property Products
        /// </summary>
        public string Products { get; set; }
    }
}
