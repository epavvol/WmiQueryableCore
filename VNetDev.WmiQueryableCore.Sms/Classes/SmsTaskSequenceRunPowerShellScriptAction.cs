using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_RunPowerShellScriptAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_RunPowerShellScriptAction")]
    public class SmsTaskSequenceRunPowerShellScriptAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property ExecutionPolicy
        /// </summary>
        public string ExecutionPolicy { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OutputVariableName
        /// </summary>
        public string OutputVariableName { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Parameters
        /// </summary>
        public string Parameters { get; set; }
        /// <summary>
        /// WMI Property RunAsUser
        /// </summary>
        public bool RunAsUser { get; set; }
        /// <summary>
        /// WMI Property ScriptName
        /// </summary>
        public string ScriptName { get; set; }
        /// <summary>
        /// WMI Property SourceScript
        /// </summary>
        public string SourceScript { get; set; }
        /// <summary>
        /// WMI Property SuccessCodes
        /// </summary>
        public string SuccessCodes { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property UserPassword
        /// </summary>
        public string UserPassword { get; set; }
        /// <summary>
        /// WMI Property WorkingDirectory
        /// </summary>
        public string WorkingDirectory { get; set; }
    }
}
