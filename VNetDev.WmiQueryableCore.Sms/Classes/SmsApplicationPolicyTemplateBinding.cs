using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ApplicationPolicyTemplateBinding
    /// </summary>
    [WmiClass(Name = "SMS_ApplicationPolicyTemplateBinding")]
    public class SmsApplicationPolicyTemplateBinding
    {
        /// <summary>
        /// WMI Property ApplicationPolicyTemplateName
        /// </summary>
        public string ApplicationPolicyTemplateName { get; set; }
        /// <summary>
        /// WMI Property DeploymentTypeDisplayName
        /// </summary>
        public string DeploymentTypeDisplayName { get; set; }
        /// <summary>
        /// WMI Property DeploymentTypeModelName
        /// </summary>
        public string DeploymentTypeModelName { get; set; }
        /// <summary>
        /// WMI Property PolicyTemplateCI_ID
        /// </summary>
        [WmiProperty(Name = "PolicyTemplateCI_ID")]
        public uint PolicyTemplateCiId { get; set; }
    }
}
