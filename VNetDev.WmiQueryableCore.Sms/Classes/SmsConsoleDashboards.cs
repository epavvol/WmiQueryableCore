using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConsoleDashboards
    /// </summary>
    [WmiClass(Name = "SMS_ConsoleDashboards")]
    public class SmsConsoleDashboards
    {
        /// <summary>
        /// WMI static method <c>GetChartData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="chartConfigData">WMI Property <c>ChartConfigData</c> of type <c>string</c>.</param>
        /// <param name="chartGuid">WMI Property <c>ChartGuid</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetChartDataDelegate(WmiContext wmiContext, string chartConfigData = default, string chartGuid = default);
        /// <summary>
        /// WMI static method <c>GetChartData</c>.
        /// </summary>
        public static GetChartDataDelegate GetChartData;
        
        /// <summary>
        /// WMI static method <c>GetChartDataPerRow</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="chartConfigData">WMI Property <c>ChartConfigData</c> of type <c>string</c>.</param>
        /// <param name="chartGuid">WMI Property <c>ChartGuid</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetChartDataPerRowDelegate(WmiContext wmiContext, string chartConfigData = default, string chartGuid = default);
        /// <summary>
        /// WMI static method <c>GetChartDataPerRow</c>.
        /// </summary>
        public static GetChartDataPerRowDelegate GetChartDataPerRow;
    }
}
