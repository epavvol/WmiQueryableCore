using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SettableSecuredCategory
    /// </summary>
    [WmiClass(Name = "SMS_SettableSecuredCategory")]
    public class SmsSettableSecuredCategory
    {
        /// <summary>
        /// WMI Property CategoryDescription
        /// </summary>
        public string CategoryDescription { get; set; }
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// WMI Property CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// WMI Property IsBuiltIn
        /// </summary>
        public bool IsBuiltIn { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastModifiedDate
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property NumberOfAdmins
        /// </summary>
        public uint NumberOfAdmins { get; set; }
        /// <summary>
        /// WMI Property NumberOfObjects
        /// </summary>
        public uint NumberOfObjects { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
