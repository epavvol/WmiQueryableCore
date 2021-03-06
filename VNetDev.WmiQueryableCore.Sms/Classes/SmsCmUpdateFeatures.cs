using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdateFeatures
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdateFeatures")]
    public class SmsCmUpdateFeatures
    {
        /// <summary>
        /// WMI method <c>UpdateFeatureExposureStatus</c> describing delegate.
        /// <param name="status">WMI Property <c>Status</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateFeatureExposureStatusDelegate(uint status = default);
        /// <summary>
        /// WMI method <c>UpdateFeatureExposureStatus</c>.
        /// </summary>
        public UpdateFeatureExposureStatusDelegate UpdateFeatureExposureStatus;
        /// <summary>
        /// WMI Property DateReleased
        /// </summary>
        public DateTime DateReleased { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property EULA
        /// </summary>
        public string Eula { get; set; }
        /// <summary>
        /// WMI Property Exposed
        /// </summary>
        public uint Exposed { get; set; }
        /// <summary>
        /// WMI Property FeatureGuid
        /// </summary>
        public string FeatureGuid { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public int FeatureType { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public int LocaleId { get; set; }
        /// <summary>
        /// WMI Property MoreInfoLink
        /// </summary>
        public string MoreInfoLink { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
    }
}
