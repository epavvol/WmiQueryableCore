using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConfigData
    /// </summary>
    [WmiClass(Name = "SMS_ConfigData")]
    public class SmsConfigData
    {
        /// <summary>
        /// WMI Property ArrayQueryBatchCount
        /// </summary>
        public uint ArrayQueryBatchCount { get; set; }
        /// <summary>
        /// WMI Property MaxSQLConnections
        /// </summary>
        public uint MaxSqlConnections { get; set; }
    }
}
