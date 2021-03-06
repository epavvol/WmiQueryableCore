using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_CI_ComplianceState
    /// </summary>
    [WmiClass(Name = "SMS_G_System_CI_ComplianceState")]
    public class SmsGSystemCiComplianceState
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property CIVersion
        /// </summary>
        public uint CiVersion { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property ComplianceStateName
        /// </summary>
        public string ComplianceStateName { get; set; }
        /// <summary>
        /// WMI Property DesiredState
        /// </summary>
        public uint DesiredState { get; set; }
        /// <summary>
        /// WMI Property IsApplicable
        /// </summary>
        public uint IsApplicable { get; set; }
        /// <summary>
        /// WMI Property IsDetected
        /// </summary>
        public uint IsDetected { get; set; }
        /// <summary>
        /// WMI Property LastComplianceErrorID
        /// </summary>
        public uint LastComplianceErrorId { get; set; }
        /// <summary>
        /// WMI Property LocalizedDisplayName
        /// </summary>
        public string LocalizedDisplayName { get; set; }
        /// <summary>
        /// WMI Property MaxNoncomplianceCriticality
        /// </summary>
        public uint MaxNoncomplianceCriticality { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SDMPackageVersion
        /// </summary>
        public uint SdmPackageVersion { get; set; }
        /// <summary>
        /// WMI Property UserID
        /// </summary>
        public uint UserId { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
