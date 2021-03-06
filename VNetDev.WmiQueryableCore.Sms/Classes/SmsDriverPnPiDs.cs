using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DriverPnPIDs
    /// </summary>
    [WmiClass(Name = "SMS_DriverPnPIDs")]
    public class SmsDriverPnPiDs
    {
        /// <summary>
        /// WMI Property AddedToWSUS
        /// </summary>
        public bool AddedToWsus { get; set; }
        /// <summary>
        /// WMI Property CreatedInWSUS
        /// </summary>
        public bool CreatedInWsus { get; set; }
        /// <summary>
        /// WMI Property DateAddedInWSUS
        /// </summary>
        public DateTime DateAddedInWsus { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property PnPDescription
        /// </summary>
        public string PnPDescription { get; set; }
        /// <summary>
        /// WMI Property PnPName
        /// </summary>
        public string PnPName { get; set; }
    }
}
