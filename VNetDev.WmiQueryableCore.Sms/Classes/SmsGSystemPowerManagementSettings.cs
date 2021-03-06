using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_SETTINGS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_SETTINGS")]
    public class SmsGSystemPowerManagementSettings
    {
        /// <summary>
        /// WMI Property ACSettingIndex
        /// </summary>
        public string AcSettingIndex { get; set; }
        /// <summary>
        /// WMI Property ACValue
        /// </summary>
        public string AcValue { get; set; }
        /// <summary>
        /// WMI Property DCSettingIndex
        /// </summary>
        public string DcSettingIndex { get; set; }
        /// <summary>
        /// WMI Property DCValue
        /// </summary>
        public string DcValue { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
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
        /// <summary>
        /// WMI Property UnitSpecifier
        /// </summary>
        public string UnitSpecifier { get; set; }
    }
}
