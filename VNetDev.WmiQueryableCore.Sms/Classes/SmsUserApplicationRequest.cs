using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UserApplicationRequest
    /// </summary>
    [WmiClass(Name = "SMS_UserApplicationRequest")]
    public class SmsUserApplicationRequest
    {
        /// <summary>
        /// WMI method <c>Approve</c> describing delegate.
        /// <param name="clientSource">WMI Property <c>ClientSource</c> of type <c>uint</c>.</param>
        /// <param name="comments">WMI Property <c>Comments</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ApproveDelegate(uint clientSource = default, string comments = default);
        /// <summary>
        /// WMI method <c>Approve</c>.
        /// </summary>
        public ApproveDelegate Approve;
        
        /// <summary>
        /// WMI method <c>Deny</c> describing delegate.
        /// <param name="clientSource">WMI Property <c>ClientSource</c> of type <c>uint</c>.</param>
        /// <param name="comments">WMI Property <c>Comments</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DenyDelegate(uint clientSource = default, string comments = default);
        /// <summary>
        /// WMI method <c>Deny</c>.
        /// </summary>
        public DenyDelegate Deny;
        
        /// <summary>
        /// WMI method <c>RetryInstall</c> describing delegate.
        /// <param name="clientSource">WMI Property <c>ClientSource</c> of type <c>uint</c>.</param>
        /// <param name="comments">WMI Property <c>Comments</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RetryInstallDelegate(uint clientSource = default, string comments = default);
        /// <summary>
        /// WMI method <c>RetryInstall</c>.
        /// </summary>
        public RetryInstallDelegate RetryInstall;
        
        /// <summary>
        /// WMI method <c>CreateApprovedRequest</c> describing delegate.
        /// <param name="applicationId">WMI Property <c>ApplicationId</c> of type <c>string</c>.</param>
        /// <param name="autoInstall">WMI Property <c>AutoInstall</c> of type <c>bool</c>.</param>
        /// <param name="clientGuid">WMI Property <c>ClientGUID</c> of type <c>string</c>.</param>
        /// <param name="comments">WMI Property <c>Comments</c> of type <c>string</c>.</param>
        /// <param name="username">WMI Property <c>Username</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateApprovedRequestDelegate(string applicationId = default, bool autoInstall = default, string clientGuid = default, string comments = default, string username = default);
        /// <summary>
        /// WMI method <c>CreateApprovedRequest</c>.
        /// </summary>
        public CreateApprovedRequestDelegate CreateApprovedRequest;
        /// <summary>
        /// WMI Property Application
        /// </summary>
        public string Application { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property Comments
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// WMI Property CurrentState
        /// </summary>
        public uint CurrentState { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastModifiedDate
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property RequestedMachine
        /// </summary>
        public string RequestedMachine { get; set; }
        /// <summary>
        /// WMI Property RequestGuid
        /// </summary>
        public string RequestGuid { get; set; }
        /// <summary>
        /// WMI Property RequestHistory
        /// </summary>
        public ICollection<object> RequestHistory { get; set; }
        /// <summary>
        /// WMI Property User
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// WMI Property UserSid
        /// </summary>
        public string UserSid { get; set; }
    }
}
