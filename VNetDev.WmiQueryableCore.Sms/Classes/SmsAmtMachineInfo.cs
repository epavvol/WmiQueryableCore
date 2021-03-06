using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AMTMachineInfo
    /// </summary>
    [WmiClass(Name = "SMS_AMTMachineInfo")]
    public class SmsAmtMachineInfo
    {
        /// <summary>
        /// WMI Property Addn
        /// </summary>
        public string Addn { get; set; }
        /// <summary>
        /// WMI Property AdminPassword
        /// </summary>
        public string AdminPassword { get; set; }
        /// <summary>
        /// WMI Property AdminUserName
        /// </summary>
        public string AdminUserName { get; set; }
        /// <summary>
        /// WMI Property EnableKerberos
        /// </summary>
        public bool EnableKerberos { get; set; }
        /// <summary>
        /// WMI Property FQDN
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property HostName
        /// </summary>
        public string HostName { get; set; }
        /// <summary>
        /// WMI Property IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property ProvisionOpType
        /// </summary>
        public uint ProvisionOpType { get; set; }
        /// <summary>
        /// WMI Property ProvisionTime
        /// </summary>
        public DateTime ProvisionTime { get; set; }
        /// <summary>
        /// WMI Property TlsMode
        /// </summary>
        public uint TlsMode { get; set; }
    }
}
