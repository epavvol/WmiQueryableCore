using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AIHardwareRequirements
    /// </summary>
    [WmiClass(Name = "SMS_AIHardwareRequirements")]
    public class SmsAiHardwareRequirements
    {
        /// <summary>
        /// WMI static method <c>GetSummary</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSummaryDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSummary</c>.
        /// </summary>
        public static GetSummaryDelegate GetSummary;
        /// <summary>
        /// WMI Property IsLocal
        /// </summary>
        public bool IsLocal { get; set; }
        /// <summary>
        /// WMI Property MinCPU
        /// </summary>
        public uint MinCpu { get; set; }
        /// <summary>
        /// WMI Property MinDiskFree
        /// </summary>
        public long MinDiskFree { get; set; }
        /// <summary>
        /// WMI Property MinDiskSize
        /// </summary>
        public long MinDiskSize { get; set; }
        /// <summary>
        /// WMI Property MinRAM
        /// </summary>
        public long MinRam { get; set; }
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
