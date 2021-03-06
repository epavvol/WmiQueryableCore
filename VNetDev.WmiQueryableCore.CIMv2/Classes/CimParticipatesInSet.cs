using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ParticipatesInSet
    /// </summary>
    [WmiClass(Name = "CIM_ParticipatesInSet")]
    public class CimParticipatesInSet
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Set
        /// </summary>
        public object Set { get; set; }
    }
}