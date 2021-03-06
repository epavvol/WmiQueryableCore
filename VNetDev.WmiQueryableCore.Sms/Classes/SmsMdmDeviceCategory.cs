using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMDeviceCategory
    /// </summary>
    [WmiClass(Name = "SMS_MDMDeviceCategory")]
    public class SmsMdmDeviceCategory
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
