using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PfxCertificateTemplates
    /// </summary>
    [WmiClass(Name = "SMS_PfxCertificateTemplates")]
    public class SmsPfxCertificateTemplates
    {
        /// <summary>
        /// WMI Property CASpecificReserved
        /// </summary>
        public string CaSpecificReserved { get; set; }
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// WMI Property CertificateAuthority
        /// </summary>
        public string CertificateAuthority { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DNFormat
        /// </summary>
        public string DnFormat { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsTombstoned
        /// </summary>
        public bool IsTombstoned { get; set; }
        /// <summary>
        /// WMI Property LastAttemptedSync
        /// </summary>
        public DateTime LastAttemptedSync { get; set; }
        /// <summary>
        /// WMI Property LastModified
        /// </summary>
        public DateTime LastModified { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSync
        /// </summary>
        public DateTime LastSuccessfulSync { get; set; }
        /// <summary>
        /// WMI Property RoleId
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleServer
        /// </summary>
        public string RoleServer { get; set; }
        /// <summary>
        /// WMI Property SubjectAltNames
        /// </summary>
        public string SubjectAltNames { get; set; }
        /// <summary>
        /// WMI Property TemplateName
        /// </summary>
        public string TemplateName { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
