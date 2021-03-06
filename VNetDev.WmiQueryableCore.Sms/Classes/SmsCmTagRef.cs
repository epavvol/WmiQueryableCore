using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CMTagRef
    /// </summary>
    [WmiClass(Name = "SMS_CMTagRef")]
    public class SmsCmTagRef
    {
        /// <summary>
        /// WMI Property CMTagID
        /// </summary>
        public uint CmTagId { get; set; }
        /// <summary>
        /// WMI Property CMTagName
        /// </summary>
        public string CmTagName { get; set; }
    }
}
