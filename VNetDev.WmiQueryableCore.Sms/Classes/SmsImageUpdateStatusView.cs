using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageUpdateStatusView
    /// </summary>
    [WmiClass(Name = "SMS_ImageUpdateStatusView")]
    public class SmsImageUpdateStatusView
    {
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// WMI Property ImageIndex
        /// </summary>
        public int ImageIndex { get; set; }
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property PackageDescription
        /// </summary>
        public string PackageDescription { get; set; }
        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }
        /// <summary>
        /// WMI Property UpdateID
        /// </summary>
        public int UpdateId { get; set; }
    }
}
