using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CN_ClientStatus
    /// </summary>
    [WmiClass(Name = "SMS_CN_ClientStatus")]
    public class SmsCnClientStatus
    {
        /// <summary>
        /// WMI static method <c>GetOnlineCount</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="targetResourceIDs">WMI Property <c>TargetResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetOnlineCountDelegate(WmiContext wmiContext, string targetCollectionId = default, ICollection<uint> targetResourceIDs = default);
        /// <summary>
        /// WMI static method <c>GetOnlineCount</c>.
        /// </summary>
        public static GetOnlineCountDelegate GetOnlineCount;
        /// <summary>
        /// WMI Property ChannelType
        /// </summary>
        public uint ChannelType { get; set; }
        /// <summary>
        /// WMI Property LastStatusTime
        /// </summary>
        public DateTime LastStatusTime { get; set; }
        /// <summary>
        /// WMI Property OnlineStatus
        /// </summary>
        public uint OnlineStatus { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ServerID
        /// </summary>
        public uint ServerId { get; set; }
    }
}
