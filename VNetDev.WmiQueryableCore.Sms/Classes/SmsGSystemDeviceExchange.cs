using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_EXCHANGE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_EXCHANGE")]
    public class SmsGSystemDeviceExchange
    {
        /// <summary>
        /// WMI Property ConflictResolution
        /// </summary>
        public uint ConflictResolution { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HTMLEmailTruncation
        /// </summary>
        public uint HtmlEmailTruncation { get; set; }
        /// <summary>
        /// WMI Property MailFormat
        /// </summary>
        public uint MailFormat { get; set; }
        /// <summary>
        /// WMI Property MaxCalendarAge
        /// </summary>
        public uint MaxCalendarAge { get; set; }
        /// <summary>
        /// WMI Property MaxEmailAge
        /// </summary>
        public uint MaxEmailAge { get; set; }
        /// <summary>
        /// WMI Property MaxMailFileAttachmentSize
        /// </summary>
        public uint MaxMailFileAttachmentSize { get; set; }
        /// <summary>
        /// WMI Property OffPeakSyncFrequency
        /// </summary>
        public uint OffPeakSyncFrequency { get; set; }
        /// <summary>
        /// WMI Property PeakDays
        /// </summary>
        public uint PeakDays { get; set; }
        /// <summary>
        /// WMI Property PeakEndTime
        /// </summary>
        public string PeakEndTime { get; set; }
        /// <summary>
        /// WMI Property PeakStartTime
        /// </summary>
        public string PeakStartTime { get; set; }
        /// <summary>
        /// WMI Property PeakSyncFrequency
        /// </summary>
        public uint PeakSyncFrequency { get; set; }
        /// <summary>
        /// WMI Property PlainTextEmailTruncation
        /// </summary>
        public uint PlainTextEmailTruncation { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SendEmailImmediately
        /// </summary>
        public uint SendEmailImmediately { get; set; }
        /// <summary>
        /// WMI Property SyncCalendar
        /// </summary>
        public uint SyncCalendar { get; set; }
        /// <summary>
        /// WMI Property SyncContacts
        /// </summary>
        public uint SyncContacts { get; set; }
        /// <summary>
        /// WMI Property SyncEmail
        /// </summary>
        public uint SyncEmail { get; set; }
        /// <summary>
        /// WMI Property SyncTasks
        /// </summary>
        public uint SyncTasks { get; set; }
        /// <summary>
        /// WMI Property SyncWhenRoaming
        /// </summary>
        public uint SyncWhenRoaming { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
