using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_OSExpressionGroup
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_OSExpressionGroup")]
    public class SmsTaskSequenceOsExpressionGroup
    {
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Operands
        /// </summary>
        public ICollection<object> Operands { get; set; }
        /// <summary>
        /// WMI Property OperatorType
        /// </summary>
        public string OperatorType { get; set; }
        /// <summary>
        /// WMI Property PlatformArchKey
        /// </summary>
        public string PlatformArchKey { get; set; }
        /// <summary>
        /// WMI Property PlatformMaxVerKey
        /// </summary>
        public string PlatformMaxVerKey { get; set; }
        /// <summary>
        /// WMI Property PlatformMinVerKey
        /// </summary>
        public string PlatformMinVerKey { get; set; }
        /// <summary>
        /// WMI Property PlatformTypeKey
        /// </summary>
        public string PlatformTypeKey { get; set; }
    }
}
