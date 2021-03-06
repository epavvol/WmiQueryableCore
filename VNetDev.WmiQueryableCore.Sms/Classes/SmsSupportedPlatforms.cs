using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SupportedPlatforms
    /// </summary>
    [WmiClass(Name = "SMS_SupportedPlatforms")]
    public class SmsSupportedPlatforms
    {
        /// <summary>
        /// WMI static method <c>GetSupportedPlatformFromOSTag</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSupportedPlatformFromOsTagDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSupportedPlatformFromOSTag</c>.
        /// </summary>
        public static GetSupportedPlatformFromOsTagDelegate GetSupportedPlatformFromOsTag;
        
        /// <summary>
        /// WMI method <c>Enable</c> describing delegate.
        /// <param name="isSupported">WMI Property <c>IsSupported</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint EnableDelegate(bool isSupported = default);
        /// <summary>
        /// WMI method <c>Enable</c>.
        /// </summary>
        public EnableDelegate Enable;
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// WMI Property DisplayText
        /// </summary>
        public string DisplayText { get; set; }
        /// <summary>
        /// WMI Property IsSupported
        /// </summary>
        public bool IsSupported { get; set; }
        /// <summary>
        /// WMI Property OSMaxVersion
        /// </summary>
        public string OsMaxVersion { get; set; }
        /// <summary>
        /// WMI Property OSMinVersion
        /// </summary>
        public string OsMinVersion { get; set; }
        /// <summary>
        /// WMI Property OSName
        /// </summary>
        public string OsName { get; set; }
        /// <summary>
        /// WMI Property OSPlatform
        /// </summary>
        public string OsPlatform { get; set; }
        /// <summary>
        /// WMI Property ResourceDll
        /// </summary>
        public string ResourceDll { get; set; }
        /// <summary>
        /// WMI Property StringId
        /// </summary>
        public uint StringId { get; set; }
    }
}
