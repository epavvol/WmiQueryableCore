using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_VIRTUAL_MACHINE_64
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_VIRTUAL_MACHINE_64")]
    public class SmsGehSystemVirtualMachine64
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstanceKey
        /// </summary>
        public string InstanceKey { get; set; }
        /// <summary>
        /// WMI Property PhysicalHostName
        /// </summary>
        public string PhysicalHostName { get; set; }
        /// <summary>
        /// WMI Property PhysicalHostNameFullyQualified
        /// </summary>
        public string PhysicalHostNameFullyQualified { get; set; }
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
