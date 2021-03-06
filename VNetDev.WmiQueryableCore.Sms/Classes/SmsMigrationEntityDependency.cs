using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationEntityDependency
    /// </summary>
    [WmiClass(Name = "SMS_MigrationEntityDependency")]
    public class SmsMigrationEntityDependency
    {
        /// <summary>
        /// WMI Property Dependant
        /// </summary>
        public uint Dependant { get; set; }
        /// <summary>
        /// WMI Property DependencyType
        /// </summary>
        public uint DependencyType { get; set; }
        /// <summary>
        /// WMI Property EntityID
        /// </summary>
        public uint EntityId { get; set; }
    }
}
