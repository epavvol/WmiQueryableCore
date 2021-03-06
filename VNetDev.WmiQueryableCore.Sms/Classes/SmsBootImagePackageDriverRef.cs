using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BootImagePackage_DriverRef
    /// </summary>
    [WmiClass(Name = "SMS_BootImagePackage_DriverRef")]
    public class SmsBootImagePackageDriverRef
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public int CiId { get; set; }
        /// <summary>
        /// WMI Property PkgID
        /// </summary>
        public string PkgId { get; set; }
        /// <summary>
        /// WMI Property SourcePath
        /// </summary>
        public string SourcePath { get; set; }
    }
}
