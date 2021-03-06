using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PhasedDeploymentOperationalDataPkgProgram
    /// </summary>
    [WmiClass(Name = "SMS_PhasedDeploymentOperationalDataPkgProgram")]
    public class SmsPhasedDeploymentOperationalDataPkgProgram
    {
        /// <summary>
        /// WMI Property DeploymentID
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// WMI Property PhasedDeploymentID
        /// </summary>
        public string PhasedDeploymentId { get; set; }
        /// <summary>
        /// WMI Property PhaseID
        /// </summary>
        public string PhaseId { get; set; }
        /// <summary>
        /// WMI Property PhaseName
        /// </summary>
        public string PhaseName { get; set; }
    }
}
