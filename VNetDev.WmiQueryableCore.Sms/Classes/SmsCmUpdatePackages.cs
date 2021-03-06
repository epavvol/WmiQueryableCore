using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdatePackages
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdatePackages")]
    public class SmsCmUpdatePackages
    {
        /// <summary>
        /// WMI method <c>UpdatePrereqAndStateFlags</c> describing delegate.
        /// <param name="flag">WMI Property <c>flag</c> of type <c>uint</c>.</param>
        /// <param name="state">WMI Property <c>state</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdatePrereqAndStateFlagsDelegate(uint flag = default, uint state = default);
        /// <summary>
        /// WMI method <c>UpdatePrereqAndStateFlags</c>.
        /// </summary>
        public UpdatePrereqAndStateFlagsDelegate UpdatePrereqAndStateFlags;
        
        /// <summary>
        /// WMI method <c>IsCurrentWorkingUpdatePackage</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsCurrentWorkingUpdatePackageDelegate();
        /// <summary>
        /// WMI method <c>IsCurrentWorkingUpdatePackage</c>.
        /// </summary>
        public IsCurrentWorkingUpdatePackageDelegate IsCurrentWorkingUpdatePackage;
        
        /// <summary>
        /// WMI method <c>RetryContentReplication</c> describing delegate.
        /// <param name="forceRetry">WMI Property <c>ForceRetry</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RetryContentReplicationDelegate(uint forceRetry = default);
        /// <summary>
        /// WMI method <c>RetryContentReplication</c>.
        /// </summary>
        public RetryContentReplicationDelegate RetryContentReplication;
        
        /// <summary>
        /// WMI method <c>SetIgnorePrereqWarning</c> describing delegate.
        /// <param name="flag">WMI Property <c>flag</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetIgnorePrereqWarningDelegate(uint flag = default);
        /// <summary>
        /// WMI method <c>SetIgnorePrereqWarning</c>.
        /// </summary>
        public SetIgnorePrereqWarningDelegate SetIgnorePrereqWarning;
        
        /// <summary>
        /// WMI method <c>SetPackageToBeDownloaded</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetPackageToBeDownloadedDelegate();
        /// <summary>
        /// WMI method <c>SetPackageToBeDownloaded</c>.
        /// </summary>
        public SetPackageToBeDownloadedDelegate SetPackageToBeDownloaded;
        
        /// <summary>
        /// WMI method <c>PackageExistsInToBeDownloadedList</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint PackageExistsInToBeDownloadedListDelegate();
        /// <summary>
        /// WMI method <c>PackageExistsInToBeDownloadedList</c>.
        /// </summary>
        public PackageExistsInToBeDownloadedListDelegate PackageExistsInToBeDownloadedList;
        
        /// <summary>
        /// WMI method <c>InitiateUpgrade</c> describing delegate.
        /// <param name="prereqFlag">WMI Property <c>PrereqFlag</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitiateUpgradeDelegate(uint prereqFlag = default);
        /// <summary>
        /// WMI method <c>InitiateUpgrade</c>.
        /// </summary>
        public InitiateUpgradeDelegate InitiateUpgrade;
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateReleased
        /// </summary>
        public DateTime DateReleased { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property EULA
        /// </summary>
        public string Eula { get; set; }
        /// <summary>
        /// WMI Property EulaLink
        /// </summary>
        public string EulaLink { get; set; }
        /// <summary>
        /// WMI Property FullVersion
        /// </summary>
        public string FullVersion { get; set; }
        /// <summary>
        /// WMI Property Impact
        /// </summary>
        public int Impact { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public int LocaleId { get; set; }
        /// <summary>
        /// WMI Property MaxCMVersion
        /// </summary>
        public string MaxCmVersion { get; set; }
        /// <summary>
        /// WMI Property MinCMVersion
        /// </summary>
        public string MinCmVersion { get; set; }
        /// <summary>
        /// WMI Property MoreInfoLink
        /// </summary>
        public string MoreInfoLink { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageGuid
        /// </summary>
        public string PackageGuid { get; set; }
        /// <summary>
        /// WMI Property PrereqBinary
        /// </summary>
        public string PrereqBinary { get; set; }
        /// <summary>
        /// WMI Property PrereqFlag
        /// </summary>
        public int PrereqFlag { get; set; }
        /// <summary>
        /// WMI Property PrereqPackageName
        /// </summary>
        public string PrereqPackageName { get; set; }
        /// <summary>
        /// WMI Property PrereqPackageState
        /// </summary>
        public int PrereqPackageState { get; set; }
        /// <summary>
        /// WMI Property PublisherFlags
        /// </summary>
        public int PublisherFlags { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// WMI Property SupersededByNameList
        /// </summary>
        public string SupersededByNameList { get; set; }
        /// <summary>
        /// WMI Property SupersedesNameList
        /// </summary>
        public string SupersedesNameList { get; set; }
        /// <summary>
        /// WMI Property UpdateType
        /// </summary>
        public int UpdateType { get; set; }
        /// <summary>
        /// WMI Property WarningFlag
        /// </summary>
        public int WarningFlag { get; set; }
    }
}
