using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WSUSSigningCertificate
    /// </summary>
    [WmiClass(Name = "SMS_WSUSSigningCertificate")]
    public class SmsWsusSigningCertificate
    {
        /// <summary>
        /// WMI Property Certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// WMI Property CertificateType
        /// </summary>
        public uint CertificateType { get; set; }
        /// <summary>
        /// WMI Property ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsBlocked
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// WMI Property IsSelfSigned
        /// </summary>
        public bool IsSelfSigned { get; set; }
        /// <summary>
        /// WMI Property Issuer
        /// </summary>
        public string Issuer { get; set; }
        /// <summary>
        /// WMI Property IsTombstoned
        /// </summary>
        public bool IsTombstoned { get; set; }
        /// <summary>
        /// WMI Property StartDate
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// WMI Property Subject
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
    }
}
