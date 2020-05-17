using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_LogicalDisk
    /// </summary>
    [WmiClass(Name = "CIM_LogicalDisk")]
    public class CimLogicalDisk
    {
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
        /// WMI static method <c>ExcludeFromAutochk</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="logicalDisk">WMI Property <c>LogicalDisk</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ExcludeFromAutochkDelegate(WmiContext wmiContext,
            ICollection<string> logicalDisk = default);

        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI static method <c>ScheduleAutoChk</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="logicalDisk">WMI Property <c>LogicalDisk</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ScheduleAutoChkDelegate(WmiContext wmiContext, ICollection<string> logicalDisk = default);

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
        /// WMI static method <c>ExcludeFromAutochk</c>.
        /// </summary>
        public static ExcludeFromAutochkDelegate ExcludeFromAutochk;

        /// <summary>
        /// WMI method <c>Chkdsk</c>.
        /// </summary>
        public ChkdskDelegate Chkdsk;

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
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BlockSize
        /// </summary>
        public ulong BlockSize { get; set; }

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
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property MaximumComponentLength
        /// </summary>
        public uint MaximumComponentLength { get; set; }

        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public uint MediaType { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NumberOfBlocks
        /// </summary>
        public ulong NumberOfBlocks { get; set; }

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
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// WMI Property Purpose
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// WMI Property QuotasDisabled
        /// </summary>
        public bool QuotasDisabled { get; set; }

        /// <summary>
        /// WMI Property QuotasIncomplete
        /// </summary>
        public bool QuotasIncomplete { get; set; }

        /// <summary>
        /// WMI Property QuotasRebuilding
        /// </summary>
        public bool QuotasRebuilding { get; set; }

        /// <summary>
        /// WMI Property Size
        /// </summary>
        public ulong Size { get; set; }

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
        /// WMI Property VolumeDirty
        /// </summary>
        public bool VolumeDirty { get; set; }

        /// <summary>
        /// WMI Property VolumeName
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// WMI Property VolumeSerialNumber
        /// </summary>
        public string VolumeSerialNumber { get; set; }
    }
}