using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PDF_Program
    /// </summary>
    [WmiClass(Name = "SMS_PDF_Program")]
    public class SmsPdfProgram
    {
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
        /// WMI Property Icon
        /// </summary>
        public ICollection<byte> Icon { get; set; }
        /// <summary>
        /// WMI Property IconSize
        /// </summary>
        public uint IconSize { get; set; }
        /// <summary>
        /// WMI Property PDFID
        /// </summary>
        public uint Pdfid { get; set; }
        /// <summary>
        /// WMI Property ProgramFlags
        /// </summary>
        public uint ProgramFlags { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property Requirements
        /// </summary>
        public string Requirements { get; set; }
        /// <summary>
        /// WMI Property WorkingDirectory
        /// </summary>
        public string WorkingDirectory { get; set; }
    }
}
