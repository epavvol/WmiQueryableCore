using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_ADD_REMOVE_PROGRAMS
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_ADD_REMOVE_PROGRAMS")]
    public class SmsGehSystemAddRemovePrograms
    {
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public string InstallDate { get; set; }
        /// <summary>
        /// WMI Property ProdID
        /// </summary>
        public string ProdId { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
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
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
