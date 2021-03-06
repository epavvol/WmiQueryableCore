using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_ClientConfig
    /// </summary>
    [WmiClass(Name = "SMS_SCI_ClientConfig")]
    public class SmsSciClientConfig
    {
        /// <summary>
        /// WMI Property ClientConfigName
        /// </summary>
        public string ClientConfigName { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property Platforms
        /// </summary>
        public ICollection<string> Platforms { get; set; }
        /// <summary>
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsEmbeddedPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsEmbeddedProperty> Props { get; set; }
        /// <summary>
        /// WMI Property RegMultiStringLists
        /// </summary>
        public  ICollection<SmsClientRegMultiStringList> RegMultiStringLists { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
