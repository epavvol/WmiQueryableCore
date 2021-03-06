using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CommonSmbiosGuids
    /// </summary>
    [WmiClass(Name = "SMS_CommonSmbiosGuids")]
    public class SmsCommonSmbiosGuids
    {
        /// <summary>
        /// WMI Property SMBIOS_GUID
        /// </summary>
        [WmiProperty(Name = "SMBIOS_GUID")]
        public string SmbiosGuid { get; set; }
    }
}
