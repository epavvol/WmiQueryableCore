using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProcessExecutable
    /// </summary>
    [WmiClass(Name = "CIM_ProcessExecutable")]
    public class CimProcessExecutable
    {
        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property BaseAddress
        /// </summary>
        public ulong BaseAddress { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }

        /// <summary>
        /// WMI Property GlobalProcessCount
        /// </summary>
        public uint GlobalProcessCount { get; set; }

        /// <summary>
        /// WMI Property ModuleInstance
        /// </summary>
        public uint ModuleInstance { get; set; }

        /// <summary>
        /// WMI Property ProcessCount
        /// </summary>
        public uint ProcessCount { get; set; }
    }
}