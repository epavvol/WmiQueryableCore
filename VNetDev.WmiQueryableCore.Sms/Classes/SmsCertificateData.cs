using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CertificateData
    /// </summary>
    [WmiClass(Name = "SMS_CertificateData")]
    public class SmsCertificateData
    {
        /// <summary>
        /// WMI static method <c>SubmitCertificate</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certData">WMI Property <c>CertData</c> of type <c>ICollection{byte}</c>.</param>
        /// <param name="certType">WMI Property <c>CertType</c> of type <c>uint</c>.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>ICollection{byte}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SubmitCertificateDelegate(WmiContext wmiContext, ICollection<byte> certData = default, uint certType = default, string description = default, string name = default, ICollection<byte> password = default);
        /// <summary>
        /// WMI static method <c>SubmitCertificate</c>.
        /// </summary>
        public static SubmitCertificateDelegate SubmitCertificate;
        
        /// <summary>
        /// WMI static method <c>DeleteCertificate</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certType">WMI Property <c>CertType</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteCertificateDelegate(WmiContext wmiContext, uint certType = default);
        /// <summary>
        /// WMI static method <c>DeleteCertificate</c>.
        /// </summary>
        public static DeleteCertificateDelegate DeleteCertificate;
        /// <summary>
        /// WMI Property CertID
        /// </summary>
        public string CertId { get; set; }
        /// <summary>
        /// WMI Property CertType
        /// </summary>
        public uint CertType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
