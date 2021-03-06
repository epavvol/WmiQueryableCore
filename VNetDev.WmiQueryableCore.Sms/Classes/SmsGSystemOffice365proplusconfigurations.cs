using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OFFICE365PROPLUSCONFIGURATIONS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OFFICE365PROPLUSCONFIGURATIONS")]
    public class SmsGSystemOffice365proplusconfigurations
    {
        /// <summary>
        /// WMI Property AutoUpgrade
        /// </summary>
        public string AutoUpgrade { get; set; }
        /// <summary>
        /// WMI Property CCMManaged
        /// </summary>
        public string CcmManaged { get; set; }
        /// <summary>
        /// WMI Property CDNBaseUrl
        /// </summary>
        public string CdnBaseUrl { get; set; }
        /// <summary>
        /// WMI Property cfgUpdateChannel
        /// </summary>
        public string CfgUpdateChannel { get; set; }
        /// <summary>
        /// WMI Property ClientCulture
        /// </summary>
        public string ClientCulture { get; set; }
        /// <summary>
        /// WMI Property ClientFolder
        /// </summary>
        public string ClientFolder { get; set; }
        /// <summary>
        /// WMI Property GPOChannel
        /// </summary>
        public string GpoChannel { get; set; }
        /// <summary>
        /// WMI Property GPOOfficeMgmtCOM
        /// </summary>
        public string GpoOfficeMgmtCom { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallationPath
        /// </summary>
        public string InstallationPath { get; set; }
        /// <summary>
        /// WMI Property KeyName
        /// </summary>
        public string KeyName { get; set; }
        /// <summary>
        /// WMI Property LastScenario
        /// </summary>
        public string LastScenario { get; set; }
        /// <summary>
        /// WMI Property LastScenarioResult
        /// </summary>
        public string LastScenarioResult { get; set; }
        /// <summary>
        /// WMI Property OfficeMgmtCOM
        /// </summary>
        public string OfficeMgmtCom { get; set; }
        /// <summary>
        /// WMI Property Platform
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SharedComputerLicensing
        /// </summary>
        public string SharedComputerLicensing { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UpdateChannel
        /// </summary>
        public string UpdateChannel { get; set; }
        /// <summary>
        /// WMI Property UpdatePath
        /// </summary>
        public string UpdatePath { get; set; }
        /// <summary>
        /// WMI Property UpdatesEnabled
        /// </summary>
        public string UpdatesEnabled { get; set; }
        /// <summary>
        /// WMI Property UpdateUrl
        /// </summary>
        public string UpdateUrl { get; set; }
        /// <summary>
        /// WMI Property VersionToReport
        /// </summary>
        public string VersionToReport { get; set; }
    }
}
