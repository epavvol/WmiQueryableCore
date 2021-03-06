using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ScheduledJob
    /// </summary>
    [WmiClass(Name = "Win32_ScheduledJob")]
    public class Win32ScheduledJob
    {
        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="command">WMI Property <c>Command</c> of type <c>string</c>.</param>
        /// <param name="daysOfMonth">WMI Property <c>DaysOfMonth</c> of type <c>uint</c>.</param>
        /// <param name="daysOfWeek">WMI Property <c>DaysOfWeek</c> of type <c>uint</c>.</param>
        /// <param name="interactWithDesktop">WMI Property <c>InteractWithDesktop</c> of type <c>bool</c>.</param>
        /// <param name="runRepeatedly">WMI Property <c>RunRepeatedly</c> of type <c>bool</c>.</param>
        /// <param name="startTime">WMI Property <c>StartTime</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, string command = default, uint daysOfMonth = default,
            uint daysOfWeek = default, bool interactWithDesktop = default, bool runRepeatedly = default,
            DateTime startTime = default);

        /// <summary>
        /// WMI method <c>Delete</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteDelegate();

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI method <c>Delete</c>.
        /// </summary>
        public DeleteDelegate Delete;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// WMI Property DaysOfMonth
        /// </summary>
        public uint DaysOfMonth { get; set; }

        /// <summary>
        /// WMI Property DaysOfWeek
        /// </summary>
        public uint DaysOfWeek { get; set; }

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
        /// WMI Property InteractWithDesktop
        /// </summary>
        public bool InteractWithDesktop { get; set; }

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
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }

        /// <summary>
        /// WMI Property RunRepeatedly
        /// </summary>
        public bool RunRepeatedly { get; set; }

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