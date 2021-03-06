using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SleepServer
    /// </summary>
    [WmiClass(Name = "SMS_SleepServer")]
    public class SmsSleepServer
    {
        /// <summary>
        /// WMI static method <c>MachinesToWakeup</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <param name="machineIDs">WMI Property <c>MachineIDs</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint MachinesToWakeupDelegate(WmiContext wmiContext, string collectionId = default, string machineIDs = default);
        /// <summary>
        /// WMI static method <c>MachinesToWakeup</c>.
        /// </summary>
        public static MachinesToWakeupDelegate MachinesToWakeup;
    }
}
