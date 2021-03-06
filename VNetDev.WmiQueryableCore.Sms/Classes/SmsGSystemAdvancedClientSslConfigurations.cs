using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_ADVANCED_CLIENT_SSL_CONFIGURATIONS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_ADVANCED_CLIENT_SSL_CONFIGURATIONS")]
    public class SmsGSystemAdvancedClientSslConfigurations
    {
        /// <summary>
        /// WMI Property CertificateSelectionCriteria
        /// </summary>
        public string CertificateSelectionCriteria { get; set; }
        /// <summary>
        /// WMI Property CertificateStore
        /// </summary>
        public string CertificateStore { get; set; }
        /// <summary>
        /// WMI Property ClientAlwaysOnInternet
        /// </summary>
        public uint ClientAlwaysOnInternet { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HttpsStateFlags
        /// </summary>
        public uint HttpsStateFlags { get; set; }
        /// <summary>
        /// WMI Property InstanceKey
        /// </summary>
        public string InstanceKey { get; set; }
        /// <summary>
        /// WMI Property InternetMPHostName
        /// </summary>
        public string InternetMpHostName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SelectFirstCertificate
        /// </summary>
        public uint SelectFirstCertificate { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
