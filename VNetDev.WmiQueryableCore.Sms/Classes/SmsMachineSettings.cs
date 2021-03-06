using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MachineSettings
    /// </summary>
    [WmiClass(Name = "SMS_MachineSettings")]
    public class SmsMachineSettings
    {
        /// <summary>
        /// WMI Property LastModificationTime
        /// </summary>
        public DateTime LastModificationTime { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property MachineVariables
        /// </summary>
        public ICollection<SmsMachineVariable> MachineVariables { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
