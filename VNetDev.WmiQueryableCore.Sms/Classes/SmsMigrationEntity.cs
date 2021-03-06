using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationEntity
    /// </summary>
    [WmiClass(Name = "SMS_MigrationEntity")]
    public class SmsMigrationEntity
    {
        /// <summary>
        /// WMI static method <c>GetEntityReferences</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="entityIDs">WMI Property <c>entityIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="referenceDirection">WMI Property <c>referenceDirection</c> of type <c>bool</c>.</param>
        /// <param name="referenceType">WMI Property <c>referenceType</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetEntityReferencesDelegate(WmiContext wmiContext, ICollection<uint> entityIDs = default, bool referenceDirection = default, uint referenceType = default);
        /// <summary>
        /// WMI static method <c>GetEntityReferences</c>.
        /// </summary>
        public static GetEntityReferencesDelegate GetEntityReferences;
        
        /// <summary>
        /// WMI static method <c>ExcludeAndInclude</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="excludeEntityList">WMI Property <c>excludeEntityList</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="includeEntityList">WMI Property <c>includeEntityList</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ExcludeAndIncludeDelegate(WmiContext wmiContext, ICollection<uint> excludeEntityList = default, ICollection<uint> includeEntityList = default);
        /// <summary>
        /// WMI static method <c>ExcludeAndInclude</c>.
        /// </summary>
        public static ExcludeAndIncludeDelegate ExcludeAndInclude;
        /// <summary>
        /// WMI Property ChangedAffinity
        /// </summary>
        public bool ChangedAffinity { get; set; }
        /// <summary>
        /// WMI Property DashboardState
        /// </summary>
        public uint DashboardState { get; set; }
        /// <summary>
        /// WMI Property EntityID
        /// </summary>
        public uint EntityId { get; set; }
        /// <summary>
        /// WMI Property EntityKey
        /// </summary>
        public string EntityKey { get; set; }
        /// <summary>
        /// WMI Property EntityName
        /// </summary>
        public string EntityName { get; set; }
        /// <summary>
        /// WMI Property ExcludedBy
        /// </summary>
        public string ExcludedBy { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property JobIDs
        /// </summary>
        public ICollection<uint> JobIDs { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property ReferencedEntities
        /// </summary>
        public ICollection<uint> ReferencedEntities { get; set; }
        /// <summary>
        /// WMI Property ReferencingEntities
        /// </summary>
        public ICollection<uint> ReferencingEntities { get; set; }
        /// <summary>
        /// WMI Property SourceSiteID
        /// </summary>
        public uint SourceSiteId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
