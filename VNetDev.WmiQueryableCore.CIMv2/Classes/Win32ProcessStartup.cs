using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ProcessStartup
    /// </summary>
    [WmiClass(Name = "Win32_ProcessStartup")]
    public class Win32ProcessStartup
    {
        /// <summary>
        /// WMI Property CreateFlags
        /// </summary>
        public uint CreateFlags { get; set; }

        /// <summary>
        /// WMI Property EnvironmentVariables
        /// </summary>
        public ICollection<string> EnvironmentVariables { get; set; }

        /// <summary>
        /// WMI Property ErrorMode
        /// </summary>
        public ushort ErrorMode { get; set; }

        /// <summary>
        /// WMI Property FillAttribute
        /// </summary>
        public uint FillAttribute { get; set; }

        /// <summary>
        /// WMI Property PriorityClass
        /// </summary>
        public uint PriorityClass { get; set; }

        /// <summary>
        /// WMI Property ShowWindow
        /// </summary>
        public ushort ShowWindow { get; set; }

        /// <summary>
        /// WMI Property Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// WMI Property WinstationDesktop
        /// </summary>
        public string WinstationDesktop { get; set; }

        /// <summary>
        /// WMI Property X
        /// </summary>
        public uint X { get; set; }

        /// <summary>
        /// WMI Property XCountChars
        /// </summary>
        public uint XCountChars { get; set; }

        /// <summary>
        /// WMI Property XSize
        /// </summary>
        public uint XSize { get; set; }

        /// <summary>
        /// WMI Property Y
        /// </summary>
        public uint Y { get; set; }

        /// <summary>
        /// WMI Property YCountChars
        /// </summary>
        public uint YCountChars { get; set; }

        /// <summary>
        /// WMI Property YSize
        /// </summary>
        public uint YSize { get; set; }
    }
}