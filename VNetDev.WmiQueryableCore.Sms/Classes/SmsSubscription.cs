using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Subscription
    /// </summary>
    [WmiClass(Name = "SMS_Subscription")]
    public class SmsSubscription
    {
        /// <summary>
        /// WMI static method <c>GetAvailableLanguages</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetAvailableLanguagesDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetAvailableLanguages</c>.
        /// </summary>
        public static GetAvailableLanguagesDelegate GetAvailableLanguages;
        
        /// <summary>
        /// WMI static method <c>TestSmtpConnection</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="authenticationType">WMI Property <c>AuthenticationType</c> of type <c>uint</c>.</param>
        /// <param name="encryptPassword">WMI Property <c>EncryptPassword</c> of type <c>string</c>.</param>
        /// <param name="port">WMI Property <c>Port</c> of type <c>uint</c>.</param>
        /// <param name="recipients">WMI Property <c>Recipients</c> of type <c>string</c>.</param>
        /// <param name="sender">WMI Property <c>Sender</c> of type <c>string</c>.</param>
        /// <param name="serverFqdn">WMI Property <c>ServerFqdn</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <param name="useSsl">WMI Property <c>UseSSL</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TestSmtpConnectionDelegate(WmiContext wmiContext, uint authenticationType = default, string encryptPassword = default, uint port = default, string recipients = default, string sender = default, string serverFqdn = default, string userName = default, bool useSsl = default);
        /// <summary>
        /// WMI static method <c>TestSmtpConnection</c>.
        /// </summary>
        public static TestSmtpConnectionDelegate TestSmtpConnection;
        
        /// <summary>
        /// WMI static method <c>GetTestSmtpConnectionResult</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="testId">WMI Property <c>TestID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetTestSmtpConnectionResultDelegate(WmiContext wmiContext, uint testId = default);
        /// <summary>
        /// WMI static method <c>GetTestSmtpConnectionResult</c>.
        /// </summary>
        public static GetTestSmtpConnectionResultDelegate GetTestSmtpConnectionResult;
        /// <summary>
        /// WMI Property AlertIDs
        /// </summary>
        public ICollection<uint> AlertIDs { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property EmailAddress
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// WMI Property EmailTemplates
        /// </summary>
        public ICollection<object> EmailTemplates { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
