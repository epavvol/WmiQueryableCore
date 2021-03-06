using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365ConnectionHealth
    /// </summary>
    [WmiClass(Name = "SMS_M365ConnectionHealth")]
    public class SmsM365ConnectionHealth
    {
        /// <summary>
        /// WMI Property AllAppraiserVersions
        /// </summary>
        public uint AllAppraiserVersions { get; set; }
        /// <summary>
        /// WMI Property AnalyticsDeviceID
        /// </summary>
        public string AnalyticsDeviceId { get; set; }
        /// <summary>
        /// WMI Property AppraiserKBs
        /// </summary>
        public uint AppraiserKBs { get; set; }
        /// <summary>
        /// WMI Property AppraiserLastExitCode
        /// </summary>
        public uint AppraiserLastExitCode { get; set; }
        /// <summary>
        /// WMI Property AppraiserLastSuccesfulRunTime
        /// </summary>
        public DateTime AppraiserLastSuccesfulRunTime { get; set; }
        /// <summary>
        /// WMI Property AppraiserRunState
        /// </summary>
        public uint AppraiserRunState { get; set; }
        /// <summary>
        /// WMI Property AppraiserVersion
        /// </summary>
        public string AppraiserVersion { get; set; }
        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public uint BuildNumber { get; set; }
        /// <summary>
        /// WMI Property CensusLastExitCode
        /// </summary>
        public uint CensusLastExitCode { get; set; }
        /// <summary>
        /// WMI Property CensusLastSuccesfulRunTime
        /// </summary>
        public DateTime CensusLastSuccesfulRunTime { get; set; }
        /// <summary>
        /// WMI Property CensusRunState
        /// </summary>
        public uint CensusRunState { get; set; }
        /// <summary>
        /// WMI Property CheckConnectivityDiagnosis
        /// </summary>
        public uint CheckConnectivityDiagnosis { get; set; }
        /// <summary>
        /// WMI Property CheckEndpoints
        /// </summary>
        public uint CheckEndpoints { get; set; }
        /// <summary>
        /// WMI Property CheckOfficeTelemetryLevel
        /// </summary>
        public uint CheckOfficeTelemetryLevel { get; set; }
        /// <summary>
        /// WMI Property CheckUserDisableTelemetry
        /// </summary>
        public uint CheckUserDisableTelemetry { get; set; }
        /// <summary>
        /// WMI Property CheckUserProxy
        /// </summary>
        public uint CheckUserProxy { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property CommercialID
        /// </summary>
        public uint CommercialId { get; set; }
        /// <summary>
        /// WMI Property CommercialOptIn
        /// </summary>
        public uint CommercialOptIn { get; set; }
        /// <summary>
        /// WMI Property ComputerNameOptIn
        /// </summary>
        public uint ComputerNameOptIn { get; set; }
        /// <summary>
        /// WMI Property DataUnavailable
        /// </summary>
        public uint DataUnavailable { get; set; }
        /// <summary>
        /// WMI Property DaysSinceTelemetry
        /// </summary>
        public uint DaysSinceTelemetry { get; set; }
        /// <summary>
        /// WMI Property DeviceCategory
        /// </summary>
        public uint DeviceCategory { get; set; }
        /// <summary>
        /// WMI Property DeviceLastSeen
        /// </summary>
        public DateTime DeviceLastSeen { get; set; }
        /// <summary>
        /// WMI Property DiagtrackService
        /// </summary>
        public uint DiagtrackService { get; set; }
        /// <summary>
        /// WMI Property DiagtrackVersion
        /// </summary>
        public string DiagtrackVersion { get; set; }
        /// <summary>
        /// WMI Property GetSqmId
        /// </summary>
        public uint GetSqmId { get; set; }
        /// <summary>
        /// WMI Property InventoryCompleteness
        /// </summary>
        public uint InventoryCompleteness { get; set; }
        /// <summary>
        /// WMI Property IsClient
        /// </summary>
        public uint IsClient { get; set; }
        /// <summary>
        /// WMI Property LastMessageTime
        /// </summary>
        public DateTime LastMessageTime { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property MSAService
        /// </summary>
        public uint MsaService { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OfficeTelemetry
        /// </summary>
        public uint OfficeTelemetry { get; set; }
        /// <summary>
        /// WMI Property ProxyDetails
        /// </summary>
        public string ProxyDetails { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property SqmId
        /// </summary>
        public string SqmId { get; set; }
        /// <summary>
        /// WMI Property TelemetryOptIn
        /// </summary>
        public uint TelemetryOptIn { get; set; }
    }
}
