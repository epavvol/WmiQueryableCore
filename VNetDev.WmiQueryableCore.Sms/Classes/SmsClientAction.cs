using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientAction
    /// </summary>
    [WmiClass(Name = "SMS_ClientAction")]
    public class SmsClientAction
    {
        /// <summary>
        /// WMI Property DwordValue
        /// </summary>
        public uint DwordValue { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LinkedObjectType
        /// </summary>
        public uint LinkedObjectType { get; set; }
        /// <summary>
        /// WMI Property LinkedObjectUniqueID
        /// </summary>
        public string LinkedObjectUniqueId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property StringValue
        /// </summary>
        public string StringValue { get; set; }
        /// <summary>
        /// WMI Property StringValues
        /// </summary>
        public ICollection<string> StringValues { get; set; }
        /// <summary>
        /// WMI Property TargetObjectID
        /// </summary>
        public string TargetObjectId { get; set; }
        /// <summary>
        /// WMI Property TargetObjectType
        /// </summary>
        public uint TargetObjectType { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
