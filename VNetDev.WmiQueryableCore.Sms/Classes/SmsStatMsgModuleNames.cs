using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatMsgModuleNames
    /// </summary>
    [WmiClass(Name = "SMS_StatMsgModuleNames")]
    public class SmsStatMsgModuleNames
    {
        /// <summary>
        /// WMI Property ModuleName
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// WMI Property MsgDLLName
        /// </summary>
        public string MsgDllName { get; set; }
    }
}
