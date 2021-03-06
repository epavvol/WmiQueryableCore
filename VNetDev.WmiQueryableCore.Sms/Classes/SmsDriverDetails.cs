using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Driver_Details
    /// </summary>
    [WmiClass(Name = "SMS_Driver_Details")]
    public class SmsDriverDetails
    {
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property SourcePath
        /// </summary>
        public string SourcePath { get; set; }
    }
}
