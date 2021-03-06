using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WindowsServicingProductCategoryNames
    /// </summary>
    [WmiClass(Name = "SMS_WindowsServicingProductCategoryNames")]
    public class SmsWindowsServicingProductCategoryNames
    {
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
