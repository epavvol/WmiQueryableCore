using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDownloadSources
    /// </summary>
    [WmiClass(Name = "SMS_ClientDownloadSources")]
    public class SmsClientDownloadSources
    {
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesContent</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="boundaryGroupId">WMI Property <c>BoundaryGroupID</c> of type <c>uint</c>.</param>
        /// <param name="reportedDays">WMI Property <c>ReportedDays</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientDataSourcesContentDelegate(WmiContext wmiContext, uint boundaryGroupId = default, uint reportedDays = default);
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesContent</c>.
        /// </summary>
        public static GetClientDataSourcesContentDelegate GetClientDataSourcesContent;
        
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesContentStats</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="boundaryGroupId">WMI Property <c>BoundaryGroupID</c> of type <c>uint</c>.</param>
        /// <param name="reportedDays">WMI Property <c>ReportedDays</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientDataSourcesContentStatsDelegate(WmiContext wmiContext, uint boundaryGroupId = default, uint reportedDays = default);
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesContentStats</c>.
        /// </summary>
        public static GetClientDataSourcesContentStatsDelegate GetClientDataSourcesContentStats;
        
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesDeviceCount</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="boundaryGroupId">WMI Property <c>BoundaryGroupID</c> of type <c>uint</c>.</param>
        /// <param name="reportedDays">WMI Property <c>ReportedDays</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientDataSourcesDeviceCountDelegate(WmiContext wmiContext, uint boundaryGroupId = default, uint reportedDays = default);
        /// <summary>
        /// WMI static method <c>GetClientDataSourcesDeviceCount</c>.
        /// </summary>
        public static GetClientDataSourcesDeviceCountDelegate GetClientDataSourcesDeviceCount;
    }
}
