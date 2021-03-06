using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_CERTIFICATES
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_CERTIFICATES")]
    public class SmsGSystemDeviceCertificates
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IssuedBy
        /// </summary>
        public string IssuedBy { get; set; }
        /// <summary>
        /// WMI Property IssuedTo
        /// </summary>
        public string IssuedTo { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// WMI Property ValidFrom
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// WMI Property ValidTo
        /// </summary>
        public DateTime ValidTo { get; set; }
    }
}
