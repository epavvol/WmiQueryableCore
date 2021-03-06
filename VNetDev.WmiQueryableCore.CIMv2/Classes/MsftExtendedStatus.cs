using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_ExtendedStatus
    /// </summary>
    [WmiClass(Name = "MSFT_ExtendedStatus")]
    public class MsftExtendedStatus
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
        /// WMI Property error_Category
        /// </summary>
        [WmiProperty(Name = "error_Category")]
        public ushort MsftErrorCategory { get; set; }

        /// <summary>
        /// WMI Property error_Code
        /// </summary>
        [WmiProperty(Name = "error_Code")]
        public uint MsftErrorCode { get; set; }

        /// <summary>
        /// WMI Property error_Type
        /// </summary>
        [WmiProperty(Name = "error_Type")]
        public string MsftErrorType { get; set; }

        /// <summary>
        /// WMI Property error_WindowsErrorMessage
        /// </summary>
        [WmiProperty(Name = "error_WindowsErrorMessage")]
        public string MsftErrorWindowsErrorMessage { get; set; }

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
        /// WMI Property original_error
        /// </summary>
        [WmiProperty(Name = "original_error")]
        public object MsftOriginalError { get; set; }

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