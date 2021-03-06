using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Content
    /// </summary>
    [WmiClass(Name = "SMS_Content")]
    public class SmsContent
    {
        /// <summary>
        /// WMI static method <c>IsOfficeContent</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="contentId">WMI Property <c>ContentId</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool IsOfficeContentDelegate(WmiContext wmiContext, uint contentId = default);
        /// <summary>
        /// WMI static method <c>IsOfficeContent</c>.
        /// </summary>
        public static IsOfficeContentDelegate IsOfficeContent;
        /// <summary>
        /// WMI Property ContentDescription
        /// </summary>
        public string ContentDescription { get; set; }
        /// <summary>
        /// WMI Property ContentFlags
        /// </summary>
        public uint ContentFlags { get; set; }
        /// <summary>
        /// WMI Property ContentHash
        /// </summary>
        public string ContentHash { get; set; }
        /// <summary>
        /// WMI Property ContentHashVersion
        /// </summary>
        public uint ContentHashVersion { get; set; }
        /// <summary>
        /// WMI Property ContentID
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// WMI Property ContentSource
        /// </summary>
        public string ContentSource { get; set; }
        /// <summary>
        /// WMI Property ContentType
        /// </summary>
        public uint ContentType { get; set; }
        /// <summary>
        /// WMI Property ContentUniqueID
        /// </summary>
        public string ContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContentVersion
        /// </summary>
        public uint ContentVersion { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property RelatedContentID
        /// </summary>
        public string RelatedContentId { get; set; }
        /// <summary>
        /// WMI Property SecurityKey
        /// </summary>
        public string SecurityKey { get; set; }
    }
}
