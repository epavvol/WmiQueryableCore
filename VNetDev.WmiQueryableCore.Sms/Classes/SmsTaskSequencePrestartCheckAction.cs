using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_PrestartCheckAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_PrestartCheckAction")]
    public class SmsTaskSequencePrestartCheckAction
    {
        /// <summary>
        /// WMI Property CheckCMClientMinVersion
        /// </summary>
        public bool CheckCmClientMinVersion { get; set; }
        /// <summary>
        /// WMI Property CheckFreeDiskSpace
        /// </summary>
        public bool CheckFreeDiskSpace { get; set; }
        /// <summary>
        /// WMI Property CheckMaxOSVersion
        /// </summary>
        public bool CheckMaxOsVersion { get; set; }
        /// <summary>
        /// WMI Property CheckMemory
        /// </summary>
        public bool CheckMemory { get; set; }
        /// <summary>
        /// WMI Property CheckMinOSVersion
        /// </summary>
        public bool CheckMinOsVersion { get; set; }
        /// <summary>
        /// WMI Property CheckNetworkConnected
        /// </summary>
        public bool CheckNetworkConnected { get; set; }
        /// <summary>
        /// WMI Property CheckNetworkWired
        /// </summary>
        public bool CheckNetworkWired { get; set; }
        /// <summary>
        /// WMI Property CheckOSArchitecture
        /// </summary>
        public bool CheckOsArchitecture { get; set; }
        /// <summary>
        /// WMI Property CheckOSLanguageID
        /// </summary>
        public bool CheckOsLanguageId { get; set; }
        /// <summary>
        /// WMI Property CheckOSType
        /// </summary>
        public bool CheckOsType { get; set; }
        /// <summary>
        /// WMI Property CheckPowerState
        /// </summary>
        public bool CheckPowerState { get; set; }
        /// <summary>
        /// WMI Property CheckProcessorSpeed
        /// </summary>
        public bool CheckProcessorSpeed { get; set; }
        /// <summary>
        /// WMI Property CMClientMinVersion
        /// </summary>
        public string CmClientMinVersion { get; set; }
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
        /// WMI Property FreeDiskSpace
        /// </summary>
        public uint FreeDiskSpace { get; set; }
        /// <summary>
        /// WMI Property MaxOSVersion
        /// </summary>
        public string MaxOsVersion { get; set; }
        /// <summary>
        /// WMI Property Memory
        /// </summary>
        public uint Memory { get; set; }
        /// <summary>
        /// WMI Property MinOSVersion
        /// </summary>
        public string MinOsVersion { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OSArchitecture
        /// </summary>
        public string OsArchitecture { get; set; }
        /// <summary>
        /// WMI Property OSLanguageID
        /// </summary>
        public uint OsLanguageId { get; set; }
        /// <summary>
        /// WMI Property OSType
        /// </summary>
        public string OsType { get; set; }
        /// <summary>
        /// WMI Property ProcessorSpeed
        /// </summary>
        public uint ProcessorSpeed { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
    }
}
