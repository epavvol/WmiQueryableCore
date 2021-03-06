using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_OFFICE_VBASUMMARY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_OFFICE_VBASUMMARY")]
    public class SmsGhSystemOfficeVbasummary
    {
        /// <summary>
        /// WMI Property Design
        /// </summary>
        public uint Design { get; set; }
        /// <summary>
        /// WMI Property Design64
        /// </summary>
        public uint Design64 { get; set; }
        /// <summary>
        /// WMI Property DuplicateVba
        /// </summary>
        public uint DuplicateVba { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HasResults
        /// </summary>
        public uint HasResults { get; set; }
        /// <summary>
        /// WMI Property HasVba
        /// </summary>
        public uint HasVba { get; set; }
        /// <summary>
        /// WMI Property Inaccessible
        /// </summary>
        public uint Inaccessible { get; set; }
        /// <summary>
        /// WMI Property Issues
        /// </summary>
        public uint Issues { get; set; }
        /// <summary>
        /// WMI Property Issues64
        /// </summary>
        public uint Issues64 { get; set; }
        /// <summary>
        /// WMI Property IssuesNone
        /// </summary>
        public uint IssuesNone { get; set; }
        /// <summary>
        /// WMI Property IssuesNone64
        /// </summary>
        public uint IssuesNone64 { get; set; }
        /// <summary>
        /// WMI Property Locked
        /// </summary>
        public uint Locked { get; set; }
        /// <summary>
        /// WMI Property NoVba
        /// </summary>
        public uint NoVba { get; set; }
        /// <summary>
        /// WMI Property Protected
        /// </summary>
        public uint Protected { get; set; }
        /// <summary>
        /// WMI Property RemLimited
        /// </summary>
        public uint RemLimited { get; set; }
        /// <summary>
        /// WMI Property RemLimited64
        /// </summary>
        public uint RemLimited64 { get; set; }
        /// <summary>
        /// WMI Property RemSignificant
        /// </summary>
        public uint RemSignificant { get; set; }
        /// <summary>
        /// WMI Property RemSignificant64
        /// </summary>
        public uint RemSignificant64 { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Score
        /// </summary>
        public uint Score { get; set; }
        /// <summary>
        /// WMI Property Score64
        /// </summary>
        public uint Score64 { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Total
        /// </summary>
        public uint Total { get; set; }
        /// <summary>
        /// WMI Property Validation
        /// </summary>
        public uint Validation { get; set; }
        /// <summary>
        /// WMI Property Validation64
        /// </summary>
        public uint Validation64 { get; set; }
    }
}
