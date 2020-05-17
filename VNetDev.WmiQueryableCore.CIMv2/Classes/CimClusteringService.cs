using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ClusteringService
    /// </summary>
    [WmiClass(Name = "CIM_ClusteringService")]
    public class CimClusteringService
    {
        /// <summary>
        /// WMI method <c>AddNode</c> describing delegate.
        /// <param name="cs">WMI Property <c>CS</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddNodeDelegate(object cs = default);

        /// <summary>
        /// WMI method <c>EvictNode</c> describing delegate.
        /// <param name="cs">WMI Property <c>CS</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EvictNodeDelegate(object cs = default);

        /// <summary>
        /// WMI method <c>StartService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StartServiceDelegate();

        /// <summary>
        /// WMI method <c>StopService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StopServiceDelegate();

        /// <summary>
        /// WMI method <c>AddNode</c>.
        /// </summary>
        public AddNodeDelegate AddNode;

        /// <summary>
        /// WMI method <c>EvictNode</c>.
        /// </summary>
        public EvictNodeDelegate EvictNode;

        /// <summary>
        /// WMI method <c>StartService</c>.
        /// </summary>
        public StartServiceDelegate StartService;

        /// <summary>
        /// WMI method <c>StopService</c>.
        /// </summary>
        public StopServiceDelegate StopService;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Started
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// WMI Property StartMode
        /// </summary>
        public string StartMode { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
    }
}