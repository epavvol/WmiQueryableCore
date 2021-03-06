using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ProductFileInfo
    /// </summary>
    [WmiClass(Name = "SMS_ProductFileInfo")]
    public class SmsProductFileInfo
    {
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property FileDescription
        /// </summary>
        public string FileDescription { get; set; }
        /// <summary>
        /// WMI Property FileID
        /// </summary>
        public long FileId { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public uint FileSize { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property ProductLanguage
        /// </summary>
        public uint ProductLanguage { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
    }
}
