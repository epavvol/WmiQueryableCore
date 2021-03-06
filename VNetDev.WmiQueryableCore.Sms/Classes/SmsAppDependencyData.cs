using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDependencyData
    /// </summary>
    [WmiClass(Name = "SMS_AppDependencyData")]
    public class SmsAppDependencyData
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property DependencyGroup
        /// </summary>
        public string DependencyGroup { get; set; }
        /// <summary>
        /// WMI Property DependentDTName
        /// </summary>
        public string DependentDtName { get; set; }
        /// <summary>
        /// WMI Property DTCI
        /// </summary>
        public uint Dtci { get; set; }
        /// <summary>
        /// WMI Property DTModelID
        /// </summary>
        public uint DtModelId { get; set; }
        /// <summary>
        /// WMI Property DTResultID
        /// </summary>
        public ulong DtResultId { get; set; }
        /// <summary>
        /// WMI Property EnforcementState
        /// </summary>
        public uint EnforcementState { get; set; }
        /// <summary>
        /// WMI Property ErrorValue
        /// </summary>
        public uint ErrorValue { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
