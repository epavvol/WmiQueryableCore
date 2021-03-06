using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Scripts
    /// </summary>
    [WmiClass(Name = "SMS_Scripts")]
    public class SmsScripts
    {
        /// <summary>
        /// WMI method <c>UpdateApprovalState</c> describing delegate.
        /// <param name="approvalState">WMI Property <c>ApprovalState</c> of type <c>string</c>.</param>
        /// <param name="approver">WMI Property <c>Approver</c> of type <c>string</c>.</param>
        /// <param name="comment">WMI Property <c>Comment</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateApprovalStateDelegate(string approvalState = default, string approver = default, string comment = default);
        /// <summary>
        /// WMI method <c>UpdateApprovalState</c>.
        /// </summary>
        public UpdateApprovalStateDelegate UpdateApprovalState;
        
        /// <summary>
        /// WMI method <c>UpdateScriptsParameters</c> describing delegate.
        /// <param name="parameterlistXml">WMI Property <c>ParameterlistXML</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateScriptsParametersDelegate(string parameterlistXml = default);
        /// <summary>
        /// WMI method <c>UpdateScriptsParameters</c>.
        /// </summary>
        public UpdateScriptsParametersDelegate UpdateScriptsParameters;
        
        /// <summary>
        /// WMI static method <c>CreateScripts</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="approvalState">WMI Property <c>ApprovalState</c> of type <c>uint</c>.</param>
        /// <param name="approver">WMI Property <c>Approver</c> of type <c>string</c>.</param>
        /// <param name="author">WMI Property <c>Author</c> of type <c>string</c>.</param>
        /// <param name="comment">WMI Property <c>Comment</c> of type <c>string</c>.</param>
        /// <param name="parameterlistXml">WMI Property <c>ParameterlistXML</c> of type <c>string</c>.</param>
        /// <param name="paramsDefinition">WMI Property <c>ParamsDefinition</c> of type <c>string</c>.</param>
        /// <param name="script">WMI Property <c>Script</c> of type <c>string</c>.</param>
        /// <param name="scriptGuid">WMI Property <c>ScriptGuid</c> of type <c>string</c>.</param>
        /// <param name="scriptName">WMI Property <c>ScriptName</c> of type <c>string</c>.</param>
        /// <param name="scriptType">WMI Property <c>ScriptType</c> of type <c>uint</c>.</param>
        /// <param name="scriptVersion">WMI Property <c>ScriptVersion</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateScriptsDelegate(WmiContext wmiContext, uint approvalState = default, string approver = default, string author = default, string comment = default, string parameterlistXml = default, string paramsDefinition = default, string script = default, string scriptGuid = default, string scriptName = default, uint scriptType = default, string scriptVersion = default);
        /// <summary>
        /// WMI static method <c>CreateScripts</c>.
        /// </summary>
        public static CreateScriptsDelegate CreateScripts;
        
        /// <summary>
        /// WMI method <c>UpdateScript</c> describing delegate.
        /// <param name="paramsDefinition">WMI Property <c>ParamsDefinition</c> of type <c>string</c>.</param>
        /// <param name="script">WMI Property <c>Script</c> of type <c>string</c>.</param>
        /// <param name="scriptVersion">WMI Property <c>ScriptVersion</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateScriptDelegate(string paramsDefinition = default, string script = default, string scriptVersion = default);
        /// <summary>
        /// WMI method <c>UpdateScript</c>.
        /// </summary>
        public UpdateScriptDelegate UpdateScript;
        /// <summary>
        /// WMI Property ApprovalState
        /// </summary>
        public int ApprovalState { get; set; }
        /// <summary>
        /// WMI Property Approver
        /// </summary>
        public string Approver { get; set; }
        /// <summary>
        /// WMI Property Author
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property Feature
        /// </summary>
        public int Feature { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property ParameterGroupHash
        /// </summary>
        public string ParameterGroupHash { get; set; }
        /// <summary>
        /// WMI Property Parameterlist
        /// </summary>
        public  ICollection<SmsScriptParameter> Parameterlist { get; set; }
        /// <summary>
        /// WMI Property ParameterlistXML
        /// </summary>
        public string ParameterlistXml { get; set; }
        /// <summary>
        /// WMI Property ParamsDefinition
        /// </summary>
        public string ParamsDefinition { get; set; }
        /// <summary>
        /// WMI Property Script
        /// </summary>
        public string Script { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
        /// <summary>
        /// WMI Property ScriptHash
        /// </summary>
        public string ScriptHash { get; set; }
        /// <summary>
        /// WMI Property ScriptHashAlgorithm
        /// </summary>
        public string ScriptHashAlgorithm { get; set; }
        /// <summary>
        /// WMI Property ScriptName
        /// </summary>
        public string ScriptName { get; set; }
        /// <summary>
        /// WMI Property ScriptType
        /// </summary>
        public int ScriptType { get; set; }
        /// <summary>
        /// WMI Property ScriptVersion
        /// </summary>
        public string ScriptVersion { get; set; }
    }
}
