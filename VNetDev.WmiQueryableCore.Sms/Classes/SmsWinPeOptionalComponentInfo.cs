using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WinPEOptionalComponentInfo
    /// </summary>
    [WmiClass(Name = "SMS_WinPEOptionalComponentInfo")]
    public class SmsWinPeOptionalComponentInfo
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
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
        /// WMI Property LanguageID
        /// </summary>
        public uint LanguageId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property RelativePath
        /// </summary>
        public string RelativePath { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public ulong Size { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public uint UniqueId { get; set; }
    }
}
