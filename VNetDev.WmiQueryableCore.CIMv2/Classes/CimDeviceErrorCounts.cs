using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_DeviceErrorCounts
    /// </summary>
    [WmiClass(Name = "CIM_DeviceErrorCounts")]
    public class CimDeviceErrorCounts
    {
        /// <summary>
        /// WMI method <c>ResetCounter</c> describing delegate.
        /// <param name="selectedCounter">WMI Property <c>SelectedCounter</c> of type <c>ushort</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetCounterDelegate(ushort selectedCounter = default);

        /// <summary>
        /// WMI method <c>ResetCounter</c>.
        /// </summary>
        public ResetCounterDelegate ResetCounter;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CriticalErrorCount
        /// </summary>
        public ulong CriticalErrorCount { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceCreationClassName
        /// </summary>
        public string DeviceCreationClassName { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property IndeterminateErrorCount
        /// </summary>
        public ulong IndeterminateErrorCount { get; set; }

        /// <summary>
        /// WMI Property MajorErrorCount
        /// </summary>
        public ulong MajorErrorCount { get; set; }

        /// <summary>
        /// WMI Property MinorErrorCount
        /// </summary>
        public ulong MinorErrorCount { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property WarningCount
        /// </summary>
        public ulong WarningCount { get; set; }
    }
}