using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPStatusDetails
    /// </summary>
    [WmiClass(Name = "SMS_DPStatusDetails")]
    public class SmsDpStatusDetails
    {
        /// <summary>
        /// WMI Property DPName
        /// </summary>
        public string DpName { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// WMI Property InsString1
        /// </summary>
        public string InsString1 { get; set; }
        /// <summary>
        /// WMI Property InsString10
        /// </summary>
        public string InsString10 { get; set; }
        /// <summary>
        /// WMI Property InsString2
        /// </summary>
        public string InsString2 { get; set; }
        /// <summary>
        /// WMI Property InsString3
        /// </summary>
        public string InsString3 { get; set; }
        /// <summary>
        /// WMI Property InsString4
        /// </summary>
        public string InsString4 { get; set; }
        /// <summary>
        /// WMI Property InsString5
        /// </summary>
        public string InsString5 { get; set; }
        /// <summary>
        /// WMI Property InsString6
        /// </summary>
        public string InsString6 { get; set; }
        /// <summary>
        /// WMI Property InsString7
        /// </summary>
        public string InsString7 { get; set; }
        /// <summary>
        /// WMI Property InsString8
        /// </summary>
        public string InsString8 { get; set; }
        /// <summary>
        /// WMI Property InsString9
        /// </summary>
        public string InsString9 { get; set; }
        /// <summary>
        /// WMI Property LastStatusTime
        /// </summary>
        public DateTime LastStatusTime { get; set; }
        /// <summary>
        /// WMI Property MessageCategory
        /// </summary>
        public uint MessageCategory { get; set; }
        /// <summary>
        /// WMI Property MessageFullID
        /// </summary>
        public uint MessageFullId { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property MessageSeverity
        /// </summary>
        public uint MessageSeverity { get; set; }
        /// <summary>
        /// WMI Property MessageState
        /// </summary>
        public uint MessageState { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property StatusMsgID
        /// </summary>
        public long StatusMsgId { get; set; }
    }
}
