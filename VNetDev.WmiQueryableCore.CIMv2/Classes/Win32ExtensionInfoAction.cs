using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ExtensionInfoAction
    /// </summary>
    [WmiClass(Name = "Win32_ExtensionInfoAction")]
    public class Win32ExtensionInfoAction
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
        /// WMI Property Argument
        /// </summary>
        public string Argument { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Direction
        /// </summary>
        public ushort Direction { get; set; }

        /// <summary>
        /// WMI Property Extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// WMI Property MIME
        /// </summary>
        public string Mime { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProgID
        /// </summary>
        public string ProgId { get; set; }

        /// <summary>
        /// WMI Property ShellNew
        /// </summary>
        public string ShellNew { get; set; }

        /// <summary>
        /// WMI Property ShellNewValue
        /// </summary>
        public string ShellNewValue { get; set; }

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
        /// WMI Property Verb
        /// </summary>
        public string Verb { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}