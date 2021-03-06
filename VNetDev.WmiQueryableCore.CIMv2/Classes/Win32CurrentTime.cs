using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CurrentTime
    /// </summary>
    [WmiClass(Name = "Win32_CurrentTime")]
    public class Win32CurrentTime
    {
        /// <summary>
        /// WMI Property Day
        /// </summary>
        public uint Day { get; set; }

        /// <summary>
        /// WMI Property DayOfWeek
        /// </summary>
        public uint DayOfWeek { get; set; }

        /// <summary>
        /// WMI Property Hour
        /// </summary>
        public uint Hour { get; set; }

        /// <summary>
        /// WMI Property Milliseconds
        /// </summary>
        public uint Milliseconds { get; set; }

        /// <summary>
        /// WMI Property Minute
        /// </summary>
        public uint Minute { get; set; }

        /// <summary>
        /// WMI Property Month
        /// </summary>
        public uint Month { get; set; }

        /// <summary>
        /// WMI Property Quarter
        /// </summary>
        public uint Quarter { get; set; }

        /// <summary>
        /// WMI Property Second
        /// </summary>
        public uint Second { get; set; }

        /// <summary>
        /// WMI Property WeekInMonth
        /// </summary>
        public uint WeekInMonth { get; set; }

        /// <summary>
        /// WMI Property Year
        /// </summary>
        public uint Year { get; set; }
    }
}