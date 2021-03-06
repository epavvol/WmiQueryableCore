using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Client_Reg_MultiString_List
    /// </summary>
    [WmiClass(Name = "SMS_Client_Reg_MultiString_List")]
    public class SmsClientRegMultiStringList
    {
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property KeyPath
        /// </summary>
        public string KeyPath { get; set; }
        /// <summary>
        /// WMI Property ValueName
        /// </summary>
        public string ValueName { get; set; }
        /// <summary>
        /// WMI Property ValueStrings
        /// </summary>
        public ICollection<string> ValueStrings { get; set; }
    }
}
