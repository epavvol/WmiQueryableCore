using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ReserveCost
    /// </summary>
    [WmiClass(Name = "Win32_ReserveCost")]
    public class Win32ReserveCost
    {
        /// <summary>
        /// WMI method <c>Invoke</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint InvokeDelegate();

        /// <summary>
        /// WMI method <c>Invoke</c>.
        /// </summary>
        public InvokeDelegate Invoke;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CheckID
        /// </summary>
        public string CheckId { get; set; }

        /// <summary>
        /// WMI Property CheckMode
        /// </summary>
        public bool CheckMode { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ReserveFolder
        /// </summary>
        public string ReserveFolder { get; set; }

        /// <summary>
        /// WMI Property ReserveKey
        /// </summary>
        public string ReserveKey { get; set; }

        /// <summary>
        /// WMI Property ReserveLocal
        /// </summary>
        public uint ReserveLocal { get; set; }

        /// <summary>
        /// WMI Property ReserveSource
        /// </summary>
        public uint ReserveSource { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property TargetOperatingSystem
        /// </summary>
        public ushort TargetOperatingSystem { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}