using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE_DOCUMENTMETRIC
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE_DOCUMENTMETRIC")]
    public class SmsGSystemOfficeDocumentmetric
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property OfficeApp
        /// </summary>
        public string OfficeApp { get; set; }
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
        /// <summary>
        /// WMI Property TotalCloudDocs
        /// </summary>
        public uint TotalCloudDocs { get; set; }
        /// <summary>
        /// WMI Property TotalLegacyDocs
        /// </summary>
        public uint TotalLegacyDocs { get; set; }
        /// <summary>
        /// WMI Property TotalLocalDocs
        /// </summary>
        public uint TotalLocalDocs { get; set; }
        /// <summary>
        /// WMI Property TotalMacroDocs
        /// </summary>
        public uint TotalMacroDocs { get; set; }
        /// <summary>
        /// WMI Property TotalNonMacroDocs
        /// </summary>
        public uint TotalNonMacroDocs { get; set; }
        /// <summary>
        /// WMI Property TotalUncDocs
        /// </summary>
        public uint TotalUncDocs { get; set; }
    }
}
