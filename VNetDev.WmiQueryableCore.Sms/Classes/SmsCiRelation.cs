using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIRelation
    /// </summary>
    [WmiClass(Name = "SMS_CIRelation")]
    public class SmsCiRelation
    {
        /// <summary>
        /// WMI Property FromCIID
        /// </summary>
        public uint FromCiid { get; set; }
        /// <summary>
        /// WMI Property IsBroken
        /// </summary>
        public bool IsBroken { get; set; }
        /// <summary>
        /// WMI Property IsVersionSpecific
        /// </summary>
        public bool IsVersionSpecific { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property RelationType
        /// </summary>
        public uint RelationType { get; set; }
        /// <summary>
        /// WMI Property ToCIID
        /// </summary>
        public uint ToCiid { get; set; }
    }
}
