using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365ACollection
    /// </summary>
    [WmiClass(Name = "SMS_M365ACollection")]
    public class SmsM365aCollection
    {
        /// <summary>
        /// WMI static method <c>ClearM365ACollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="aadAppId">WMI Property <c>AADAppID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearM365aCollectionsDelegate(WmiContext wmiContext, string aadAppId = default);
        /// <summary>
        /// WMI static method <c>ClearM365ACollections</c>.
        /// </summary>
        public static ClearM365aCollectionsDelegate ClearM365aCollections;
        /// <summary>
        /// WMI Property AADAppID
        /// </summary>
        public string AadAppId { get; set; }
        /// <summary>
        /// WMI Property CollectionEnabled
        /// </summary>
        public bool CollectionEnabled { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property IsLimitingCollection
        /// </summary>
        public bool IsLimitingCollection { get; set; }
        /// <summary>
        /// WMI Property LastUploadMessage
        /// </summary>
        public string LastUploadMessage { get; set; }
        /// <summary>
        /// WMI Property LastUploadStatus
        /// </summary>
        public int LastUploadStatus { get; set; }
        /// <summary>
        /// WMI Property LastUploadTime
        /// </summary>
        public DateTime LastUploadTime { get; set; }
    }
}
