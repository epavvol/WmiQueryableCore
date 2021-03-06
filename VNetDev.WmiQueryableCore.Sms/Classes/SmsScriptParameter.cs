using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ScriptParameter
    /// </summary>
    [WmiClass(Name = "SMS_ScriptParameter")]
    public class SmsScriptParameter
    {
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public string LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property ParameterGroupGuid
        /// </summary>
        public string ParameterGroupGuid { get; set; }
        /// <summary>
        /// WMI Property ParameterGroupName
        /// </summary>
        public string ParameterGroupName { get; set; }
        /// <summary>
        /// WMI Property ParameterName
        /// </summary>
        public string ParameterName { get; set; }
        /// <summary>
        /// WMI Property ParameterType
        /// </summary>
        public string ParameterType { get; set; }
        /// <summary>
        /// WMI Property ParameterValue
        /// </summary>
        public string ParameterValue { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
    }
}
