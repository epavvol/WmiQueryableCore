using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Client_ComanagementState
    /// </summary>
    [WmiClass(Name = "SMS_Client_ComanagementState")]
    public class SmsClientComanagementState
    {
        /// <summary>
        /// WMI Property AADDeviceID
        /// </summary>
        public string AadDeviceId { get; set; }
        /// <summary>
        /// WMI Property AADJoined
        /// </summary>
        public bool AadJoined { get; set; }
        /// <summary>
        /// WMI Property Authority
        /// </summary>
        public string Authority { get; set; }
        /// <summary>
        /// WMI Property ComgmtPolicyPresent
        /// </summary>
        public bool ComgmtPolicyPresent { get; set; }
        /// <summary>
        /// WMI Property EnrollmentErrorDetail
        /// </summary>
        public string EnrollmentErrorDetail { get; set; }
        /// <summary>
        /// WMI Property EnrollmentFailed
        /// </summary>
        public bool EnrollmentFailed { get; set; }
        /// <summary>
        /// WMI Property EnrollmentScheduled
        /// </summary>
        public bool EnrollmentScheduled { get; set; }
        /// <summary>
        /// WMI Property EnrollmentStatusCode
        /// </summary>
        public uint EnrollmentStatusCode { get; set; }
        /// <summary>
        /// WMI Property HybridAADJoined
        /// </summary>
        public bool HybridAadJoined { get; set; }
        /// <summary>
        /// WMI Property MDMEnrolled
        /// </summary>
        public bool MdmEnrolled { get; set; }
        /// <summary>
        /// WMI Property MDMProvisioned
        /// </summary>
        public bool MdmProvisioned { get; set; }
        /// <summary>
        /// WMI Property MDMWorkloads
        /// </summary>
        public string MdmWorkloads { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PendingLogon
        /// </summary>
        public bool PendingLogon { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
