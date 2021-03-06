using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareInventoryAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareInventoryAgentConfig")]
    public class SmsSoftwareInventoryAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property CollectableFileExclude
        /// </summary>
        public ICollection<string> CollectableFileExclude { get; set; }
        /// <summary>
        /// WMI Property CollectableFileMaxSize
        /// </summary>
        public ICollection<string> CollectableFileMaxSize { get; set; }
        /// <summary>
        /// WMI Property CollectableFilePaths
        /// </summary>
        public ICollection<string> CollectableFilePaths { get; set; }
        /// <summary>
        /// WMI Property CollectableFiles
        /// </summary>
        public ICollection<string> CollectableFiles { get; set; }
        /// <summary>
        /// WMI Property CollectableFileSubdirectories
        /// </summary>
        public ICollection<string> CollectableFileSubdirectories { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property Exclude
        /// </summary>
        public ICollection<string> Exclude { get; set; }
        /// <summary>
        /// WMI Property ExcludeWindirAndSubfolders
        /// </summary>
        public ICollection<string> ExcludeWindirAndSubfolders { get; set; }
        /// <summary>
        /// WMI Property InventoriableTypes
        /// </summary>
        public ICollection<string> InventoriableTypes { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public ICollection<string> Path { get; set; }
        /// <summary>
        /// WMI Property QueryTimeout
        /// </summary>
        public uint QueryTimeout { get; set; }
        /// <summary>
        /// WMI Property ReportOptions
        /// </summary>
        public uint ReportOptions { get; set; }
        /// <summary>
        /// WMI Property ReportTimeout
        /// </summary>
        public uint ReportTimeout { get; set; }
        /// <summary>
        /// WMI Property ScanInterval
        /// </summary>
        public uint ScanInterval { get; set; }
        /// <summary>
        /// WMI Property Schedule
        /// </summary>
        public string Schedule { get; set; }
        /// <summary>
        /// WMI Property Subdirectories
        /// </summary>
        public ICollection<string> Subdirectories { get; set; }
    }
}
