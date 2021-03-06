using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageDeploymentAgent
    /// </summary>
    [WmiClass(Name = "SMS_ImageDeploymentAgent")]
    public class SmsImageDeploymentAgent
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FileExtension
        /// </summary>
        public string FileExtension { get; set; }
        /// <summary>
        /// WMI Property ImageAgentID
        /// </summary>
        public uint ImageAgentId { get; set; }
        /// <summary>
        /// WMI Property ImageAgentPath
        /// </summary>
        public string ImageAgentPath { get; set; }
        /// <summary>
        /// WMI Property ImageType
        /// </summary>
        public string ImageType { get; set; }
    }
}
