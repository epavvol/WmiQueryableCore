using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MeterData
    /// </summary>
    [WmiClass(Name = "SMS_MeterData")]
    public class SmsMeterData
    {
        /// <summary>
        /// WMI Property EndNotCaptured
        /// </summary>
        public bool EndNotCaptured { get; set; }
        /// <summary>
        /// WMI Property EndTime
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// WMI Property EndTimeOffset
        /// </summary>
        public uint EndTimeOffset { get; set; }
        /// <summary>
        /// WMI Property FileID
        /// </summary>
        public long FileId { get; set; }
        /// <summary>
        /// WMI Property InTSSession
        /// </summary>
        public bool InTsSession { get; set; }
        /// <summary>
        /// WMI Property MeterDataID
        /// </summary>
        public string MeterDataId { get; set; }
        /// <summary>
        /// WMI Property MeteredUserID
        /// </summary>
        public uint MeteredUserId { get; set; }
        /// <summary>
        /// WMI Property Released
        /// </summary>
        public bool Released { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Started
        /// </summary>
        public bool Started { get; set; }
        /// <summary>
        /// WMI Property StartNotCaptured
        /// </summary>
        public bool StartNotCaptured { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property StartTimeOffset
        /// </summary>
        public uint StartTimeOffset { get; set; }
        /// <summary>
        /// WMI Property StillRunning
        /// </summary>
        public bool StillRunning { get; set; }
        /// <summary>
        /// WMI Property TimeSerial
        /// </summary>
        public uint TimeSerial { get; set; }
    }
}
