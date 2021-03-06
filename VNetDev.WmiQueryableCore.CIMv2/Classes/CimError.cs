using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Error
    /// </summary>
    [WmiClass(Name = "CIM_Error")]
    public class CimError
    {
        /// <summary>
        /// WMI Property CIMStatusCode
        /// </summary>
        public uint CimStatusCode { get; set; }

        /// <summary>
        /// WMI Property CIMStatusCodeDescription
        /// </summary>
        public string CimStatusCodeDescription { get; set; }

        /// <summary>
        /// WMI Property ErrorSource
        /// </summary>
        public string ErrorSource { get; set; }

        /// <summary>
        /// WMI Property ErrorSourceFormat
        /// </summary>
        public ushort ErrorSourceFormat { get; set; }

        /// <summary>
        /// WMI Property ErrorType
        /// </summary>
        public ushort ErrorType { get; set; }

        /// <summary>
        /// WMI Property Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// WMI Property MessageArguments
        /// </summary>
        public ICollection<string> MessageArguments { get; set; }

        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// WMI Property OtherErrorSourceFormat
        /// </summary>
        public string OtherErrorSourceFormat { get; set; }

        /// <summary>
        /// WMI Property OtherErrorType
        /// </summary>
        public string OtherErrorType { get; set; }

        /// <summary>
        /// WMI Property OWningEntity
        /// </summary>
        public string OWningEntity { get; set; }

        /// <summary>
        /// WMI Property PerceivedSeverity
        /// </summary>
        public ushort PerceivedSeverity { get; set; }

        /// <summary>
        /// WMI Property ProbableCause
        /// </summary>
        public ushort ProbableCause { get; set; }

        /// <summary>
        /// WMI Property ProbableCauseDescription
        /// </summary>
        public string ProbableCauseDescription { get; set; }

        /// <summary>
        /// WMI Property RecommendedActions
        /// </summary>
        public ICollection<string> RecommendedActions { get; set; }
    }
}