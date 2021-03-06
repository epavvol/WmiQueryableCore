using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeploymentTypeLicenseAssociation
    /// </summary>
    [WmiClass(Name = "SMS_DeploymentTypeLicenseAssociation")]
    public class SmsDeploymentTypeLicenseAssociation
    {
        /// <summary>
        /// WMI static method <c>AddLicense</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="licenseBlob">WMI Property <c>LicenseBlob</c> of type <c>string</c>.</param>
        /// <param name="licenseId">WMI Property <c>LicenseID</c> of type <c>string</c>.</param>
        /// <param name="modelName">WMI Property <c>ModelName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddLicenseDelegate(WmiContext wmiContext, string licenseBlob = default, string licenseId = default, string modelName = default);
        /// <summary>
        /// WMI static method <c>AddLicense</c>.
        /// </summary>
        public static AddLicenseDelegate AddLicense;
        /// <summary>
        /// WMI Property DTModelName
        /// </summary>
        public string DtModelName { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsEnabled
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// WMI Property LicenseID
        /// </summary>
        public string LicenseId { get; set; }
    }
}
