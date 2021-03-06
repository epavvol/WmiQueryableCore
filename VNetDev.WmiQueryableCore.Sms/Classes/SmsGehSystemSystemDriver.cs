using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SYSTEM_DRIVER
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SYSTEM_DRIVER")]
    public class SmsGehSystemSystemDriver
    {
        /// <summary>
        /// WMI Property AcceptPause
        /// </summary>
        public uint AcceptPause { get; set; }
        /// <summary>
        /// WMI Property AcceptStop
        /// </summary>
        public uint AcceptStop { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DesktopInteract
        /// </summary>
        public uint DesktopInteract { get; set; }
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property ErrorControl
        /// </summary>
        public string ErrorControl { get; set; }
        /// <summary>
        /// WMI Property ExitCode
        /// </summary>
        public uint ExitCode { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PathName
        /// </summary>
        public string PathName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property ServiceSpecificExitCode
        /// </summary>
        public uint ServiceSpecificExitCode { get; set; }
        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public string ServiceType { get; set; }
        /// <summary>
        /// WMI Property Started
        /// </summary>
        public uint Started { get; set; }
        /// <summary>
        /// WMI Property StartMode
        /// </summary>
        public string StartMode { get; set; }
        /// <summary>
        /// WMI Property StartName
        /// </summary>
        public string StartName { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TagId
        /// </summary>
        public uint TagId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
