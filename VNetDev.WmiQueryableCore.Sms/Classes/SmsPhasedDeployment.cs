using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PhasedDeployment
    /// </summary>
    [WmiClass(Name = "SMS_PhasedDeployment")]
    public class SmsPhasedDeployment
    {
        /// <summary>
        /// WMI static method <c>InsertUpdatePhasedDeployment</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="action">WMI Property <c>Action</c> of type <c>uint</c>.</param>
        /// <param name="deploymentObjectId">WMI Property <c>DeploymentObjectID</c> of type <c>string</c>.</param>
        /// <param name="deploymentObjectType">WMI Property <c>DeploymentObjectType</c> of type <c>uint</c>.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="evaluatePhasedDeployment">WMI Property <c>EvaluatePhasedDeployment</c> of type <c>uint</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="phasedDeploymentDigest">WMI Property <c>PhasedDeploymentDigest</c> of type <c>string</c>.</param>
        /// <param name="phasedDeploymentId">WMI Property <c>PhasedDeploymentID</c> of type <c>string</c>.</param>
        /// <param name="version">WMI Property <c>Version</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InsertUpdatePhasedDeploymentDelegate(WmiContext wmiContext, uint action = default, string deploymentObjectId = default, uint deploymentObjectType = default, string description = default, uint evaluatePhasedDeployment = default, string name = default, string phasedDeploymentDigest = default, string phasedDeploymentId = default, uint version = default);
        /// <summary>
        /// WMI static method <c>InsertUpdatePhasedDeployment</c>.
        /// </summary>
        public static InsertUpdatePhasedDeploymentDelegate InsertUpdatePhasedDeployment;
        
        /// <summary>
        /// WMI static method <c>RetrievePODIDFromDeploymentID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deploymentId">WMI Property <c>deploymentID</c> of type <c>string</c>.</param>
        /// <param name="featureType">WMI Property <c>featureType</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RetrievePodidFromDeploymentIdDelegate(WmiContext wmiContext, string deploymentId = default, uint featureType = default);
        /// <summary>
        /// WMI static method <c>RetrievePODIDFromDeploymentID</c>.
        /// </summary>
        public static RetrievePodidFromDeploymentIdDelegate RetrievePodidFromDeploymentId;
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public int Action { get; set; }
        /// <summary>
        /// WMI Property DeploymentObjectID
        /// </summary>
        public string DeploymentObjectId { get; set; }
        /// <summary>
        /// WMI Property DeploymentObjectType
        /// </summary>
        public int DeploymentObjectType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property EvaluatePhasedDeployment
        /// </summary>
        public int EvaluatePhasedDeployment { get; set; }
        /// <summary>
        /// WMI Property LastEvaluateTime
        /// </summary>
        public DateTime LastEvaluateTime { get; set; }
        /// <summary>
        /// WMI Property LastModifiedTime
        /// </summary>
        public DateTime LastModifiedTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PhasedDeploymentDigest
        /// </summary>
        public string PhasedDeploymentDigest { get; set; }
        /// <summary>
        /// WMI Property PhasedDeploymentID
        /// </summary>
        public string PhasedDeploymentId { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public int Version { get; set; }
    }
}
