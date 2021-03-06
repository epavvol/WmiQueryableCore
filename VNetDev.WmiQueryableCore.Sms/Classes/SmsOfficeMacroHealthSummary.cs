using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficeMacroHealthSummary
    /// </summary>
    [WmiClass(Name = "SMS_OfficeMacroHealthSummary")]
    public class SmsOfficeMacroHealthSummary
    {
        /// <summary>
        /// WMI Property DocumentSolutionId
        /// </summary>
        public string DocumentSolutionId { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property ErrorTitle
        /// </summary>
        public string ErrorTitle { get; set; }
        /// <summary>
        /// WMI Property LastOccurrence
        /// </summary>
        public DateTime LastOccurrence { get; set; }
        /// <summary>
        /// WMI Property NumberOfDevices
        /// </summary>
        public uint NumberOfDevices { get; set; }
        /// <summary>
        /// WMI Property OfficeApp
        /// </summary>
        public string OfficeApp { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
    }
}
