using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ARoleOperation
    /// </summary>
    [WmiClass(Name = "SMS_ARoleOperation")]
    public class SmsARoleOperation
    {
        /// <summary>
        /// WMI Property GrantedOperations
        /// </summary>
        public uint GrantedOperations { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
    }
}
