using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_WMISetting
    /// </summary>
    [WmiClass(Name = "Win32_WMISetting")]
    public class Win32WmiSetting
    {
        /// <summary>
        /// WMI Property ASPScriptDefaultNamespace
        /// </summary>
        public string AspScriptDefaultNamespace { get; set; }

        /// <summary>
        /// WMI Property ASPScriptEnabled
        /// </summary>
        public bool AspScriptEnabled { get; set; }

        /// <summary>
        /// WMI Property AutorecoverMofs
        /// </summary>
        public ICollection<string> AutorecoverMofs { get; set; }

        /// <summary>
        /// WMI Property AutoStartWin9X
        /// </summary>
        public uint AutoStartWin9x { get; set; }

        /// <summary>
        /// WMI Property BackupInterval
        /// </summary>
        public uint BackupInterval { get; set; }

        /// <summary>
        /// WMI Property BackupLastTime
        /// </summary>
        public DateTime BackupLastTime { get; set; }

        /// <summary>
        /// WMI Property BuildVersion
        /// </summary>
        public string BuildVersion { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property DatabaseDirectory
        /// </summary>
        public string DatabaseDirectory { get; set; }

        /// <summary>
        /// WMI Property DatabaseMaxSize
        /// </summary>
        public uint DatabaseMaxSize { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property EnableAnonWin9xConnections
        /// </summary>
        public bool EnableAnonWin9xConnections { get; set; }

        /// <summary>
        /// WMI Property EnableEvents
        /// </summary>
        public bool EnableEvents { get; set; }

        /// <summary>
        /// WMI Property EnableStartupHeapPreallocation
        /// </summary>
        public bool EnableStartupHeapPreallocation { get; set; }

        /// <summary>
        /// WMI Property HighThresholdOnClientObjects
        /// </summary>
        public uint HighThresholdOnClientObjects { get; set; }

        /// <summary>
        /// WMI Property HighThresholdOnEvents
        /// </summary>
        public uint HighThresholdOnEvents { get; set; }

        /// <summary>
        /// WMI Property InstallationDirectory
        /// </summary>
        public string InstallationDirectory { get; set; }

        /// <summary>
        /// WMI Property LastStartupHeapPreallocation
        /// </summary>
        public uint LastStartupHeapPreallocation { get; set; }

        /// <summary>
        /// WMI Property LoggingDirectory
        /// </summary>
        public string LoggingDirectory { get; set; }

        /// <summary>
        /// WMI Property LoggingLevel
        /// </summary>
        public uint LoggingLevel { get; set; }

        /// <summary>
        /// WMI Property LowThresholdOnClientObjects
        /// </summary>
        public uint LowThresholdOnClientObjects { get; set; }

        /// <summary>
        /// WMI Property LowThresholdOnEvents
        /// </summary>
        public uint LowThresholdOnEvents { get; set; }

        /// <summary>
        /// WMI Property MaxLogFileSize
        /// </summary>
        public uint MaxLogFileSize { get; set; }

        /// <summary>
        /// WMI Property MaxWaitOnClientObjects
        /// </summary>
        public uint MaxWaitOnClientObjects { get; set; }

        /// <summary>
        /// WMI Property MaxWaitOnEvents
        /// </summary>
        public uint MaxWaitOnEvents { get; set; }

        /// <summary>
        /// WMI Property MofSelfInstallDirectory
        /// </summary>
        public string MofSelfInstallDirectory { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
    }
}