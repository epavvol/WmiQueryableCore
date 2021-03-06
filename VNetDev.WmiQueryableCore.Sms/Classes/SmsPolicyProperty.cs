using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PolicyProperty
    /// </summary>
    [WmiClass(Name = "SMS_PolicyProperty")]
    public class SmsPolicyProperty
    {
        /// <summary>
        /// WMI Property DataBlobSegment
        /// </summary>
        public string DataBlobSegment { get; set; }
        /// <summary>
        /// WMI Property PropertyDataType
        /// </summary>
        public int PropertyDataType { get; set; }
        /// <summary>
        /// WMI Property PropertyId
        /// </summary>
        public string PropertyId { get; set; }
        /// <summary>
        /// WMI Property PropertyValue
        /// </summary>
        public string PropertyValue { get; set; }
    }
}
