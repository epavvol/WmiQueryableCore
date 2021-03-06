using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectLimitSetting
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectLimitSetting")]
    public class Win32NamedJobObjectLimitSetting
    {
        /// <summary>
        /// WMI Property ActiveProcessLimit
        /// </summary>
        public uint ActiveProcessLimit { get; set; }

        /// <summary>
        /// WMI Property Affinity
        /// </summary>
        public uint Affinity { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property JobMemoryLimit
        /// </summary>
        public uint JobMemoryLimit { get; set; }

        /// <summary>
        /// WMI Property LimitFlags
        /// </summary>
        public uint LimitFlags { get; set; }

        /// <summary>
        /// WMI Property MaximumWorkingSetSize
        /// </summary>
        public uint MaximumWorkingSetSize { get; set; }

        /// <summary>
        /// WMI Property MinimumWorkingSetSize
        /// </summary>
        public uint MinimumWorkingSetSize { get; set; }

        /// <summary>
        /// WMI Property PerJobUserTimeLimit
        /// </summary>
        public ulong PerJobUserTimeLimit { get; set; }

        /// <summary>
        /// WMI Property PerProcessUserTimeLimit
        /// </summary>
        public ulong PerProcessUserTimeLimit { get; set; }

        /// <summary>
        /// WMI Property PriorityClass
        /// </summary>
        public uint PriorityClass { get; set; }

        /// <summary>
        /// WMI Property ProcessMemoryLimit
        /// </summary>
        public uint ProcessMemoryLimit { get; set; }

        /// <summary>
        /// WMI Property SchedulingClass
        /// </summary>
        public uint SchedulingClass { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
    }
}