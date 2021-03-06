using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Advertisement
    /// </summary>
    [WmiClass(Name = "SMS_Advertisement")]
    public class SmsAdvertisement
    {
        /// <summary>
        /// WMI static method <c>GetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNextIdDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetNextID</c>.
        /// </summary>
        public static GetNextIdDelegate GetNextId;
        
        /// <summary>
        /// WMI static method <c>SetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nextId">WMI Property <c>NextID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetNextIdDelegate(WmiContext wmiContext, uint nextId = default);
        /// <summary>
        /// WMI static method <c>SetNextID</c>.
        /// </summary>
        public static SetNextIdDelegate SetNextId;
        
        /// <summary>
        /// WMI method <c>Unlock</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UnlockDelegate();
        /// <summary>
        /// WMI method <c>Unlock</c>.
        /// </summary>
        public UnlockDelegate Unlock;
        
        /// <summary>
        /// WMI method <c>SetSourceSite</c> describing delegate.
        /// <param name="sourceSite">WMI Property <c>SourceSite</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetSourceSiteDelegate(string sourceSite = default);
        /// <summary>
        /// WMI method <c>SetSourceSite</c>.
        /// </summary>
        public SetSourceSiteDelegate SetSourceSite;
        
        /// <summary>
        /// WMI static method <c>GetAdvertisements</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetAdvertisementsDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>GetAdvertisements</c>.
        /// </summary>
        public static GetAdvertisementsDelegate GetAdvertisements;
        
        /// <summary>
        /// WMI static method <c>RiskyDeploymentStatusMessage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <param name="deploymentId">WMI Property <c>DeploymentID</c> of type <c>string</c>.</param>
        /// <param name="deploymentName">WMI Property <c>DeploymentName</c> of type <c>string</c>.</param>
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RiskyDeploymentStatusMessageDelegate(WmiContext wmiContext, string collectionId = default, string deploymentId = default, string deploymentName = default, string packageId = default);
        /// <summary>
        /// WMI static method <c>RiskyDeploymentStatusMessage</c>.
        /// </summary>
        public static RiskyDeploymentStatusMessageDelegate RiskyDeploymentStatusMessage;
        /// <summary>
        /// WMI Property ActionInProgress
        /// </summary>
        public uint ActionInProgress { get; set; }
        /// <summary>
        /// WMI Property AdvertFlags
        /// </summary>
        public uint AdvertFlags { get; set; }
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property AdvertisementName
        /// </summary>
        public string AdvertisementName { get; set; }
        /// <summary>
        /// WMI Property AssignedSchedule
        /// </summary>
        public ICollection<object> AssignedSchedule { get; set; }
        /// <summary>
        /// WMI Property AssignedScheduleEnabled
        /// </summary>
        public bool AssignedScheduleEnabled { get; set; }
        /// <summary>
        /// WMI Property AssignedScheduleIsGMT
        /// </summary>
        public bool AssignedScheduleIsGmt { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property DeviceFlags
        /// </summary>
        public uint DeviceFlags { get; set; }
        /// <summary>
        /// WMI Property ExpirationTime
        /// </summary>
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// WMI Property ExpirationTimeEnabled
        /// </summary>
        public bool ExpirationTimeEnabled { get; set; }
        /// <summary>
        /// WMI Property ExpirationTimeIsGMT
        /// </summary>
        public bool ExpirationTimeIsGmt { get; set; }
        /// <summary>
        /// WMI Property HierarchyPath
        /// </summary>
        public string HierarchyPath { get; set; }
        /// <summary>
        /// WMI Property IncludeSubCollection
        /// </summary>
        public bool IncludeSubCollection { get; set; }
        /// <summary>
        /// WMI Property ISVData
        /// </summary>
        public ICollection<byte> IsvData { get; set; }
        /// <summary>
        /// WMI Property ISVDataSize
        /// </summary>
        public uint IsvDataSize { get; set; }
        /// <summary>
        /// WMI Property IsVersionCompatible
        /// </summary>
        public bool IsVersionCompatible { get; set; }
        /// <summary>
        /// WMI Property ISVString
        /// </summary>
        public string IsvString { get; set; }
        /// <summary>
        /// WMI Property MandatoryCountdown
        /// </summary>
        public uint MandatoryCountdown { get; set; }
        /// <summary>
        /// WMI Property OfferType
        /// </summary>
        public uint OfferType { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PresentTime
        /// </summary>
        public DateTime PresentTime { get; set; }
        /// <summary>
        /// WMI Property PresentTimeEnabled
        /// </summary>
        public bool PresentTimeEnabled { get; set; }
        /// <summary>
        /// WMI Property PresentTimeIsGMT
        /// </summary>
        public bool PresentTimeIsGmt { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property RemoteClientFlags
        /// </summary>
        public uint RemoteClientFlags { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property TimeFlags
        /// </summary>
        public uint TimeFlags { get; set; }
    }
}
