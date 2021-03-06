using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_WinSAT
    /// </summary>
    [WmiClass(Name = "Win32_WinSAT")]
    public class Win32WinSat
    {
        /// <summary>
        /// WMI Property CPUScore
        /// </summary>
        public float CpuScore { get; set; }

        /// <summary>
        /// WMI Property D3DScore
        /// </summary>
        public float D3dScore { get; set; }

        /// <summary>
        /// WMI Property DiskScore
        /// </summary>
        public float DiskScore { get; set; }

        /// <summary>
        /// WMI Property GraphicsScore
        /// </summary>
        public float GraphicsScore { get; set; }

        /// <summary>
        /// WMI Property MemoryScore
        /// </summary>
        public float MemoryScore { get; set; }

        /// <summary>
        /// WMI Property TimeTaken
        /// </summary>
        public string TimeTaken { get; set; }

        /// <summary>
        /// WMI Property WinSATAssessmentState
        /// </summary>
        public uint WinSatAssessmentState { get; set; }

        /// <summary>
        /// WMI Property WinSPRLevel
        /// </summary>
        public float WinSprLevel { get; set; }
    }
}