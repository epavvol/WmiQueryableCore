using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShortcutAction
    /// </summary>
    [WmiClass(Name = "Win32_ShortcutAction")]
    public class Win32ShortcutAction
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
        /// WMI Property Arguments
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Direction
        /// </summary>
        public ushort Direction { get; set; }

        /// <summary>
        /// WMI Property HotKey
        /// </summary>
        public ushort HotKey { get; set; }

        /// <summary>
        /// WMI Property IconIndex
        /// </summary>
        public string IconIndex { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Shortcut
        /// </summary>
        public string Shortcut { get; set; }

        /// <summary>
        /// WMI Property ShowCmd
        /// </summary>
        public ushort ShowCmd { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property Target
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// WMI Property TargetOperatingSystem
        /// </summary>
        public ushort TargetOperatingSystem { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property WkDir
        /// </summary>
        public string WkDir { get; set; }
    }
}