using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectContainerNode
    /// </summary>
    [WmiClass(Name = "SMS_ObjectContainerNode")]
    public class SmsObjectContainerNode
    {
        /// <summary>
        /// WMI static method <c>MoveFolders</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="containerNodeIDs">WMI Property <c>ContainerNodeIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="targetContainerNodeId">WMI Property <c>TargetContainerNodeID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint MoveFoldersDelegate(WmiContext wmiContext, ICollection<uint> containerNodeIDs = default, uint targetContainerNodeId = default);
        /// <summary>
        /// WMI static method <c>MoveFolders</c>.
        /// </summary>
        public static MoveFoldersDelegate MoveFolders;
        /// <summary>
        /// WMI Property ContainerNodeID
        /// </summary>
        public uint ContainerNodeId { get; set; }
        /// <summary>
        /// WMI Property FolderFlags
        /// </summary>
        public uint FolderFlags { get; set; }
        /// <summary>
        /// WMI Property FolderGuid
        /// </summary>
        public string FolderGuid { get; set; }
        /// <summary>
        /// WMI Property IsEmpty
        /// </summary>
        public bool IsEmpty { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeName
        /// </summary>
        public string ObjectTypeName { get; set; }
        /// <summary>
        /// WMI Property ParentContainerNodeID
        /// </summary>
        public uint ParentContainerNodeId { get; set; }
        /// <summary>
        /// WMI Property SearchFolder
        /// </summary>
        public bool SearchFolder { get; set; }
        /// <summary>
        /// WMI Property SearchString
        /// </summary>
        public string SearchString { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
