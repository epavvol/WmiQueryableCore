using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_MoveFileAction
    /// </summary>
    [WmiClass(Name = "Win32_MoveFileAction")]
    public class Win32MoveFileAction
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
        /// WMI Property ActionID
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DestFolder
        /// </summary>
        public string DestFolder { get; set; }

        /// <summary>
        /// WMI Property DestName
        /// </summary>
        public string DestName { get; set; }

        /// <summary>
        /// WMI Property Direction
        /// </summary>
        public ushort Direction { get; set; }

        /// <summary>
        /// WMI Property FileKey
        /// </summary>
        public string FileKey { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Options
        /// </summary>
        public ushort Options { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property SourceFolder
        /// </summary>
        public string SourceFolder { get; set; }

        /// <summary>
        /// WMI Property SourceName
        /// </summary>
        public string SourceName { get; set; }

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