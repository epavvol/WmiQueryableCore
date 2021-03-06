using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_InventoryReport
    /// </summary>
    [WmiClass(Name = "SMS_InventoryReport")]
    public class SmsInventoryReport
    {
        /// <summary>
        /// WMI static method <c>ImportInventoryReport</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="importType">WMI Property <c>ImportType</c> of type <c>uint</c>.</param>
        /// <param name="inventoryReportId">WMI Property <c>InventoryReportID</c> of type <c>string</c>.</param>
        /// <param name="mofBuffer">WMI Property <c>MofBuffer</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportInventoryReportDelegate(WmiContext wmiContext, uint importType = default, string inventoryReportId = default, string mofBuffer = default);
        /// <summary>
        /// WMI static method <c>ImportInventoryReport</c>.
        /// </summary>
        public static ImportInventoryReportDelegate ImportInventoryReport;
        /// <summary>
        /// WMI Property DefaultTimeout
        /// </summary>
        public uint DefaultTimeout { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property InventoryReportID
        /// </summary>
        public string InventoryReportId { get; set; }
        /// <summary>
        /// WMI Property ReportClasses
        /// </summary>
        public ICollection<SmsInventoryReportClass> ReportClasses { get; set; }
        /// <summary>
        /// WMI Property ReportTimeout
        /// </summary>
        public uint ReportTimeout { get; set; }
    }
}
