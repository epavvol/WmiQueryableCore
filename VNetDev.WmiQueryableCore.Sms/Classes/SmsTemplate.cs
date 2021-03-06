using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Template
    /// </summary>
    [WmiClass(Name = "SMS_Template")]
    public class SmsTemplate
    {
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property LastModifiedDate
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SchemaGUID
        /// </summary>
        public string SchemaGuid { get; set; }
        /// <summary>
        /// WMI Property TemplateUniqueID
        /// </summary>
        public string TemplateUniqueId { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
