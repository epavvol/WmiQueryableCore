using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMCorpOwnedDevices
    /// </summary>
    [WmiClass(Name = "SMS_MDMCorpOwnedDevices")]
    public class SmsMdmCorpOwnedDevices
    {
        /// <summary>
        /// WMI static method <c>UpdateProfileIdForDevices</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deviceSerialNumbers">WMI Property <c>DeviceSerialNumbers</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="requestEnrollmentProfileId">WMI Property <c>RequestEnrollmentProfileId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateProfileIdForDevicesDelegate(WmiContext wmiContext, ICollection<string> deviceSerialNumbers = default, string requestEnrollmentProfileId = default);
        /// <summary>
        /// WMI static method <c>UpdateProfileIdForDevices</c>.
        /// </summary>
        public static UpdateProfileIdForDevicesDelegate UpdateProfileIdForDevices;
        
        /// <summary>
        /// WMI static method <c>UploadAppleDepToken</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="encryptedToken">WMI Property <c>EncryptedToken</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UploadAppleDepTokenDelegate(WmiContext wmiContext, string encryptedToken = default);
        /// <summary>
        /// WMI static method <c>UploadAppleDepToken</c>.
        /// </summary>
        public static UploadAppleDepTokenDelegate UploadAppleDepToken;
        
        /// <summary>
        /// WMI static method <c>GetAppleDepEncryptionKey</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetAppleDepEncryptionKeyDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetAppleDepEncryptionKey</c>.
        /// </summary>
        public static GetAppleDepEncryptionKeyDelegate GetAppleDepEncryptionKey;
        /// <summary>
        /// WMI Property ActualEnrollmentProfileAssignedTime
        /// </summary>
        public DateTime ActualEnrollmentProfileAssignedTime { get; set; }
        /// <summary>
        /// WMI Property ActualEnrollmentProfileId
        /// </summary>
        public string ActualEnrollmentProfileId { get; set; }
        /// <summary>
        /// WMI Property AssetTag
        /// </summary>
        public string AssetTag { get; set; }
        /// <summary>
        /// WMI Property Color
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceAssignedBy
        /// </summary>
        public string DeviceAssignedBy { get; set; }
        /// <summary>
        /// WMI Property DeviceAssignedDate
        /// </summary>
        public DateTime DeviceAssignedDate { get; set; }
        /// <summary>
        /// WMI Property DeviceId
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public uint DeviceType { get; set; }
        /// <summary>
        /// WMI Property DiscoverySources
        /// </summary>
        public uint DiscoverySources { get; set; }
        /// <summary>
        /// WMI Property EnrollmentPackageId
        /// </summary>
        public string EnrollmentPackageId { get; set; }
        /// <summary>
        /// WMI Property EnrollmentStatus
        /// </summary>
        public uint EnrollmentStatus { get; set; }
        /// <summary>
        /// WMI Property EnrollmentType
        /// </summary>
        public uint EnrollmentType { get; set; }
        /// <summary>
        /// WMI Property ExchangeDeviceId
        /// </summary>
        public string ExchangeDeviceId { get; set; }
        /// <summary>
        /// WMI Property IMEI
        /// </summary>
        public string Imei { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property OSVersion
        /// </summary>
        public string OsVersion { get; set; }
        /// <summary>
        /// WMI Property ProfileAssignedTime
        /// </summary>
        public DateTime ProfileAssignedTime { get; set; }
        /// <summary>
        /// WMI Property ProfileName
        /// </summary>
        public string ProfileName { get; set; }
        /// <summary>
        /// WMI Property ProfilePushedTime
        /// </summary>
        public DateTime ProfilePushedTime { get; set; }
        /// <summary>
        /// WMI Property ProfileStatus
        /// </summary>
        public uint ProfileStatus { get; set; }
        /// <summary>
        /// WMI Property ProfileUuid
        /// </summary>
        public string ProfileUuid { get; set; }
        /// <summary>
        /// WMI Property RequestEnrollmentProfileAssignedTime
        /// </summary>
        public DateTime RequestEnrollmentProfileAssignedTime { get; set; }
        /// <summary>
        /// WMI Property RequestEnrollmentProfileId
        /// </summary>
        public string RequestEnrollmentProfileId { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property UniqueId
        /// </summary>
        public string UniqueId { get; set; }
    }
}
