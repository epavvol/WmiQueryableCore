using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectContainerItem
    /// </summary>
    [WmiClass(Name = "SMS_ObjectContainerItem")]
    public class SmsObjectContainerItem
    {
        /// <summary>
        /// WMI static method <c>MoveMembers</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="containerNodeId">WMI Property <c>ContainerNodeID</c> of type <c>uint</c>.</param>
        /// <param name="instanceKeys">WMI Property <c>InstanceKeys</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectType">WMI Property <c>ObjectType</c> of type <c>uint</c>.</param>
        /// <param name="targetContainerNodeId">WMI Property <c>TargetContainerNodeID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint MoveMembersDelegate(WmiContext wmiContext, uint containerNodeId = default, ICollection<string> instanceKeys = default, uint objectType = default, uint targetContainerNodeId = default);
        /// <summary>
        /// WMI static method <c>MoveMembers</c>.
        /// </summary>
        public static MoveMembersDelegate MoveMembers;
        
        /// <summary>
        /// WMI static method <c>MoveMembersEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="containerNodeId">WMI Property <c>ContainerNodeID</c> of type <c>uint</c>.</param>
        /// <param name="instanceKeys">WMI Property <c>InstanceKeys</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="objectTypeName">WMI Property <c>ObjectTypeName</c> of type <c>string</c>.</param>
        /// <param name="targetContainerNodeId">WMI Property <c>TargetContainerNodeID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint MoveMembersExDelegate(WmiContext wmiContext, uint containerNodeId = default, ICollection<string> instanceKeys = default, string objectTypeName = default, uint targetContainerNodeId = default);
        /// <summary>
        /// WMI static method <c>MoveMembersEx</c>.
        /// </summary>
        public static MoveMembersExDelegate MoveMembersEx;
        /// <summary>
        /// WMI Property ContainerNodeID
        /// </summary>
        public uint ContainerNodeId { get; set; }
        /// <summary>
        /// WMI Property InstanceKey
        /// </summary>
        public string InstanceKey { get; set; }
        /// <summary>
        /// WMI Property MemberGuid
        /// </summary>
        public string MemberGuid { get; set; }
        /// <summary>
        /// WMI Property MemberID
        /// </summary>
        public uint MemberId { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeName
        /// </summary>
        public string ObjectTypeName { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
