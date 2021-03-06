using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PendingRegistrationRecord
    /// </summary>
    [WmiClass(Name = "SMS_PendingRegistrationRecord")]
    public class SmsPendingRegistrationRecord
    {
        /// <summary>
        /// WMI static method <c>ResolvePendingRegistrationRecord</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="action">WMI Property <c>Action</c> of type <c>uint</c>.</param>
        /// <param name="smsid">WMI Property <c>SMSID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ResolvePendingRegistrationRecordDelegate(WmiContext wmiContext, uint action = default, string smsid = default);
        /// <summary>
        /// WMI static method <c>ResolvePendingRegistrationRecord</c>.
        /// </summary>
        public static ResolvePendingRegistrationRecordDelegate ResolvePendingRegistrationRecord;
        /// <summary>
        /// WMI Property AADDeviceID
        /// </summary>
        public string AadDeviceId { get; set; }
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property AgentName
        /// </summary>
        public string AgentName { get; set; }
        /// <summary>
        /// WMI Property Certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property ConflictSMSID
        /// </summary>
        public string ConflictSmsid { get; set; }
        /// <summary>
        /// WMI Property FQDN
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property HardwareID
        /// </summary>
        public string HardwareId { get; set; }
        /// <summary>
        /// WMI Property IsAlwaysInternet
        /// </summary>
        public bool IsAlwaysInternet { get; set; }
        /// <summary>
        /// WMI Property IsIntegratedAuth
        /// </summary>
        public bool IsIntegratedAuth { get; set; }
        /// <summary>
        /// WMI Property IsInternetEnabled
        /// </summary>
        public bool IsInternetEnabled { get; set; }
        /// <summary>
        /// WMI Property IssuedTo
        /// </summary>
        public string IssuedTo { get; set; }
        /// <summary>
        /// WMI Property KeyType
        /// </summary>
        public int KeyType { get; set; }
        /// <summary>
        /// WMI Property NetbiosName
        /// </summary>
        public string NetbiosName { get; set; }
        /// <summary>
        /// WMI Property PublicKey
        /// </summary>
        public string PublicKey { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property ValidFrom
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// WMI Property ValidUntil
        /// </summary>
        public DateTime ValidUntil { get; set; }
    }
}
