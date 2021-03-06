using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_R_UserGroup
    /// </summary>
    [WmiClass(Name = "SMS_R_UserGroup")]
    public class SmsRUserGroup
    {
        /// <summary>
        /// WMI Property AADGroupID
        /// </summary>
        public string AadGroupId { get; set; }
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property ActiveDirectoryContainerName
        /// </summary>
        public ICollection<string> ActiveDirectoryContainerName { get; set; }
        /// <summary>
        /// WMI Property ActiveDirectoryOrganizationalUnit
        /// </summary>
        public ICollection<string> ActiveDirectoryOrganizationalUnit { get; set; }
        /// <summary>
        /// WMI Property ADDomainName
        /// </summary>
        public string AdDomainName { get; set; }
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
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property GroupType
        /// </summary>
        public uint GroupType { get; set; }
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
        /// WMI Property ResourceId
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// WMI Property UniqueUsergroupName
        /// </summary>
        public string UniqueUsergroupName { get; set; }
        /// <summary>
        /// WMI Property UsergroupName
        /// </summary>
        public string UsergroupName { get; set; }
        /// <summary>
        /// WMI Property WindowsNTDomain
        /// </summary>
        public string WindowsNtDomain { get; set; }
    }
}
