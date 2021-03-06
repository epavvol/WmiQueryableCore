using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE_CLIENTMETRIC
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE_CLIENTMETRIC")]
    public class SmsGSystemOfficeClientmetric
    {
        /// <summary>
        /// WMI Property CompatibilityErrorCount
        /// </summary>
        public uint CompatibilityErrorCount { get; set; }
        /// <summary>
        /// WMI Property CrashedSessionCount
        /// </summary>
        public uint CrashedSessionCount { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
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
        /// WMI Property SessionCount
        /// </summary>
        public uint SessionCount { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
