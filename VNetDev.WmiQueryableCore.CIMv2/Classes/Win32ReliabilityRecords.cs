using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ReliabilityRecords
    /// </summary>
    [WmiClass(Name = "Win32_ReliabilityRecords")]
    public class Win32ReliabilityRecords
    {
        /// <summary>
        /// WMI static method <c>GetRecordCount</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetRecordCountDelegate(WmiContext wmiContext);

        /// <summary>
        /// WMI static method <c>GetRecordCount</c>.
        /// </summary>
        public static GetRecordCountDelegate GetRecordCount;

        /// <summary>
        /// WMI Property ComputerName
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// WMI Property EventIdentifier
        /// </summary>
        public uint EventIdentifier { get; set; }

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
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }

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
        /// WMI Property User
        /// </summary>
        public string User { get; set; }
    }
}