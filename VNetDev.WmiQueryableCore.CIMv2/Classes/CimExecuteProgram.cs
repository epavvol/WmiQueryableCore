using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ExecuteProgram
    /// </summary>
    [WmiClass(Name = "CIM_ExecuteProgram")]
    public class CimExecuteProgram
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
        /// WMI Property CommandLine
        /// </summary>
        public string CommandLine { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Direction
        /// </summary>
        public ushort Direction { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProgramPath
        /// </summary>
        public string ProgramPath { get; set; }

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