using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AvailableOperation
    /// </summary>
    [WmiClass(Name = "SMS_AvailableOperation")]
    public class SmsAvailableOperation
    {
        /// <summary>
        /// WMI Property BitFlag
        /// </summary>
        public uint BitFlag { get; set; }
        /// <summary>
        /// WMI Property IsTypeWideOperation
        /// </summary>
        public bool IsTypeWideOperation { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeName
        /// </summary>
        public string ObjectTypeName { get; set; }
        /// <summary>
        /// WMI Property OperationName
        /// </summary>
        public string OperationName { get; set; }
    }
}
