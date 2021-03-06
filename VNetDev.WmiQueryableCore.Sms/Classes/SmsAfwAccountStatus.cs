using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AfwAccountStatus
    /// </summary>
    [WmiClass(Name = "SMS_AfwAccountStatus")]
    public class SmsAfwAccountStatus
    {
        /// <summary>
        /// WMI static method <c>Sync</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="enterpriseId">WMI Property <c>EnterpriseID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SyncDelegate(WmiContext wmiContext, string enterpriseId = default);
        /// <summary>
        /// WMI static method <c>Sync</c>.
        /// </summary>
        public static SyncDelegate Sync;
        /// <summary>
        /// WMI Property AccountID
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSync
        /// </summary>
        public DateTime LastSuccessfulSync { get; set; }
        /// <summary>
        /// WMI Property LastSync
        /// </summary>
        public DateTime LastSync { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OrganizationName
        /// </summary>
        public string OrganizationName { get; set; }
        /// <summary>
        /// WMI Property SyncErrorCode
        /// </summary>
        public string SyncErrorCode { get; set; }
        /// <summary>
        /// WMI Property SyncStartTime
        /// </summary>
        public DateTime SyncStartTime { get; set; }
        /// <summary>
        /// WMI Property SyncStatusID
        /// </summary>
        public int SyncStatusId { get; set; }
    }
}
