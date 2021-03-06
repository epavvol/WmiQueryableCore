using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PeerPxeConfig
    /// </summary>
    [WmiClass(Name = "SMS_PeerPxeConfig")]
    public class SmsPeerPxeConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property EnablePeerPxe
        /// </summary>
        public bool EnablePeerPxe { get; set; }
        /// <summary>
        /// WMI Property EnableUnknownComputers
        /// </summary>
        public bool EnableUnknownComputers { get; set; }
        /// <summary>
        /// WMI Property PxeCertData
        /// </summary>
        public string PxeCertData { get; set; }
        /// <summary>
        /// WMI Property RequireVerification
        /// </summary>
        public bool RequireVerification { get; set; }
        /// <summary>
        /// WMI Property ResponseDelay
        /// </summary>
        public uint ResponseDelay { get; set; }
        /// <summary>
        /// WMI Property TftpBlockSize
        /// </summary>
        public uint TftpBlockSize { get; set; }
        /// <summary>
        /// WMI Property TftpWindowSize
        /// </summary>
        public uint TftpWindowSize { get; set; }
        /// <summary>
        /// WMI Property Verification
        /// </summary>
        public string Verification { get; set; }
    }
}
