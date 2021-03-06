using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_R_User
    /// </summary>
    [WmiClass(Name = "SMS_R_User")]
    public class SmsRUser
    {
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property AADUserID
        /// </summary>
        public string AadUserId { get; set; }
        /// <summary>
        /// WMI Property ADObjectCreationTime
        /// </summary>
        public DateTime AdObjectCreationTime { get; set; }
        /// <summary>
        /// WMI Property AgentName
        /// </summary>
        public ICollection<string> AgentName { get; set; }
        /// <summary>
        /// WMI Property AgentSite
        /// </summary>
        public ICollection<string> AgentSite { get; set; }
        /// <summary>
        /// WMI Property AgentTime
        /// </summary>
        public ICollection<DateTime> AgentTime { get; set; }
        /// <summary>
        /// WMI Property CloudUserId
        /// </summary>
        public string CloudUserId { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property DistinguishedName
        /// </summary>
        public string DistinguishedName { get; set; }
        /// <summary>
        /// WMI Property FullDomainName
        /// </summary>
        public string FullDomainName { get; set; }
        /// <summary>
        /// WMI Property FullUserName
        /// </summary>
        public string FullUserName { get; set; }
        /// <summary>
        /// WMI Property Mail
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NetworkOperatingSystem
        /// </summary>
        public string NetworkOperatingSystem { get; set; }
        /// <summary>
        /// WMI Property ObjectGUID
        /// </summary>
        public ICollection<byte> ObjectGuid { get; set; }
        /// <summary>
        /// WMI Property PrimaryGroupID
        /// </summary>
        public uint PrimaryGroupId { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SecurityGroupName
        /// </summary>
        public ICollection<string> SecurityGroupName { get; set; }
        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// WMI Property UniqueUserName
        /// </summary>
        public string UniqueUserName { get; set; }
        /// <summary>
        /// WMI Property UserAccountControl
        /// </summary>
        public uint UserAccountControl { get; set; }
        /// <summary>
        /// WMI Property UserContainerName
        /// </summary>
        public ICollection<string> UserContainerName { get; set; }
        /// <summary>
        /// WMI Property UserGroupName
        /// </summary>
        public ICollection<string> UserGroupName { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property UserOUName
        /// </summary>
        public ICollection<string> UserOuName { get; set; }
        /// <summary>
        /// WMI Property UserPrincipalName
        /// </summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// WMI Property WindowsNTDomain
        /// </summary>
        public string WindowsNtDomain { get; set; }
    }
}
