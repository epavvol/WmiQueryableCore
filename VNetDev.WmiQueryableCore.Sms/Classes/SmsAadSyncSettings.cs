using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Sync_Settings
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Sync_Settings")]
    public class SmsAadSyncSettings
    {
        /// <summary>
        /// WMI static method <c>ConfigureCollectionAADGroupSync</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="cloudServiceId">WMI Property <c>CloudServiceID</c> of type <c>uint</c>.</param>
        /// <param name="fullSyncEnabled">WMI Property <c>FullSyncEnabled</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ConfigureCollectionAadGroupSyncDelegate(WmiContext wmiContext, uint cloudServiceId = default, uint fullSyncEnabled = default);
        /// <summary>
        /// WMI static method <c>ConfigureCollectionAADGroupSync</c>.
        /// </summary>
        public static ConfigureCollectionAadGroupSyncDelegate ConfigureCollectionAadGroupSync;
        
        /// <summary>
        /// WMI static method <c>GetAADGroupSyncConfig</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="cloudServiceId">WMI Property <c>CloudServiceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetAadGroupSyncConfigDelegate(WmiContext wmiContext, uint cloudServiceId = default);
        /// <summary>
        /// WMI static method <c>GetAADGroupSyncConfig</c>.
        /// </summary>
        public static GetAadGroupSyncConfigDelegate GetAadGroupSyncConfig;
        /// <summary>
        /// WMI Property CloudServiceId
        /// </summary>
        public uint CloudServiceId { get; set; }
        /// <summary>
        /// WMI Property DeltaSyncEnabled
        /// </summary>
        public uint DeltaSyncEnabled { get; set; }
        /// <summary>
        /// WMI Property DeltaSyncInterval
        /// </summary>
        public uint DeltaSyncInterval { get; set; }
        /// <summary>
        /// WMI Property FullSyncEnabled
        /// </summary>
        public uint FullSyncEnabled { get; set; }
        /// <summary>
        /// WMI Property FullSyncSchedule
        /// </summary>
        public string FullSyncSchedule { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LastDeltaSyncTime
        /// </summary>
        public DateTime LastDeltaSyncTime { get; set; }
        /// <summary>
        /// WMI Property LastFullSyncTime
        /// </summary>
        public DateTime LastFullSyncTime { get; set; }
        /// <summary>
        /// WMI Property RunNow
        /// </summary>
        public uint RunNow { get; set; }
        /// <summary>
        /// WMI Property WaterMark
        /// </summary>
        public ulong WaterMark { get; set; }
    }
}
