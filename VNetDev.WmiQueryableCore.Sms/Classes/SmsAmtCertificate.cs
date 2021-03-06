using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AMTCertificate
    /// </summary>
    [WmiClass(Name = "SMS_AMTCertificate")]
    public class SmsAmtCertificate
    {
        /// <summary>
        /// WMI Property CAFqdn
        /// </summary>
        public string CaFqdn { get; set; }
        /// <summary>
        /// WMI Property CAName
        /// </summary>
        public string CaName { get; set; }
        /// <summary>
        /// WMI Property CARequestID
        /// </summary>
        public string CaRequestId { get; set; }
        /// <summary>
        /// WMI Property CAType
        /// </summary>
        public uint CaType { get; set; }
        /// <summary>
        /// WMI Property CertID
        /// </summary>
        public uint CertId { get; set; }
        /// <summary>
        /// WMI Property CertificateStatus
        /// </summary>
        public int CertificateStatus { get; set; }
        /// <summary>
        /// WMI Property CertTemplate
        /// </summary>
        public string CertTemplate { get; set; }
        /// <summary>
        /// WMI Property CertType
        /// </summary>
        public uint CertType { get; set; }
        /// <summary>
        /// WMI Property ChainLength
        /// </summary>
        public uint ChainLength { get; set; }
        /// <summary>
        /// WMI Property ClientIdentity
        /// </summary>
        public string ClientIdentity { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
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
