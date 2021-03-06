using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPStatusInfo
    /// </summary>
    [WmiClass(Name = "SMS_DPStatusInfo")]
    public class SmsDpStatusInfo
    {
        /// <summary>
        /// WMI Property IsDPMonEnabled
        /// </summary>
        public bool IsDpMonEnabled { get; set; }
        /// <summary>
        /// WMI Property IsMulticast
        /// </summary>
        public bool IsMulticast { get; set; }
        /// <summary>
        /// WMI Property IsPullDP
        /// </summary>
        public bool IsPullDp { get; set; }
        /// <summary>
        /// WMI Property IsPXE
        /// </summary>
        public bool IsPxe { get; set; }
        /// <summary>
        /// WMI Property LastStatusTime
        /// </summary>
        public DateTime LastStatusTime { get; set; }
        /// <summary>
        /// WMI Property MessageCount
        /// </summary>
        public uint MessageCount { get; set; }
        /// <summary>
        /// WMI Property MessageState
        /// </summary>
        public uint MessageState { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public uint NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public uint NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberInstalled
        /// </summary>
        public uint NumberInstalled { get; set; }
        /// <summary>
        /// WMI Property NumberUnknown
        /// </summary>
        public uint NumberUnknown { get; set; }
        /// <summary>
        /// WMI Property SccmPXE
        /// </summary>
        public bool SccmPxe { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
