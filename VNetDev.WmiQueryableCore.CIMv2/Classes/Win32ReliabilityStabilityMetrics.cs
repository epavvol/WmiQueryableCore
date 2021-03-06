using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ReliabilityStabilityMetrics
    /// </summary>
    [WmiClass(Name = "Win32_ReliabilityStabilityMetrics")]
    public class Win32ReliabilityStabilityMetrics
    {
        /// <summary>
        /// WMI static method <c>GetRecordCount</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetRecordCountDelegate(WmiContext wmiContext);

        /// <summary>
        /// WMI static method <c>GetRecordCount</c>.
        /// </summary>
        public static GetRecordCountDelegate GetRecordCount;

        /// <summary>
        /// WMI Property EndMeasurementDate
        /// </summary>
        public DateTime EndMeasurementDate { get; set; }

        /// <summary>
        /// WMI Property RelID
        /// </summary>
        public string RelId { get; set; }

        /// <summary>
        /// WMI Property StartMeasurementDate
        /// </summary>
        public DateTime StartMeasurementDate { get; set; }

        /// <summary>
        /// WMI Property SystemStabilityIndex
        /// </summary>
        public double SystemStabilityIndex { get; set; }

        /// <summary>
        /// WMI Property TimeGenerated
        /// </summary>
        public DateTime TimeGenerated { get; set; }
    }
}