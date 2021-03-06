using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_LastSoftwareScan
    /// </summary>
    [WmiClass(Name = "SMS_G_System_LastSoftwareScan")]
    public class SmsGSystemLastSoftwareScan
    {
        /// <summary>
        /// WMI Property LastCollectedFileScanDate
        /// </summary>
        public DateTime LastCollectedFileScanDate { get; set; }
        /// <summary>
        /// WMI Property LastScanDate
        /// </summary>
        public DateTime LastScanDate { get; set; }
        /// <summary>
        /// WMI Property LastScanOpCode
        /// </summary>
        public uint LastScanOpCode { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
