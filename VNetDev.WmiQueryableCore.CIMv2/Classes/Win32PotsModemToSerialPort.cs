using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_POTSModemToSerialPort
    /// </summary>
    [WmiClass(Name = "Win32_POTSModemToSerialPort")]
    public class Win32PotsModemToSerialPort
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
    }
}