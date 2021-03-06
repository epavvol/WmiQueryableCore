using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StateMigration
    /// </summary>
    [WmiClass(Name = "SMS_StateMigration")]
    public class SmsStateMigration
    {
        /// <summary>
        /// WMI static method <c>AddAssociation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="restoreClientResourceId">WMI Property <c>RestoreClientResourceID</c> of type <c>uint</c>.</param>
        /// <param name="sourceClientResourceId">WMI Property <c>SourceClientResourceID</c> of type <c>uint</c>.</param>
        /// <param name="userNames">WMI Property <c>UserNames</c> of type <c>ICollection{SmsStateMigrationUserNames}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddAssociationDelegate(WmiContext wmiContext, uint restoreClientResourceId = default, uint sourceClientResourceId = default, ICollection<SmsStateMigrationUserNames> userNames = default);
        /// <summary>
        /// WMI static method <c>AddAssociation</c>.
        /// </summary>
        public static AddAssociationDelegate AddAssociation;
        
        /// <summary>
        /// WMI static method <c>DeleteAssociation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="restoreClientResourceId">WMI Property <c>RestoreClientResourceID</c> of type <c>uint</c>.</param>
        /// <param name="sourceClientResourceId">WMI Property <c>SourceClientResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteAssociationDelegate(WmiContext wmiContext, uint restoreClientResourceId = default, uint sourceClientResourceId = default);
        /// <summary>
        /// WMI static method <c>DeleteAssociation</c>.
        /// </summary>
        public static DeleteAssociationDelegate DeleteAssociation;
        
        /// <summary>
        /// WMI method <c>GetEncryptDecryptKey</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetEncryptDecryptKeyDelegate();
        /// <summary>
        /// WMI method <c>GetEncryptDecryptKey</c>.
        /// </summary>
        public GetEncryptDecryptKeyDelegate GetEncryptDecryptKey;
        
        /// <summary>
        /// WMI static method <c>AddAssociationEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="migrationBehavior">WMI Property <c>MigrationBehavior</c> of type <c>uint</c>.</param>
        /// <param name="restoreClientResourceId">WMI Property <c>RestoreClientResourceID</c> of type <c>uint</c>.</param>
        /// <param name="sourceClientResourceId">WMI Property <c>SourceClientResourceID</c> of type <c>uint</c>.</param>
        /// <param name="userNames">WMI Property <c>UserNames</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddAssociationExDelegate(WmiContext wmiContext, uint migrationBehavior = default, uint restoreClientResourceId = default, uint sourceClientResourceId = default,  ICollection<SmsStateMigrationUserNames> userNames = default);
        /// <summary>
        /// WMI static method <c>AddAssociationEx</c>.
        /// </summary>
        public static AddAssociationExDelegate AddAssociationEx;
        /// <summary>
        /// WMI Property MigrationBehavior
        /// </summary>
        public uint MigrationBehavior { get; set; }
        /// <summary>
        /// WMI Property MigrationID
        /// </summary>
        public string MigrationId { get; set; }
        /// <summary>
        /// WMI Property MigrationStatus
        /// </summary>
        public uint MigrationStatus { get; set; }
        /// <summary>
        /// WMI Property MigrationType
        /// </summary>
        public uint MigrationType { get; set; }
        /// <summary>
        /// WMI Property RestoreClientResourceID
        /// </summary>
        public uint RestoreClientResourceId { get; set; }
        /// <summary>
        /// WMI Property RestoreLastLogonUserDomain
        /// </summary>
        public string RestoreLastLogonUserDomain { get; set; }
        /// <summary>
        /// WMI Property RestoreLastLogonUserName
        /// </summary>
        public string RestoreLastLogonUserName { get; set; }
        /// <summary>
        /// WMI Property RestoreMACAddresses
        /// </summary>
        public string RestoreMacAddresses { get; set; }
        /// <summary>
        /// WMI Property RestoreName
        /// </summary>
        public string RestoreName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceClientResourceID
        /// </summary>
        public uint SourceClientResourceId { get; set; }
        /// <summary>
        /// WMI Property SourceLastLogonUserDomain
        /// </summary>
        public string SourceLastLogonUserDomain { get; set; }
        /// <summary>
        /// WMI Property SourceLastLogonUserName
        /// </summary>
        public string SourceLastLogonUserName { get; set; }
        /// <summary>
        /// WMI Property SourceMACAddresses
        /// </summary>
        public string SourceMacAddresses { get; set; }
        /// <summary>
        /// WMI Property SourceName
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// WMI Property StoreCreationDate
        /// </summary>
        public DateTime StoreCreationDate { get; set; }
        /// <summary>
        /// WMI Property StoreDeletionDate
        /// </summary>
        public DateTime StoreDeletionDate { get; set; }
        /// <summary>
        /// WMI Property StorePath
        /// </summary>
        public string StorePath { get; set; }
        /// <summary>
        /// WMI Property StoreReleaseDate
        /// </summary>
        public DateTime StoreReleaseDate { get; set; }
        /// <summary>
        /// WMI Property UserNames
        /// </summary>
        public ICollection<object> UserNames { get; set; }
    }
}
