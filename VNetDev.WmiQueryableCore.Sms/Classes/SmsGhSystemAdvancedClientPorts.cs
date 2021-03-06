using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_ADVANCED_CLIENT_PORTS
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_ADVANCED_CLIENT_PORTS")]
    public class SmsGhSystemAdvancedClientPorts
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HttpsPortName
        /// </summary>
        public uint HttpsPortName { get; set; }
        /// <summary>
        /// WMI Property InstanceKey
        /// </summary>
        public string InstanceKey { get; set; }
        /// <summary>
        /// WMI Property PortName
        /// </summary>
        public uint PortName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
