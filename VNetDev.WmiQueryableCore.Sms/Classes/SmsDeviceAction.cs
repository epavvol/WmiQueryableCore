using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceAction
    /// </summary>
    [WmiClass(Name = "SMS_DeviceAction")]
    public class SmsDeviceAction
    {
        /// <summary>
        /// WMI static method <c>InvokeAction</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="action">WMI Property <c>Action</c> of type <c>string</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <param name="resourceType">WMI Property <c>ResourceType</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InvokeActionDelegate(WmiContext wmiContext, string action = default, uint resourceId = default, uint resourceType = default);
        /// <summary>
        /// WMI static method <c>InvokeAction</c>.
        /// </summary>
        public static InvokeActionDelegate InvokeAction;
        
        /// <summary>
        /// WMI static method <c>GetActivationLockBypassCode</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetActivationLockBypassCodeDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>GetActivationLockBypassCode</c>.
        /// </summary>
        public static GetActivationLockBypassCodeDelegate GetActivationLockBypassCode;
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResponseText
        /// </summary>
        public string ResponseText { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property SourceType
        /// </summary>
        public uint SourceType { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
