using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Job
    /// </summary>
    [WmiClass(Name = "CIM_Job")]
    public class CimJob
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property ElapsedTime
        /// </summary>
        public DateTime ElapsedTime { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

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
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }

        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property TimeSubmitted
        /// </summary>
        public DateTime TimeSubmitted { get; set; }

        /// <summary>
        /// WMI Property UntilTime
        /// </summary>
        public DateTime UntilTime { get; set; }
    }
}