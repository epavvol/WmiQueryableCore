using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDataSourcesContentStats
    /// </summary>
    [WmiClass(Name = "SMS_ClientDataSourcesContentStats")]
    public class SmsClientDataSourcesContentStats
    {
        /// <summary>
        /// WMI Property BytesDownloaded
        /// </summary>
        public ulong BytesDownloaded { get; set; }
        /// <summary>
        /// WMI Property ContentName
        /// </summary>
        public string ContentName { get; set; }
        /// <summary>
        /// WMI Property SourceType
        /// </summary>
        public uint SourceType { get; set; }
    }
}
