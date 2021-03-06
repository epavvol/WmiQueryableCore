using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDependenceRelation
    /// </summary>
    [WmiClass(Name = "SMS_AppDependenceRelation")]
    public class SmsAppDependenceRelation
    {
        /// <summary>
        /// WMI Property FromApplicationCIID
        /// </summary>
        public uint FromApplicationCiid { get; set; }
        /// <summary>
        /// WMI Property FromDeploymentTypeCIID
        /// </summary>
        public uint FromDeploymentTypeCiid { get; set; }
        /// <summary>
        /// WMI Property ToApplicationCIID
        /// </summary>
        public uint ToApplicationCiid { get; set; }
        /// <summary>
        /// WMI Property ToDeploymentTypeCIID
        /// </summary>
        public uint ToDeploymentTypeCiid { get; set; }
        /// <summary>
        /// WMI Property TypeFlag
        /// </summary>
        public uint TypeFlag { get; set; }
    }
}
