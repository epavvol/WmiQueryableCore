using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SoftwareUsageData
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SoftwareUsageData")]
    public class SmsGSystemSoftwareUsageData
    {
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property EndNotCaptured
        /// </summary>
        public bool EndNotCaptured { get; set; }
        /// <summary>
        /// WMI Property EndTimeGMT
        /// </summary>
        public DateTime EndTimeGmt { get; set; }
        /// <summary>
        /// WMI Property EndTimeLocal
        /// </summary>
        public DateTime EndTimeLocal { get; set; }
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
        /// WMI Property InTSSession
        /// </summary>
        public bool InTsSession { get; set; }
        /// <summary>
        /// WMI Property MeterDataID
        /// </summary>
        public string MeterDataId { get; set; }
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
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property StartNotCaptured
        /// </summary>
        public bool StartNotCaptured { get; set; }
        /// <summary>
        /// WMI Property StartTimeGMT
        /// </summary>
        public DateTime StartTimeGmt { get; set; }
        /// <summary>
        /// WMI Property StartTimeLocal
        /// </summary>
        public DateTime StartTimeLocal { get; set; }
        /// <summary>
        /// WMI Property StillRunning
        /// </summary>
        public bool StillRunning { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
