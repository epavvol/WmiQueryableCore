using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Perf
    /// </summary>
    [WmiClass(Name = "Win32_Perf")]
    public class Win32Perf
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
        /// WMI Property DroppedDatagrams
        /// </summary>
        public uint DroppedDatagrams { get; set; }

        /// <summary>
        /// WMI Property DroppedDatagramsPersec
        /// </summary>
        public uint DroppedDatagramsPersec { get; set; }

        /// <summary>
        /// WMI Property Frequency_Object
        /// </summary>
        [WmiProperty(Name = "Frequency_Object")]
        public ulong FrequencyObject { get; set; }

        /// <summary>
        /// WMI Property Frequency_PerfTime
        /// </summary>
        [WmiProperty(Name = "Frequency_PerfTime")]
        public ulong FrequencyPerfTime { get; set; }

        /// <summary>
        /// WMI Property Frequency_Sys100NS
        /// </summary>
        [WmiProperty(Name = "Frequency_Sys100NS")]
        public ulong FrequencySys100ns { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property RejectedConnections
        /// </summary>
        public uint RejectedConnections { get; set; }

        /// <summary>
        /// WMI Property RejectedConnectionsPersec
        /// </summary>
        public uint RejectedConnectionsPersec { get; set; }

        /// <summary>
        /// WMI Property Timestamp_Object
        /// </summary>
        [WmiProperty(Name = "Timestamp_Object")]
        public ulong TimestampObject { get; set; }

        /// <summary>
        /// WMI Property Timestamp_PerfTime
        /// </summary>
        [WmiProperty(Name = "Timestamp_PerfTime")]
        public ulong TimestampPerfTime { get; set; }

        /// <summary>
        /// WMI Property Timestamp_Sys100NS
        /// </summary>
        [WmiProperty(Name = "Timestamp_Sys100NS")]
        public ulong TimestampSys100ns { get; set; }
    }
}