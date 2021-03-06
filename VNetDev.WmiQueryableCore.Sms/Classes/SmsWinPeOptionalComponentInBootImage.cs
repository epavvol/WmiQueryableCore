using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WinPEOptionalComponentInBootImage
    /// </summary>
    [WmiClass(Name = "SMS_WinPEOptionalComponentInBootImage")]
    public class SmsWinPeOptionalComponentInBootImage
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property ComponentID
        /// </summary>
        public uint ComponentId { get; set; }
        /// <summary>
        /// WMI Property DependentComponentNames
        /// </summary>
        public ICollection<string> DependentComponentNames { get; set; }
        /// <summary>
        /// WMI Property DependentIds
        /// </summary>
        public ICollection<uint> DependentIds { get; set; }
        /// <summary>
        /// WMI Property IsRequired
        /// </summary>
        public bool IsRequired { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public ulong Size { get; set; }
    }
}
