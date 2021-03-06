using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_CLIENTOPTOUT_SETTINGS")]
    public class SmsGSystemPowerManagementClientoptoutSettings
    {
        /// <summary>
        /// WMI Property AdminAllowOptout
        /// </summary>
        public uint AdminAllowOptout { get; set; }
        /// <summary>
        /// WMI Property EffectiveClientOptOut
        /// </summary>
        public uint EffectiveClientOptOut { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsClientOptOut
        /// </summary>
        public uint IsClientOptOut { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
