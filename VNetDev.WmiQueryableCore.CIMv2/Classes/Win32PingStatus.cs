using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PingStatus
    /// </summary>
    [WmiClass(Name = "Win32_PingStatus")]
    public class Win32PingStatus
    {
        /// <summary>
        /// WMI Property Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// WMI Property BufferSize
        /// </summary>
        public uint BufferSize { get; set; }

        /// <summary>
        /// WMI Property NoFragmentation
        /// </summary>
        public bool NoFragmentation { get; set; }

        /// <summary>
        /// WMI Property PrimaryAddressResolutionStatus
        /// </summary>
        public uint PrimaryAddressResolutionStatus { get; set; }

        /// <summary>
        /// WMI Property ProtocolAddress
        /// </summary>
        public string ProtocolAddress { get; set; }

        /// <summary>
        /// WMI Property ProtocolAddressResolved
        /// </summary>
        public string ProtocolAddressResolved { get; set; }

        /// <summary>
        /// WMI Property RecordRoute
        /// </summary>
        public uint RecordRoute { get; set; }

        /// <summary>
        /// WMI Property ReplyInconsistency
        /// </summary>
        public bool ReplyInconsistency { get; set; }

        /// <summary>
        /// WMI Property ReplySize
        /// </summary>
        public uint ReplySize { get; set; }

        /// <summary>
        /// WMI Property ResolveAddressNames
        /// </summary>
        public bool ResolveAddressNames { get; set; }

        /// <summary>
        /// WMI Property ResponseTime
        /// </summary>
        public uint ResponseTime { get; set; }

        /// <summary>
        /// WMI Property ResponseTimeToLive
        /// </summary>
        public uint ResponseTimeToLive { get; set; }

        /// <summary>
        /// WMI Property RouteRecord
        /// </summary>
        public ICollection<string> RouteRecord { get; set; }

        /// <summary>
        /// WMI Property RouteRecordResolved
        /// </summary>
        public ICollection<string> RouteRecordResolved { get; set; }

        /// <summary>
        /// WMI Property SourceRoute
        /// </summary>
        public string SourceRoute { get; set; }

        /// <summary>
        /// WMI Property SourceRouteType
        /// </summary>
        public uint SourceRouteType { get; set; }

        /// <summary>
        /// WMI Property StatusCode
        /// </summary>
        public uint StatusCode { get; set; }

        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }

        /// <summary>
        /// WMI Property TimeStampRecord
        /// </summary>
        public ICollection<uint> TimeStampRecord { get; set; }

        /// <summary>
        /// WMI Property TimeStampRecordAddress
        /// </summary>
        public ICollection<string> TimeStampRecordAddress { get; set; }

        /// <summary>
        /// WMI Property TimeStampRecordAddressResolved
        /// </summary>
        public ICollection<string> TimeStampRecordAddressResolved { get; set; }

        /// <summary>
        /// WMI Property TimestampRoute
        /// </summary>
        public uint TimestampRoute { get; set; }

        /// <summary>
        /// WMI Property TimeToLive
        /// </summary>
        public uint TimeToLive { get; set; }

        /// <summary>
        /// WMI Property TypeofService
        /// </summary>
        public uint TypeofService { get; set; }
    }
}