using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NTLogEvent
    /// </summary>
    [WmiClass(Name = "Win32_NTLogEvent")]
    public class Win32NtLogEvent
    {
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public ushort Category { get; set; }

        /// <summary>
        /// WMI Property CategoryString
        /// </summary>
        public string CategoryString { get; set; }

        /// <summary>
        /// WMI Property ComputerName
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// WMI Property Data
        /// </summary>
        public ICollection<byte> Data { get; set; }

        /// <summary>
        /// WMI Property EventCode
        /// </summary>
        public ushort EventCode { get; set; }

        /// <summary>
        /// WMI Property EventIdentifier
        /// </summary>
        public uint EventIdentifier { get; set; }

        /// <summary>
        /// WMI Property EventType
        /// </summary>
        public byte EventType { get; set; }

        /// <summary>
        /// WMI Property InsertionStrings
        /// </summary>
        public ICollection<string> InsertionStrings { get; set; }

        /// <summary>
        /// WMI Property Logfile
        /// </summary>
        public string Logfile { get; set; }

        /// <summary>
        /// WMI Property Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// WMI Property RecordNumber
        /// </summary>
        public uint RecordNumber { get; set; }

        /// <summary>
        /// WMI Property SourceName
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// WMI Property TimeGenerated
        /// </summary>
        public DateTime TimeGenerated { get; set; }

        /// <summary>
        /// WMI Property TimeWritten
        /// </summary>
        public DateTime TimeWritten { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public string User { get; set; }
    }
}