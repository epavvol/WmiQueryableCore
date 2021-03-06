using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ScriptsExecutionSummary
    /// </summary>
    [WmiClass(Name = "SMS_ScriptsExecutionSummary")]
    public class SmsScriptsExecutionSummary
    {
        /// <summary>
        /// WMI Property FullOutput
        /// </summary>
        public string FullOutput { get; set; }
        /// <summary>
        /// WMI Property GroupType
        /// </summary>
        public int GroupType { get; set; }
        /// <summary>
        /// WMI Property OutputAndExitCode
        /// </summary>
        public string OutputAndExitCode { get; set; }
        /// <summary>
        /// WMI Property OutputCount
        /// </summary>
        public int OutputCount { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
        /// <summary>
        /// WMI Property ScriptOutput
        /// </summary>
        public string ScriptOutput { get; set; }
        /// <summary>
        /// WMI Property TaskID
        /// </summary>
        public string TaskId { get; set; }
    }
}
