using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMAppleVppToken
    /// </summary>
    [WmiClass(Name = "SMS_MDMAppleVppToken")]
    public class SmsMdmAppleVppToken
    {
        /// <summary>
        /// WMI static method <c>SyncToken</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="vppIntuneTokenId">WMI Property <c>VppIntuneTokenId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SyncTokenDelegate(WmiContext wmiContext, string vppIntuneTokenId = default);
        /// <summary>
        /// WMI static method <c>SyncToken</c>.
        /// </summary>
        public static SyncTokenDelegate SyncToken;
        
        /// <summary>
        /// WMI static method <c>UploadToken</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="expirationDate">WMI Property <c>ExpirationDate</c> of type <c>string</c>.</param>
        /// <param name="organizationName">WMI Property <c>OrganizationName</c> of type <c>string</c>.</param>
        /// <param name="tokenId">WMI Property <c>TokenID</c> of type <c>string</c>.</param>
        /// <param name="vppToken">WMI Property <c>VppToken</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UploadTokenDelegate(WmiContext wmiContext, string expirationDate = default, string organizationName = default, string tokenId = default, string vppToken = default);
        /// <summary>
        /// WMI static method <c>UploadToken</c>.
        /// </summary>
        public static UploadTokenDelegate UploadToken;
        
        /// <summary>
        /// WMI static method <c>RenewToken</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="expirationDate">WMI Property <c>ExpirationDate</c> of type <c>string</c>.</param>
        /// <param name="organizationName">WMI Property <c>OrganizationName</c> of type <c>string</c>.</param>
        /// <param name="tokenId">WMI Property <c>TokenID</c> of type <c>string</c>.</param>
        /// <param name="vppIntuneTokenId">WMI Property <c>VppIntuneTokenId</c> of type <c>string</c>.</param>
        /// <param name="vppToken">WMI Property <c>VppToken</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RenewTokenDelegate(WmiContext wmiContext, string expirationDate = default, string organizationName = default, string tokenId = default, string vppIntuneTokenId = default, string vppToken = default);
        /// <summary>
        /// WMI static method <c>RenewToken</c>.
        /// </summary>
        public static RenewTokenDelegate RenewToken;
        
        /// <summary>
        /// WMI static method <c>ReadTokensByAppID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="applicationId">WMI Property <c>ApplicationID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReadTokensByAppIdDelegate(WmiContext wmiContext, string applicationId = default);
        /// <summary>
        /// WMI static method <c>ReadTokensByAppID</c>.
        /// </summary>
        public static ReadTokensByAppIdDelegate ReadTokensByAppId;
        /// <summary>
        /// WMI Property AppleID
        /// </summary>
        public string AppleId { get; set; }
        /// <summary>
        /// WMI Property Created
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// WMI Property Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSync
        /// </summary>
        public DateTime LastSuccessfulSync { get; set; }
        /// <summary>
        /// WMI Property LastSync
        /// </summary>
        public DateTime LastSync { get; set; }
        /// <summary>
        /// WMI Property LastUpdated
        /// </summary>
        public DateTime LastUpdated { get; set; }
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
        /// WMI Property SyncStatus
        /// </summary>
        public int SyncStatus { get; set; }
        /// <summary>
        /// WMI Property TokenHash
        /// </summary>
        public string TokenHash { get; set; }
        /// <summary>
        /// WMI Property TokenType
        /// </summary>
        public uint TokenType { get; set; }
        /// <summary>
        /// WMI Property VppIntuneTokenId
        /// </summary>
        public string VppIntuneTokenId { get; set; }
    }
}
