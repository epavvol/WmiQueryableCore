using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequenceReferencesInfo
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequenceReferencesInfo")]
    public class SmsTaskSequenceReferencesInfo
    {
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property ReferenceDescription
        /// </summary>
        public string ReferenceDescription { get; set; }
        /// <summary>
        /// WMI Property ReferenceName
        /// </summary>
        public string ReferenceName { get; set; }
        /// <summary>
        /// WMI Property ReferencePackageID
        /// </summary>
        public string ReferencePackageId { get; set; }
        /// <summary>
        /// WMI Property ReferencePackageType
        /// </summary>
        public uint ReferencePackageType { get; set; }
        /// <summary>
        /// WMI Property ReferenceProgramName
        /// </summary>
        public string ReferenceProgramName { get; set; }
        /// <summary>
        /// WMI Property ReferenceVersion
        /// </summary>
        public string ReferenceVersion { get; set; }
    }
}
