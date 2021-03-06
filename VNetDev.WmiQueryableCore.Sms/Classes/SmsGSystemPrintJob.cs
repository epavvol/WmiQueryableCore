using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_PRINT_JOB
    /// </summary>
    [WmiClass(Name = "SMS_G_System_PRINT_JOB")]
    public class SmsGSystemPrintJob
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property DataType
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Document
        /// </summary>
        public string Document { get; set; }
        /// <summary>
        /// WMI Property DriverName
        /// </summary>
        public string DriverName { get; set; }
        /// <summary>
        /// WMI Property ElapsedTime
        /// </summary>
        public DateTime ElapsedTime { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HostPrintQueue
        /// </summary>
        public string HostPrintQueue { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property JobId
        /// </summary>
        public uint JobId { get; set; }
        /// <summary>
        /// WMI Property JobStatus
        /// </summary>
        public string JobStatus { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Notify
        /// </summary>
        public string Notify { get; set; }
        /// <summary>
        /// WMI Property Owner
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// WMI Property PagesPrinted
        /// </summary>
        public uint PagesPrinted { get; set; }
        /// <summary>
        /// WMI Property Parameters
        /// </summary>
        public string Parameters { get; set; }
        /// <summary>
        /// WMI Property PrintProcessor
        /// </summary>
        public string PrintProcessor { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public uint Size { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusMask
        /// </summary>
        public uint StatusMask { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TimeSubmitted
        /// </summary>
        public DateTime TimeSubmitted { get; set; }
        /// <summary>
        /// WMI Property TotalPages
        /// </summary>
        public uint TotalPages { get; set; }
        /// <summary>
        /// WMI Property UntilTime
        /// </summary>
        public DateTime UntilTime { get; set; }
    }
}
