using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficePilotMacrosHealth
    /// </summary>
    [WmiClass(Name = "SMS_OfficePilotMacrosHealth")]
    public class SmsOfficePilotMacrosHealth
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CompileErrorHealth
        /// </summary>
        public uint CompileErrorHealth { get; set; }
        /// <summary>
        /// WMI Property CrashRate
        /// </summary>
        public float CrashRate { get; set; }
        /// <summary>
        /// WMI Property DeviceCount
        /// </summary>
        public uint DeviceCount { get; set; }
        /// <summary>
        /// WMI Property DocumentSolutionId
        /// </summary>
        public string DocumentSolutionId { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property LoadFailureRate
        /// </summary>
        public float LoadFailureRate { get; set; }
        /// <summary>
        /// WMI Property LoadHealth
        /// </summary>
        public uint LoadHealth { get; set; }
        /// <summary>
        /// WMI Property MacroCompileErrorRate
        /// </summary>
        public float MacroCompileErrorRate { get; set; }
        /// <summary>
        /// WMI Property MacroRuntimeErrorRate
        /// </summary>
        public float MacroRuntimeErrorRate { get; set; }
        /// <summary>
        /// WMI Property OfficeProduct
        /// </summary>
        public string OfficeProduct { get; set; }
        /// <summary>
        /// WMI Property OverallHealth
        /// </summary>
        public uint OverallHealth { get; set; }
        /// <summary>
        /// WMI Property OverallHealthReason
        /// </summary>
        public uint OverallHealthReason { get; set; }
        /// <summary>
        /// WMI Property RunHealth
        /// </summary>
        public uint RunHealth { get; set; }
        /// <summary>
        /// WMI Property RunTimeErrorHealth
        /// </summary>
        public uint RunTimeErrorHealth { get; set; }
    }
}
