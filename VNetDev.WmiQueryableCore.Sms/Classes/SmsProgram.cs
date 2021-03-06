using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Program
    /// </summary>
    [WmiClass(Name = "SMS_Program")]
    public class SmsProgram
    {
        /// <summary>
        /// WMI Property ActionInProgress
        /// </summary>
        public uint ActionInProgress { get; set; }
        /// <summary>
        /// WMI Property ApplicationHierarchy
        /// </summary>
        public string ApplicationHierarchy { get; set; }
        /// <summary>
        /// WMI Property CommandLine
        /// </summary>
        public string CommandLine { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property DependentProgram
        /// </summary>
        public string DependentProgram { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceFlags
        /// </summary>
        public uint DeviceFlags { get; set; }
        /// <summary>
        /// WMI Property DiskSpaceReq
        /// </summary>
        public string DiskSpaceReq { get; set; }
        /// <summary>
        /// WMI Property DriveLetter
        /// </summary>
        public string DriveLetter { get; set; }
        /// <summary>
        /// WMI Property Duration
        /// </summary>
        public uint Duration { get; set; }
        /// <summary>
        /// WMI Property ExtendedData
        /// </summary>
        public ICollection<byte> ExtendedData { get; set; }
        /// <summary>
        /// WMI Property ExtendedDataSize
        /// </summary>
        public uint ExtendedDataSize { get; set; }
        /// <summary>
        /// WMI Property Icon
        /// </summary>
        public ICollection<byte> Icon { get; set; }
        /// <summary>
        /// WMI Property IconSize
        /// </summary>
        public uint IconSize { get; set; }
        /// <summary>
        /// WMI Property ISVData
        /// </summary>
        public ICollection<byte> IsvData { get; set; }
        /// <summary>
        /// WMI Property ISVDataSize
        /// </summary>
        public uint IsvDataSize { get; set; }
        /// <summary>
        /// WMI Property ISVString
        /// </summary>
        public string IsvString { get; set; }
        /// <summary>
        /// WMI Property MSIFilePath
        /// </summary>
        public string MsiFilePath { get; set; }
        /// <summary>
        /// WMI Property MSIProductID
        /// </summary>
        public string MsiProductId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property PackageVersion
        /// </summary>
        public string PackageVersion { get; set; }
        /// <summary>
        /// WMI Property ProgramFlags
        /// </summary>
        public uint ProgramFlags { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property RemovalKey
        /// </summary>
        public string RemovalKey { get; set; }
        /// <summary>
        /// WMI Property Requirements
        /// </summary>
        public string Requirements { get; set; }
        /// <summary>
        /// WMI Property SecuredTypeID
        /// </summary>
        public uint SecuredTypeId { get; set; }
        /// <summary>
        /// WMI Property SupportedOperatingSystems
        /// </summary>
        public ICollection<object> SupportedOperatingSystems { get; set; }
        /// <summary>
        /// WMI Property TransformAnalysisDate
        /// </summary>
        public DateTime TransformAnalysisDate { get; set; }
        /// <summary>
        /// WMI Property TransformDtID
        /// </summary>
        public string TransformDtId { get; set; }
        /// <summary>
        /// WMI Property TransformReadiness
        /// </summary>
        public uint TransformReadiness { get; set; }
        /// <summary>
        /// WMI Property WorkingDirectory
        /// </summary>
        public string WorkingDirectory { get; set; }
    }
}
