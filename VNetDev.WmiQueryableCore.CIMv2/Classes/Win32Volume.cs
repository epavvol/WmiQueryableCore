using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Volume
    /// </summary>
    [WmiClass(Name = "Win32_Volume")]
    public class Win32Volume
    {
        /// <summary>
        /// WMI method <c>AddMountPoint</c> describing delegate.
        /// <param name="directory">WMI Property <c>Directory</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddMountPointDelegate(string directory = default);

        /// <summary>
        /// WMI method <c>Chkdsk</c> describing delegate.
        /// <param name="fixErrors">WMI Property <c>FixErrors</c> of type <c>bool</c>.</param>
        /// <param name="forceDismount">WMI Property <c>ForceDismount</c> of type <c>bool</c>.</param>
        /// <param name="okToRunAtBootUp">WMI Property <c>OkToRunAtBootUp</c> of type <c>bool</c>.</param>
        /// <param name="recoverBadSectors">WMI Property <c>RecoverBadSectors</c> of type <c>bool</c>.</param>
        /// <param name="skipFolderCycle">WMI Property <c>SkipFolderCycle</c> of type <c>bool</c>.</param>
        /// <param name="vigorousIndexCheck">WMI Property <c>VigorousIndexCheck</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChkdskDelegate(bool fixErrors = default, bool forceDismount = default,
            bool okToRunAtBootUp = default, bool recoverBadSectors = default, bool skipFolderCycle = default,
            bool vigorousIndexCheck = default);

        /// <summary>
        /// WMI method <c>DefragAnalysis</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DefragAnalysisDelegate();

        /// <summary>
        /// WMI method <c>Defrag</c> describing delegate.
        /// <param name="force">WMI Property <c>Force</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DefragDelegate(bool force = default);

        /// <summary>
        /// WMI method <c>Dismount</c> describing delegate.
        /// <param name="force">WMI Property <c>Force</c> of type <c>bool</c>.</param>
        /// <param name="permanent">WMI Property <c>Permanent</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DismountDelegate(bool force = default, bool permanent = default);

        /// <summary>
        /// WMI static method <c>ExcludeFromAutoChk</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="volume">WMI Property <c>Volume</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ExcludeFromAutoChkDelegate(WmiContext wmiContext, ICollection<string> volume = default);

        /// <summary>
        /// WMI method <c>Format</c> describing delegate.
        /// <param name="clusterSize">WMI Property <c>ClusterSize</c> of type <c>uint</c>.</param>
        /// <param name="enableCompression">WMI Property <c>EnableCompression</c> of type <c>bool</c>.</param>
        /// <param name="fileSystem">WMI Property <c>FileSystem</c> of type <c>string</c>.</param>
        /// <param name="label">WMI Property <c>Label</c> of type <c>string</c>.</param>
        /// <param name="quickFormat">WMI Property <c>QuickFormat</c> of type <c>bool</c>.</param>
        /// <param name="version">WMI Property <c>Version</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint FormatDelegate(uint clusterSize = default, bool enableCompression = default,
            string fileSystem = default, string label = default, bool quickFormat = default, uint version = default);

        /// <summary>
        /// WMI method <c>Mount</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint MountDelegate();

        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI static method <c>ScheduleAutoChk</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="volume">WMI Property <c>Volume</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ScheduleAutoChkDelegate(WmiContext wmiContext, ICollection<string> volume = default);

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI static method <c>ScheduleAutoChk</c>.
        /// </summary>
        public static ScheduleAutoChkDelegate ScheduleAutoChk;

        /// <summary>
        /// WMI static method <c>ExcludeFromAutoChk</c>.
        /// </summary>
        public static ExcludeFromAutoChkDelegate ExcludeFromAutoChk;

        /// <summary>
        /// WMI method <c>AddMountPoint</c>.
        /// </summary>
        public AddMountPointDelegate AddMountPoint;

        /// <summary>
        /// WMI method <c>Chkdsk</c>.
        /// </summary>
        public ChkdskDelegate Chkdsk;

        /// <summary>
        /// WMI method <c>Defrag</c>.
        /// </summary>
        public DefragDelegate Defrag;

        /// <summary>
        /// WMI method <c>DefragAnalysis</c>.
        /// </summary>
        public DefragAnalysisDelegate DefragAnalysis;

        /// <summary>
        /// WMI method <c>Dismount</c>.
        /// </summary>
        public DismountDelegate Dismount;

        /// <summary>
        /// WMI method <c>Format</c>.
        /// </summary>
        public FormatDelegate Format;

        /// <summary>
        /// WMI method <c>Mount</c>.
        /// </summary>
        public MountDelegate Mount;

        /// <summary>
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property Access
        /// </summary>
        public ushort Access { get; set; }

        /// <summary>
        /// WMI Property Automount
        /// </summary>
        public bool Automount { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BlockSize
        /// </summary>
        public ulong BlockSize { get; set; }

        /// <summary>
        /// WMI Property BootVolume
        /// </summary>
        public bool BootVolume { get; set; }

        /// <summary>
        /// WMI Property Capacity
        /// </summary>
        public ulong Capacity { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Compressed
        /// </summary>
        public bool Compressed { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property DirtyBitSet
        /// </summary>
        public bool DirtyBitSet { get; set; }

        /// <summary>
        /// WMI Property DriveLetter
        /// </summary>
        public string DriveLetter { get; set; }

        /// <summary>
        /// WMI Property DriveType
        /// </summary>
        public uint DriveType { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property ErrorMethodology
        /// </summary>
        public string ErrorMethodology { get; set; }

        /// <summary>
        /// WMI Property FileSystem
        /// </summary>
        public string FileSystem { get; set; }

        /// <summary>
        /// WMI Property FreeSpace
        /// </summary>
        public ulong FreeSpace { get; set; }

        /// <summary>
        /// WMI Property IndexingEnabled
        /// </summary>
        public bool IndexingEnabled { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Label
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property MaximumFileNameLength
        /// </summary>
        public uint MaximumFileNameLength { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NumberOfBlocks
        /// </summary>
        public ulong NumberOfBlocks { get; set; }

        /// <summary>
        /// WMI Property PageFilePresent
        /// </summary>
        public bool PageFilePresent { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property Purpose
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// WMI Property QuotasEnabled
        /// </summary>
        public bool QuotasEnabled { get; set; }

        /// <summary>
        /// WMI Property QuotasIncomplete
        /// </summary>
        public bool QuotasIncomplete { get; set; }

        /// <summary>
        /// WMI Property QuotasRebuilding
        /// </summary>
        public bool QuotasRebuilding { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public uint SerialNumber { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SupportsDiskQuotas
        /// </summary>
        public bool SupportsDiskQuotas { get; set; }

        /// <summary>
        /// WMI Property SupportsFileBasedCompression
        /// </summary>
        public bool SupportsFileBasedCompression { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property SystemVolume
        /// </summary>
        public bool SystemVolume { get; set; }
    }
}