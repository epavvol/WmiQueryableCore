using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectOperationDependences
    /// </summary>
    [WmiClass(Name = "SMS_ObjectOperationDependences")]
    public class SmsObjectOperationDependences
    {
        /// <summary>
        /// WMI Property DependedObjectTypeID
        /// </summary>
        public uint DependedObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property DependedOperationBitFlag
        /// </summary>
        public uint DependedOperationBitFlag { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property OperationBitFlag
        /// </summary>
        public uint OperationBitFlag { get; set; }
    }
}
