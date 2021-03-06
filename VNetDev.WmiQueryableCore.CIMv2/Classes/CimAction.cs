using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Action
    /// </summary>
    [WmiClass(Name = "CIM_Action")]
    public class CimAction
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
        /// WMI Property AppID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// WMI Property Argument
        /// </summary>
        public string Argument { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CLSID
        /// </summary>
        public string Clsid { get; set; }

        /// <summary>
        /// WMI Property Context
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// WMI Property DefInprocHandler
        /// </summary>
        public string DefInprocHandler { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Direction
        /// </summary>
        public ushort Direction { get; set; }

        /// <summary>
        /// WMI Property FileTypeMask
        /// </summary>
        public string FileTypeMask { get; set; }

        /// <summary>
        /// WMI Property Insertable
        /// </summary>
        public ushort Insertable { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProgID
        /// </summary>
        public string ProgId { get; set; }

        /// <summary>
        /// WMI Property RemoteName
        /// </summary>
        public string RemoteName { get; set; }

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

        /// <summary>
        /// WMI Property VIProgID
        /// </summary>
        public string ViProgId { get; set; }
    }
}