using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence")]
    public class SmsTaskSequence
    {
        /// <summary>
        /// WMI static method <c>LoadFromXml</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="xml">WMI Property <c>Xml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>object</c>.</returns>
        /// </summary>
        public delegate object LoadFromXmlDelegate(WmiContext wmiContext, string xml = default);
        /// <summary>
        /// WMI static method <c>LoadFromXml</c>.
        /// </summary>
        public static LoadFromXmlDelegate LoadFromXml;
        
        /// <summary>
        /// WMI static method <c>SaveToXml</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskSequence">WMI Property <c>TaskSequence</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>string</c>.</returns>
        /// </summary>
        public delegate string SaveToXmlDelegate(WmiContext wmiContext,  SmsTaskSequence taskSequence = default);
        /// <summary>
        /// WMI static method <c>SaveToXml</c>.
        /// </summary>
        public static SaveToXmlDelegate SaveToXml;
        
        /// <summary>
        /// WMI static method <c>ExportXml</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="xml">WMI Property <c>Xml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>string</c>.</returns>
        /// </summary>
        public delegate string ExportXmlDelegate(WmiContext wmiContext, string xml = default);
        /// <summary>
        /// WMI static method <c>ExportXml</c>.
        /// </summary>
        public static ExportXmlDelegate ExportXml;
        
        /// <summary>
        /// WMI static method <c>UpdateNestedSequenceReferences</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nestedSequenceAppRefs">WMI Property <c>NestedSequenceAppRefs</c> of type <c>string</c>.</param>
        /// <param name="nestedSequencePkgId">WMI Property <c>NestedSequencePkgId</c> of type <c>string</c>.</param>
        /// <param name="nestedSequencePkgRefs">WMI Property <c>NestedSequencePkgRefs</c> of type <c>string</c>.</param>
        /// <param name="xml">WMI Property <c>Xml</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>string</c>.</returns>
        /// </summary>
        public delegate string UpdateNestedSequenceReferencesDelegate(WmiContext wmiContext, string nestedSequenceAppRefs = default, string nestedSequencePkgId = default, string nestedSequencePkgRefs = default, string xml = default);
        /// <summary>
        /// WMI static method <c>UpdateNestedSequenceReferences</c>.
        /// </summary>
        public static UpdateNestedSequenceReferencesDelegate UpdateNestedSequenceReferences;
        /// <summary>
        /// WMI Property SchemaVersion
        /// </summary>
        public string SchemaVersion { get; set; }
        /// <summary>
        /// WMI Property Steps
        /// </summary>
        public ICollection<object> Steps { get; set; }
    }
}
