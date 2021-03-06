using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE_ADDIN
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE_ADDIN")]
    public class SmsGSystemOfficeAddin
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property AverageLoadTimeInMilliseconds
        /// </summary>
        public uint AverageLoadTimeInMilliseconds { get; set; }
        /// <summary>
        /// WMI Property Clsid
        /// </summary>
        public string Clsid { get; set; }
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property CrashCount
        /// </summary>
        public uint CrashCount { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ErrorCount
        /// </summary>
        public uint ErrorCount { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public ulong FileSize { get; set; }
        /// <summary>
        /// WMI Property FileTimeStamp
        /// </summary>
        public uint FileTimeStamp { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property FriendlyName
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// WMI Property FriendlyNameHash
        /// </summary>
        public string FriendlyNameHash { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property IdHash
        /// </summary>
        public string IdHash { get; set; }
        /// <summary>
        /// WMI Property LoadBehavior
        /// </summary>
        public uint LoadBehavior { get; set; }
        /// <summary>
        /// WMI Property LoadCount
        /// </summary>
        public uint LoadCount { get; set; }
        /// <summary>
        /// WMI Property LoadFailCount
        /// </summary>
        public uint LoadFailCount { get; set; }
        /// <summary>
        /// WMI Property OfficeApp
        /// </summary>
        public string OfficeApp { get; set; }
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
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
    }
}
