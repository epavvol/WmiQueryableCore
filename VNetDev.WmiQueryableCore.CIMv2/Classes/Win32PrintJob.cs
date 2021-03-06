using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PrintJob
    /// </summary>
    [WmiClass(Name = "Win32_PrintJob")]
    public class Win32PrintJob
    {
        /// <summary>
        /// WMI method <c>Pause</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint PauseDelegate();

        /// <summary>
        /// WMI method <c>Resume</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResumeDelegate();

        /// <summary>
        /// WMI method <c>Pause</c>.
        /// </summary>
        public PauseDelegate Pause;

        /// <summary>
        /// WMI method <c>Resume</c>.
        /// </summary>
        public ResumeDelegate Resume;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Color
        /// </summary>
        public string Color { get; set; }

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
        /// WMI Property PaperLength
        /// </summary>
        public uint PaperLength { get; set; }

        /// <summary>
        /// WMI Property PaperSize
        /// </summary>
        public string PaperSize { get; set; }

        /// <summary>
        /// WMI Property PaperWidth
        /// </summary>
        public uint PaperWidth { get; set; }

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
        /// WMI Property Size
        /// </summary>
        public uint Size { get; set; }

        /// <summary>
        /// WMI Property SizeHigh
        /// </summary>
        public uint SizeHigh { get; set; }

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