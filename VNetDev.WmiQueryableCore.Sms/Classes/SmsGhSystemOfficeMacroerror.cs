using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_OFFICE_MACROERROR
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_OFFICE_MACROERROR")]
    public class SmsGhSystemOfficeMacroerror
    {
        /// <summary>
        /// WMI Property Count
        /// </summary>
        public uint Count { get; set; }
        /// <summary>
        /// WMI Property DocumentSolutionId
        /// </summary>
        public string DocumentSolutionId { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastOccurrence
        /// </summary>
        public ulong LastOccurrence { get; set; }
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
