using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AISoftwareList
    /// </summary>
    [WmiClass(Name = "SMS_AISoftwareList")]
    public class SmsAiSoftwareList
    {
        /// <summary>
        /// WMI static method <c>ResolveConflict</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resolution">WMI Property <c>Resolution</c> of type <c>uint</c>.</param>
        /// <param name="softwareKey">WMI Property <c>SoftwareKey</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ResolveConflictDelegate(WmiContext wmiContext, uint resolution = default, string softwareKey = default);
        /// <summary>
        /// WMI static method <c>ResolveConflict</c>.
        /// </summary>
        public static ResolveConflictDelegate ResolveConflict;
        
        /// <summary>
        /// WMI static method <c>SetCategorizationRequest</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="softwareKey">WMI Property <c>SoftwareKey</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetCategorizationRequestDelegate(WmiContext wmiContext, string softwareKey = default);
        /// <summary>
        /// WMI static method <c>SetCategorizationRequest</c>.
        /// </summary>
        public static SetCategorizationRequestDelegate SetCategorizationRequest;
        
        /// <summary>
        /// WMI static method <c>GetCategorizationRequestText</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="softwareKey">WMI Property <c>SoftwareKey</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetCategorizationRequestTextDelegate(WmiContext wmiContext, string softwareKey = default);
        /// <summary>
        /// WMI static method <c>GetCategorizationRequestText</c>.
        /// </summary>
        public static GetCategorizationRequestTextDelegate GetCategorizationRequestText;
        
        /// <summary>
        /// WMI static method <c>GetSummary</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetSummaryDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetSummary</c>.
        /// </summary>
        public static GetSummaryDelegate GetSummary;
        
        /// <summary>
        /// WMI static method <c>AddSoftwareHashData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddSoftwareHashDataDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>AddSoftwareHashData</c>.
        /// </summary>
        public static AddSoftwareHashDataDelegate AddSoftwareHashData;
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public uint CategoryId { get; set; }
        /// <summary>
        /// WMI Property CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// WMI Property CommonName
        /// </summary>
        public string CommonName { get; set; }
        /// <summary>
        /// WMI Property CommonPublisher
        /// </summary>
        public string CommonPublisher { get; set; }
        /// <summary>
        /// WMI Property CommonVersion
        /// </summary>
        public string CommonVersion { get; set; }
        /// <summary>
        /// WMI Property FamilyID
        /// </summary>
        public uint FamilyId { get; set; }
        /// <summary>
        /// WMI Property FamilyName
        /// </summary>
        public string FamilyName { get; set; }
        /// <summary>
        /// WMI Property OfficialCategoryName
        /// </summary>
        public string OfficialCategoryName { get; set; }
        /// <summary>
        /// WMI Property OfficialFamilyName
        /// </summary>
        public string OfficialFamilyName { get; set; }
        /// <summary>
        /// WMI Property ParentCommonName
        /// </summary>
        public string ParentCommonName { get; set; }
        /// <summary>
        /// WMI Property ParentSoftwareID
        /// </summary>
        public string ParentSoftwareId { get; set; }
        /// <summary>
        /// WMI Property SoftwareCount
        /// </summary>
        public uint SoftwareCount { get; set; }
        /// <summary>
        /// WMI Property SoftwareKey
        /// </summary>
        public string SoftwareKey { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property Tag1ID
        /// </summary>
        public uint Tag1id { get; set; }
        /// <summary>
        /// WMI Property Tag1Name
        /// </summary>
        public string Tag1Name { get; set; }
        /// <summary>
        /// WMI Property Tag2ID
        /// </summary>
        public uint Tag2id { get; set; }
        /// <summary>
        /// WMI Property Tag2Name
        /// </summary>
        public string Tag2Name { get; set; }
        /// <summary>
        /// WMI Property Tag3ID
        /// </summary>
        public uint Tag3id { get; set; }
        /// <summary>
        /// WMI Property Tag3Name
        /// </summary>
        public string Tag3Name { get; set; }
    }
}
