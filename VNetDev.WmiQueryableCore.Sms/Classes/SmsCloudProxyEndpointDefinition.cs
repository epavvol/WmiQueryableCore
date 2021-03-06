using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CloudProxyEndpointDefinition
    /// </summary>
    [WmiClass(Name = "SMS_CloudProxyEndpointDefinition")]
    public class SmsCloudProxyEndpointDefinition
    {
        /// <summary>
        /// WMI Property ClientAuthScheme
        /// </summary>
        public uint ClientAuthScheme { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property InternalName
        /// </summary>
        public string InternalName { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property RequestLimitContentLength
        /// </summary>
        public ulong RequestLimitContentLength { get; set; }
        /// <summary>
        /// WMI Property RoleTypeID
        /// </summary>
        public ushort RoleTypeId { get; set; }
        /// <summary>
        /// WMI Property SslOnly
        /// </summary>
        public bool SslOnly { get; set; }
        /// <summary>
        /// WMI Property WindowsAuthOnBehalf
        /// </summary>
        public bool WindowsAuthOnBehalf { get; set; }
    }
}
