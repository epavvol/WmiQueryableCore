using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DW_TargetSiteTables
    /// </summary>
    [WmiClass(Name = "SMS_DW_TargetSiteTables")]
    public class SmsDwTargetSiteTables
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property GroupName
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property TableName
        /// </summary>
        public string TableName { get; set; }
    }
}
