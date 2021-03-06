using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ServiceSpecification
    /// </summary>
    [WmiClass(Name = "Win32_ServiceSpecification")]
    public class Win32ServiceSpecification
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
        /// WMI Property Dependencies
        /// </summary>
        public string Dependencies { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// WMI Property ErrorControl
        /// </summary>
        public int ErrorControl { get; set; }

        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// WMI Property LoadOrderGroup
        /// </summary>
        public string LoadOrderGroup { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public int ServiceType { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property StartName
        /// </summary>
        public string StartName { get; set; }

        /// <summary>
        /// WMI Property StartType
        /// </summary>
        public int StartType { get; set; }

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