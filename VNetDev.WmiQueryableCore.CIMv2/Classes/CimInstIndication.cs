using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_InstIndication
    /// </summary>
    [WmiClass(Name = "CIM_InstIndication")]
    public class CimInstIndication
    {
        /// <summary>
        /// WMI Property CorrelatedIndications
        /// </summary>
        public ICollection<string> CorrelatedIndications { get; set; }

        /// <summary>
        /// WMI Property IndicationFilterName
        /// </summary>
        public string IndicationFilterName { get; set; }

        /// <summary>
        /// WMI Property IndicationIdentifier
        /// </summary>
        public string IndicationIdentifier { get; set; }

        /// <summary>
        /// WMI Property IndicationTime
        /// </summary>
        public DateTime IndicationTime { get; set; }

        /// <summary>
        /// WMI Property OtherSeverity
        /// </summary>
        public string OtherSeverity { get; set; }

        /// <summary>
        /// WMI Property PerceivedSeverity
        /// </summary>
        public ushort PerceivedSeverity { get; set; }

        /// <summary>
        /// WMI Property SequenceContext
        /// </summary>
        public string SequenceContext { get; set; }

        /// <summary>
        /// WMI Property SequenceNumber
        /// </summary>
        public long SequenceNumber { get; set; }

        /// <summary>
        /// WMI Property SourceInstance
        /// </summary>
        public object SourceInstance { get; set; }

        /// <summary>
        /// WMI Property SourceInstanceHost
        /// </summary>
        public string SourceInstanceHost { get; set; }

        /// <summary>
        /// WMI Property SourceInstanceModelPath
        /// </summary>
        public string SourceInstanceModelPath { get; set; }
    }
}