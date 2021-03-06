using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_AppClientState
    /// </summary>
    [WmiClass(Name = "SMS_G_System_AppClientState")]
    public class SmsGSystemAppClientState
    {
        /// <summary>
        /// WMI Property AppCI
        /// </summary>
        public uint AppCi { get; set; }
        /// <summary>
        /// WMI Property AppModelID
        /// </summary>
        public uint AppModelId { get; set; }
        /// <summary>
        /// WMI Property AppModelName
        /// </summary>
        public string AppModelName { get; set; }
        /// <summary>
        /// WMI Property AppName
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Revision
        /// </summary>
        public uint Revision { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
