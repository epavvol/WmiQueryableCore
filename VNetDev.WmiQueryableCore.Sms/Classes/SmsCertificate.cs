using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Certificate
    /// </summary>
    [WmiClass(Name = "SMS_Certificate")]
    public class SmsCertificate
    {
        /// <summary>
        /// WMI Property Certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// WMI Property IsApproved
        /// </summary>
        public bool IsApproved { get; set; }
        /// <summary>
        /// WMI Property IsBlocked
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// WMI Property IssuedTo
        /// </summary>
        public string IssuedTo { get; set; }
        /// <summary>
        /// WMI Property KeyType
        /// </summary>
        public int KeyType { get; set; }
        /// <summary>
        /// WMI Property PublicKey
        /// </summary>
        public string PublicKey { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property ValidFrom
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// WMI Property ValidUntil
        /// </summary>
        public DateTime ValidUntil { get; set; }
    }
}
