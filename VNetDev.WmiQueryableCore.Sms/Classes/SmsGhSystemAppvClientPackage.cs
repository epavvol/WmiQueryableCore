using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_APPV_CLIENT_PACKAGE
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_APPV_CLIENT_PACKAGE")]
    public class SmsGhSystemAppvClientPackage
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public string Assets { get; set; }
        /// <summary>
        /// WMI Property DeploymentMachineData
        /// </summary>
        public string DeploymentMachineData { get; set; }
        /// <summary>
        /// WMI Property DeploymentUserData
        /// </summary>
        public string DeploymentUserData { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HasAssetIntelligence
        /// </summary>
        public uint HasAssetIntelligence { get; set; }
        /// <summary>
        /// WMI Property InUse
        /// </summary>
        public uint InUse { get; set; }
        /// <summary>
        /// WMI Property IsPublishedGlobally
        /// </summary>
        public uint IsPublishedGlobally { get; set; }
        /// <summary>
        /// WMI Property IsPublishedToUser
        /// </summary>
        public uint IsPublishedToUser { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageId
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageSize
        /// </summary>
        public ulong PackageSize { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// WMI Property PercentLoaded
        /// </summary>
        public uint PercentLoaded { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UserConfigurationData
        /// </summary>
        public string UserConfigurationData { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VersionId
        /// </summary>
        public string VersionId { get; set; }
    }
}
