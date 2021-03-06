using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImportedObject
    /// </summary>
    [WmiClass(Name = "SMS_ImportedObject")]
    public class SmsImportedObject
    {
        /// <summary>
        /// WMI static method <c>GetImportedObjects</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectType">WMI Property <c>ObjectType</c> of type <c>string</c>.</param>
        /// <param name="originalKey">WMI Property <c>OriginalKey</c> of type <c>string</c>.</param>
        /// <param name="originalSite">WMI Property <c>OriginalSite</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetImportedObjectsDelegate(WmiContext wmiContext, string objectType = default, string originalKey = default, string originalSite = default);
        /// <summary>
        /// WMI static method <c>GetImportedObjects</c>.
        /// </summary>
        public static GetImportedObjectsDelegate GetImportedObjects;
        
        /// <summary>
        /// WMI static method <c>AddImportedObject</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="dateExported">WMI Property <c>DateExported</c> of type <c>DateTime</c>.</param>
        /// <param name="objectPath">WMI Property <c>ObjectPath</c> of type <c>object</c>.</param>
        /// <param name="originalKey">WMI Property <c>OriginalKey</c> of type <c>string</c>.</param>
        /// <param name="originalSite">WMI Property <c>OriginalSite</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddImportedObjectDelegate(WmiContext wmiContext, DateTime dateExported = default, object objectPath = default, string originalKey = default, string originalSite = default);
        /// <summary>
        /// WMI static method <c>AddImportedObject</c>.
        /// </summary>
        public static AddImportedObjectDelegate AddImportedObject;
        
        /// <summary>
        /// WMI static method <c>GetClientUpgradeSettings</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetClientUpgradeSettingsDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetClientUpgradeSettings</c>.
        /// </summary>
        public static GetClientUpgradeSettingsDelegate GetClientUpgradeSettings;
        /// <summary>
        /// WMI Property ContentHash
        /// </summary>
        public string ContentHash { get; set; }
        /// <summary>
        /// WMI Property ContentHashAlgorithm
        /// </summary>
        public string ContentHashAlgorithm { get; set; }
        /// <summary>
        /// WMI Property DataHash
        /// </summary>
        public string DataHash { get; set; }
        /// <summary>
        /// WMI Property DataHashAlgorithm
        /// </summary>
        public string DataHashAlgorithm { get; set; }
        /// <summary>
        /// WMI Property DateExported
        /// </summary>
        public DateTime DateExported { get; set; }
        /// <summary>
        /// WMI Property DateImported
        /// </summary>
        public DateTime DateImported { get; set; }
        /// <summary>
        /// WMI Property ImportID
        /// </summary>
        public uint ImportId { get; set; }
        /// <summary>
        /// WMI Property IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// WMI Property ObjectKey
        /// </summary>
        public string ObjectKey { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property OriginalKey
        /// </summary>
        public string OriginalKey { get; set; }
        /// <summary>
        /// WMI Property OriginalSite
        /// </summary>
        public string OriginalSite { get; set; }
    }
}
