using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientActionStringValues
    /// </summary>
    [WmiClass(Name = "SMS_ClientActionStringValues")]
    public class SmsClientActionStringValues
    {
        /// <summary>
        /// WMI Property ActionID
        /// </summary>
        public uint ActionId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property OperationID
        /// </summary>
        public uint OperationId { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
