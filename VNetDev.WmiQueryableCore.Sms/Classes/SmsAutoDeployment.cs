using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AutoDeployment
    /// </summary>
    [WmiClass(Name = "SMS_AutoDeployment")]
    public class SmsAutoDeployment
    {
        /// <summary>
        /// WMI method <c>EvaluateAutoDeployment</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint EvaluateAutoDeploymentDelegate();
        /// <summary>
        /// WMI method <c>EvaluateAutoDeployment</c>.
        /// </summary>
        public EvaluateAutoDeploymentDelegate EvaluateAutoDeployment;
        
        /// <summary>
        /// WMI static method <c>EvaluateAllAutoDeployment</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint EvaluateAllAutoDeploymentDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>EvaluateAllAutoDeployment</c>.
        /// </summary>
        public static EvaluateAllAutoDeploymentDelegate EvaluateAllAutoDeployment;
        /// <summary>
        /// WMI Property AutoDeploymentEnabled
        /// </summary>
        public bool AutoDeploymentEnabled { get; set; }
        /// <summary>
        /// WMI Property AutoDeploymentID
        /// </summary>
        public int AutoDeploymentId { get; set; }
        /// <summary>
        /// WMI Property AutoDeploymentProperties
        /// </summary>
        public string AutoDeploymentProperties { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property ContentTemplate
        /// </summary>
        public string ContentTemplate { get; set; }
        /// <summary>
        /// WMI Property DeploymentTemplate
        /// </summary>
        public string DeploymentTemplate { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property IsServicingPlan
        /// </summary>
        public bool IsServicingPlan { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public int LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property LastErrorTime
        /// </summary>
        public DateTime LastErrorTime { get; set; }
        /// <summary>
        /// WMI Property LastRunTime
        /// </summary>
        public DateTime LastRunTime { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Schedule
        /// </summary>
        public string Schedule { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// WMI Property UpdateRuleXML
        /// </summary>
        public string UpdateRuleXml { get; set; }
    }
}
