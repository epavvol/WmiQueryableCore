using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SerialInterface
    /// </summary>
    [WmiClass(Name = "CIM_SerialInterface")]
    public class CimSerialInterface
    {
        /// <summary>
        /// WMI Property AccessState
        /// </summary>
        public ushort AccessState { get; set; }

        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }

        /// <summary>
        /// WMI Property FlowControlInfo
        /// </summary>
        public ushort FlowControlInfo { get; set; }

        /// <summary>
        /// WMI Property NegotiatedDataWidth
        /// </summary>
        public uint NegotiatedDataWidth { get; set; }

        /// <summary>
        /// WMI Property NegotiatedSpeed
        /// </summary>
        public ulong NegotiatedSpeed { get; set; }

        /// <summary>
        /// WMI Property NumberOfHardResets
        /// </summary>
        public uint NumberOfHardResets { get; set; }

        /// <summary>
        /// WMI Property NumberOfSoftResets
        /// </summary>
        public uint NumberOfSoftResets { get; set; }

        /// <summary>
        /// WMI Property NumberOfStopBits
        /// </summary>
        public ushort NumberOfStopBits { get; set; }

        /// <summary>
        /// WMI Property ParityInfo
        /// </summary>
        public ushort ParityInfo { get; set; }
    }
}