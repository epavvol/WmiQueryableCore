using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationExpandingScope
    /// </summary>
    [WmiClass(Name = "SMS_MigrationExpandingScope")]
    public class SmsMigrationExpandingScope
    {
        /// <summary>
        /// WMI Property CollectionEntityID
        /// </summary>
        public uint CollectionEntityId { get; set; }
        /// <summary>
        /// WMI Property CollectionEntityName
        /// </summary>
        public string CollectionEntityName { get; set; }
        /// <summary>
        /// WMI Property CollectionWMIObjectPath
        /// </summary>
        public string CollectionWmiObjectPath { get; set; }
        /// <summary>
        /// WMI Property TargetingEntityID
        /// </summary>
        public uint TargetingEntityId { get; set; }
        /// <summary>
        /// WMI Property TargetingEntityName
        /// </summary>
        public string TargetingEntityName { get; set; }
        /// <summary>
        /// WMI Property TargetingWMIObjectPath
        /// </summary>
        public string TargetingWmiObjectPath { get; set; }
    }
}
