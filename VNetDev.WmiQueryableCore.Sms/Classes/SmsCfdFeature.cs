using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CFDFeature
    /// </summary>
    [WmiClass(Name = "SMS_CFDFeature")]
    public class SmsCfdFeature
    {
        /// <summary>
        /// WMI method <c>SetEnableState</c> describing delegate.
        /// <param name="enable">WMI Property <c>Enable</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetEnableStateDelegate(bool enable = default);
        /// <summary>
        /// WMI method <c>SetEnableState</c>.
        /// </summary>
        public SetEnableStateDelegate SetEnableState;
        
        /// <summary>
        /// WMI method <c>GetBinary</c> describing delegate.
        /// <param name="binaryId">WMI Property <c>BinaryId</c> of type <c>string</c>.</param>
        /// <param name="blockNumber">WMI Property <c>blockNumber</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetBinaryDelegate(string binaryId = default, uint blockNumber = default);
        /// <summary>
        /// WMI method <c>GetBinary</c>.
        /// </summary>
        public GetBinaryDelegate GetBinary;
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property EnabledDate
        /// </summary>
        public DateTime EnabledDate { get; set; }
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property EULA
        /// </summary>
        public string Eula { get; set; }
        /// <summary>
        /// WMI Property FeatureId
        /// </summary>
        public string FeatureId { get; set; }
        /// <summary>
        /// WMI Property FeatureVersion
        /// </summary>
        public int FeatureVersion { get; set; }
        /// <summary>
        /// WMI Property Flag
        /// </summary>
        public uint Flag { get; set; }
        /// <summary>
        /// WMI Property Manifest
        /// </summary>
        public string Manifest { get; set; }
        /// <summary>
        /// WMI Property MaxCMVersion
        /// </summary>
        public string MaxCmVersion { get; set; }
        /// <summary>
        /// WMI Property MinCMVersion
        /// </summary>
        public string MinCmVersion { get; set; }
        /// <summary>
        /// WMI Property MoreInfoUrl
        /// </summary>
        public string MoreInfoUrl { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ReleasedDate
        /// </summary>
        public DateTime ReleasedDate { get; set; }
        /// <summary>
        /// WMI Property Reserved
        /// </summary>
        public string Reserved { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
