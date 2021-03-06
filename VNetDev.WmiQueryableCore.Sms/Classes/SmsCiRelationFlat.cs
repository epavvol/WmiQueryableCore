using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIRelation_Flat
    /// </summary>
    [WmiClass(Name = "SMS_CIRelation_Flat")]
    public class SmsCiRelationFlat
    {
        /// <summary>
        /// WMI Property FromCIID
        /// </summary>
        public uint FromCiid { get; set; }
        /// <summary>
        /// WMI Property IsVersionSpecific
        /// </summary>
        public bool IsVersionSpecific { get; set; }
        /// <summary>
        /// WMI Property Level
        /// </summary>
        public uint Level { get; set; }
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
