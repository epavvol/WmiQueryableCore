using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CMSiteConfiguration
    /// </summary>
    [WmiClass(Name = "SMS_CMSiteConfiguration")]
    public class SmsCmSiteConfiguration
    {
        /// <summary>
        /// WMI Property Configuration
        /// </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// WMI Property LastEvaluatingTime
        /// </summary>
        public DateTime LastEvaluatingTime { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property Param1
        /// </summary>
        public string Param1 { get; set; }
        /// <summary>
        /// WMI Property Param2
        /// </summary>
        public string Param2 { get; set; }
        /// <summary>
        /// WMI Property Param3
        /// </summary>
        public string Param3 { get; set; }
        /// <summary>
        /// WMI Property Param4
        /// </summary>
        public string Param4 { get; set; }
        /// <summary>
        /// WMI Property Param5
        /// </summary>
        public string Param5 { get; set; }
        /// <summary>
        /// WMI Property Param6
        /// </summary>
        public string Param6 { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public uint RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
