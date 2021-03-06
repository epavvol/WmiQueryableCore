using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDependenceRelation_Flat
    /// </summary>
    [WmiClass(Name = "SMS_AppDependenceRelation_Flat")]
    public class SmsAppDependenceRelationFlat
    {
        /// <summary>
        /// WMI Property FromApplicationCIID
        /// </summary>
        public uint FromApplicationCiid { get; set; }
        /// <summary>
        /// WMI Property Level
        /// </summary>
        public uint Level { get; set; }
        /// <summary>
        /// WMI Property ToApplicationCIID
        /// </summary>
        public uint ToApplicationCiid { get; set; }
    }
}
