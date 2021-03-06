using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_MemoryCapacity
    /// </summary>
    [WmiClass(Name = "CIM_MemoryCapacity")]
    public class CimMemoryCapacity
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property MaximumMemoryCapacity
        /// </summary>
        public ulong MaximumMemoryCapacity { get; set; }

        /// <summary>
        /// WMI Property MemoryType
        /// </summary>
        public ushort MemoryType { get; set; }

        /// <summary>
        /// WMI Property MinimumMemoryCapacity
        /// </summary>
        public ulong MinimumMemoryCapacity { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}