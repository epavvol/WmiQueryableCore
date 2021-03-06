using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_FQDN_Validation
    /// </summary>
    [WmiClass(Name = "SMS_FQDN_Validation")]
    public class SmsFqdnValidation
    {
        /// <summary>
        /// WMI static method <c>IsValidFQDN</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="machineNameFqdn">WMI Property <c>MachineNameFQDN</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsValidFqdnDelegate(WmiContext wmiContext, string machineNameFqdn = default);
        /// <summary>
        /// WMI static method <c>IsValidFQDN</c>.
        /// </summary>
        public static IsValidFqdnDelegate IsValidFqdn;
    }
}
