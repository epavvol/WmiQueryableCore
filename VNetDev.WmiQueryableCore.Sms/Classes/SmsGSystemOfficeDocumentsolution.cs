using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE_DOCUMENTSOLUTION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE_DOCUMENTSOLUTION")]
    public class SmsGSystemOfficeDocumentsolution
    {
        /// <summary>
        /// WMI Property CompatibilityErrorCount
        /// </summary>
        public uint CompatibilityErrorCount { get; set; }
        /// <summary>
        /// WMI Property CrashCount
        /// </summary>
        public uint CrashCount { get; set; }
        /// <summary>
        /// WMI Property DocumentSolutionId
        /// </summary>
        public string DocumentSolutionId { get; set; }
        /// <summary>
        /// WMI Property ExampleFileName
        /// </summary>
        public string ExampleFileName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LoadCount
        /// </summary>
        public uint LoadCount { get; set; }
        /// <summary>
        /// WMI Property LoadFailCount
        /// </summary>
        public uint LoadFailCount { get; set; }
        /// <summary>
        /// WMI Property MacroCompileErrorCount
        /// </summary>
        public uint MacroCompileErrorCount { get; set; }
        /// <summary>
        /// WMI Property MacroRuntimeErrorCount
        /// </summary>
        public uint MacroRuntimeErrorCount { get; set; }
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
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
    }
}
