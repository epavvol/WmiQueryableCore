using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeploymentSummary
    /// </summary>
    [WmiClass(Name = "SMS_DeploymentSummary")]
    public class SmsDeploymentSummary
    {
        /// <summary>
        /// WMI static method <c>UpdateDeployment</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="assignmentId">WMI Property <c>AssignmentID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateDeploymentDelegate(WmiContext wmiContext, uint assignmentId = default);
        /// <summary>
        /// WMI static method <c>UpdateDeployment</c>.
        /// </summary>
        public static UpdateDeploymentDelegate UpdateDeployment;
        
        /// <summary>
        /// WMI static method <c>UpdateClassicDeployment</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="offerId">WMI Property <c>OfferID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateClassicDeploymentDelegate(WmiContext wmiContext, string offerId = default);
        /// <summary>
        /// WMI static method <c>UpdateClassicDeployment</c>.
        /// </summary>
        public static UpdateClassicDeploymentDelegate UpdateClassicDeployment;
        /// <summary>
        /// WMI Property ApplicationName
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property CollectionType
        /// </summary>
        public uint CollectionType { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property DeploymentID
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// WMI Property DeploymentIntent
        /// </summary>
        public uint DeploymentIntent { get; set; }
        /// <summary>
        /// WMI Property DeploymentTime
        /// </summary>
        public DateTime DeploymentTime { get; set; }
        /// <summary>
        /// WMI Property DesiredConfigType
        /// </summary>
        public int DesiredConfigType { get; set; }
        /// <summary>
        /// WMI Property EnforcementDeadline
        /// </summary>
        public DateTime EnforcementDeadline { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public uint FeatureType { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property ModificationTime
        /// </summary>
        public DateTime ModificationTime { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public int NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public int NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberOther
        /// </summary>
        public int NumberOther { get; set; }
        /// <summary>
        /// WMI Property NumberSuccess
        /// </summary>
        public int NumberSuccess { get; set; }
        /// <summary>
        /// WMI Property NumberTargeted
        /// </summary>
        public int NumberTargeted { get; set; }
        /// <summary>
        /// WMI Property NumberUnknown
        /// </summary>
        public int NumberUnknown { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PolicyModelID
        /// </summary>
        public uint PolicyModelId { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property RequireApproval
        /// </summary>
        public uint RequireApproval { get; set; }
        /// <summary>
        /// WMI Property SecuredObjectId
        /// </summary>
        public string SecuredObjectId { get; set; }
        /// <summary>
        /// WMI Property SoftwareName
        /// </summary>
        public string SoftwareName { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
        /// <summary>
        /// WMI Property SummaryType
        /// </summary>
        public uint SummaryType { get; set; }
    }
}
