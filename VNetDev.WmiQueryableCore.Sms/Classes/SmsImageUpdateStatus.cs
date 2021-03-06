using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageUpdateStatus
    /// </summary>
    [WmiClass(Name = "SMS_ImageUpdateStatus")]
    public class SmsImageUpdateStatus
    {
        /// <summary>
        /// WMI Property AppliedDateTime
        /// </summary>
        public DateTime AppliedDateTime { get; set; }
        /// <summary>
        /// WMI Property ImageIndex
        /// </summary>
        public int ImageIndex { get; set; }
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property UpdateID
        /// </summary>
        public int UpdateId { get; set; }
        /// <summary>
        /// WMI Property UpdateInstallationStatus
        /// </summary>
        public int UpdateInstallationStatus { get; set; }
        /// <summary>
        /// WMI Property UpdateStatus
        /// </summary>
        public int UpdateStatus { get; set; }
        /// <summary>
        /// WMI Property UpdateTitle
        /// </summary>
        public string UpdateTitle { get; set; }
    }
}
