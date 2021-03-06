using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DW_TargetSyncTable
    /// </summary>
    [WmiClass(Name = "SMS_DW_TargetSyncTable")]
    public class SmsDwTargetSyncTable
    {
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property OperationFlag
        /// </summary>
        public uint OperationFlag { get; set; }
        /// <summary>
        /// WMI Property TableName
        /// </summary>
        public string TableName { get; set; }
    }
}
