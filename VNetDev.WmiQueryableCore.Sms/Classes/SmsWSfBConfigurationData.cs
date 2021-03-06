using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WSfBConfigurationData
    /// </summary>
    [WmiClass(Name = "SMS_WSfBConfigurationData")]
    public class SmsWSfBConfigurationData
    {
        /// <summary>
        /// WMI static method <c>Unenroll</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UnenrollDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>Unenroll</c>.
        /// </summary>
        public static UnenrollDelegate Unenroll;
        /// <summary>
        /// WMI Property ClientId
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// WMI Property ContentLocation
        /// </summary>
        public string ContentLocation { get; set; }
        /// <summary>
        /// WMI Property DefaultLocale
        /// </summary>
        public string DefaultLocale { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSyncTime
        /// </summary>
        public DateTime LastSuccessfulSyncTime { get; set; }
        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public int LastSyncStatus { get; set; }
        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public DateTime LastSyncTime { get; set; }
        /// <summary>
        /// WMI Property SelectedLocales
        /// </summary>
        public string SelectedLocales { get; set; }
        /// <summary>
        /// WMI Property TenantId
        /// </summary>
        public string TenantId { get; set; }
    }
}
