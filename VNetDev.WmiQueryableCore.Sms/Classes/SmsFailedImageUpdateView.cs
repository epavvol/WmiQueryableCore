using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_FailedImageUpdateView
    /// </summary>
    [WmiClass(Name = "SMS_FailedImageUpdateView")]
    public class SmsFailedImageUpdateView
    {
        /// <summary>
        /// WMI Property FailedImageCount
        /// </summary>
        public int FailedImageCount { get; set; }
        /// <summary>
        /// WMI Property Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// WMI Property UpdateID
        /// </summary>
        public int UpdateId { get; set; }
    }
}
