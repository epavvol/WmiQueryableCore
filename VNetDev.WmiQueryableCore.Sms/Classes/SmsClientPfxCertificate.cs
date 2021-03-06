using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientPfxCertificate
    /// </summary>
    [WmiClass(Name = "SMS_ClientPfxCertificate")]
    public class SmsClientPfxCertificate
    {
        /// <summary>
        /// WMI static method <c>ImportForUser</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="encryptedPfxBlob">WMI Property <c>EncryptedPfxBlob</c> of type <c>string</c>.</param>
        /// <param name="forSmimeEncryption">WMI Property <c>ForSMIMEEncryption</c> of type <c>bool</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="profileName">WMI Property <c>ProfileName</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportForUserDelegate(WmiContext wmiContext, string encryptedPfxBlob = default, bool forSmimeEncryption = default, string password = default, string profileName = default, string userName = default);
        /// <summary>
        /// WMI static method <c>ImportForUser</c>.
        /// </summary>
        public static ImportForUserDelegate ImportForUser;
        
        /// <summary>
        /// WMI static method <c>DeleteForUser</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="profileName">WMI Property <c>ProfileName</c> of type <c>string</c>.</param>
        /// <param name="thumbprint">WMI Property <c>Thumbprint</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteForUserDelegate(WmiContext wmiContext, string profileName = default, string thumbprint = default, string userName = default);
        /// <summary>
        /// WMI static method <c>DeleteForUser</c>.
        /// </summary>
        public static DeleteForUserDelegate DeleteForUser;
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public uint DeviceId { get; set; }
        /// <summary>
        /// WMI Property IsTombstoned
        /// </summary>
        public uint IsTombstoned { get; set; }
        /// <summary>
        /// WMI Property ProfileName
        /// </summary>
        public string ProfileName { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property UserItemKey
        /// </summary>
        public uint UserItemKey { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
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
