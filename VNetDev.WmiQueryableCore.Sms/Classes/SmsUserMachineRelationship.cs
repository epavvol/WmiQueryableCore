using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UserMachineRelationship
    /// </summary>
    [WmiClass(Name = "SMS_UserMachineRelationship")]
    public class SmsUserMachineRelationship
    {
        /// <summary>
        /// WMI method <c>AddSource</c> describing delegate.
        /// <param name="sourceId">WMI Property <c>SourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddSourceDelegate(uint sourceId = default);
        /// <summary>
        /// WMI method <c>AddSource</c>.
        /// </summary>
        public AddSourceDelegate AddSource;
        
        /// <summary>
        /// WMI method <c>RemoveSource</c> describing delegate.
        /// <param name="sourceId">WMI Property <c>SourceId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveSourceDelegate(uint sourceId = default);
        /// <summary>
        /// WMI method <c>RemoveSource</c>.
        /// </summary>
        public RemoveSourceDelegate RemoveSource;
        
        /// <summary>
        /// WMI method <c>AddType</c> describing delegate.
        /// <param name="typeId">WMI Property <c>TypeId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddTypeDelegate(uint typeId = default);
        /// <summary>
        /// WMI method <c>AddType</c>.
        /// </summary>
        public AddTypeDelegate AddType;
        
        /// <summary>
        /// WMI method <c>RemoveType</c> describing delegate.
        /// <param name="typeId">WMI Property <c>TypeId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveTypeDelegate(uint typeId = default);
        /// <summary>
        /// WMI method <c>RemoveType</c>.
        /// </summary>
        public RemoveTypeDelegate RemoveType;
        
        /// <summary>
        /// WMI static method <c>CreateRelationship</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="machineResourceId">WMI Property <c>MachineResourceId</c> of type <c>uint</c>.</param>
        /// <param name="sourceId">WMI Property <c>SourceId</c> of type <c>uint</c>.</param>
        /// <param name="typeId">WMI Property <c>TypeId</c> of type <c>uint</c>.</param>
        /// <param name="userAccountName">WMI Property <c>UserAccountName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateRelationshipDelegate(WmiContext wmiContext, uint machineResourceId = default, uint sourceId = default, uint typeId = default, string userAccountName = default);
        /// <summary>
        /// WMI static method <c>CreateRelationship</c>.
        /// </summary>
        public static CreateRelationshipDelegate CreateRelationship;
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property RelationshipResourceID
        /// </summary>
        public uint RelationshipResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceClientType
        /// </summary>
        public uint ResourceClientType { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceName
        /// </summary>
        public string ResourceName { get; set; }
        /// <summary>
        /// WMI Property Sources
        /// </summary>
        public ICollection<uint> Sources { get; set; }
        /// <summary>
        /// WMI Property Types
        /// </summary>
        public ICollection<uint> Types { get; set; }
        /// <summary>
        /// WMI Property UniqueUserName
        /// </summary>
        public string UniqueUserName { get; set; }
    }
}
