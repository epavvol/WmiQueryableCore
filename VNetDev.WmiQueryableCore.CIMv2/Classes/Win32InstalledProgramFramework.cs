using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_InstalledProgramFramework
    /// </summary>
    [WmiClass(Name = "Win32_InstalledProgramFramework")]
    public class Win32InstalledProgramFramework
    {
        /// <summary>
        /// WMI Property FrameworkName
        /// </summary>
        public string FrameworkName { get; set; }

        /// <summary>
        /// WMI Property FrameworkPublisher
        /// </summary>
        public string FrameworkPublisher { get; set; }

        /// <summary>
        /// WMI Property FrameworkVersion
        /// </summary>
        public string FrameworkVersion { get; set; }

        /// <summary>
        /// WMI Property FrameworkVersionActual
        /// </summary>
        public string FrameworkVersionActual { get; set; }

        /// <summary>
        /// WMI Property IsPrivate
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// WMI Property ProgramId
        /// </summary>
        public string ProgramId { get; set; }
    }
}