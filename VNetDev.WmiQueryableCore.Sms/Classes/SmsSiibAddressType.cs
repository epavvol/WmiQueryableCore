using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SIIB_AddressType
    /// </summary>
    [WmiClass(Name = "SMS_SIIB_AddressType")]
    public class SmsSiibAddressType
    {
        /// <summary>
        /// WMI Property AddressType
        /// </summary>
        public string AddressType { get; set; }
        /// <summary>
        /// WMI Property ChmFile
        /// </summary>
        public string ChmFile { get; set; }
        /// <summary>
        /// WMI Property DescriptionID
        /// </summary>
        public uint DescriptionId { get; set; }
        /// <summary>
        /// WMI Property DispIconID
        /// </summary>
        public uint DispIconId { get; set; }
        /// <summary>
        /// WMI Property DispNameID
        /// </summary>
        public uint DispNameId { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// WMI Property HtmFile
        /// </summary>
        public string HtmFile { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property ResDLL
        /// </summary>
        public string ResDll { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Units
        /// </summary>
        public ICollection<string> Units { get; set; }
    }
}
