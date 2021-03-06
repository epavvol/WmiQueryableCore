using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PrinterDriver
    /// </summary>
    [WmiClass(Name = "Win32_PrinterDriver")]
    public class Win32PrinterDriver
    {
        /// <summary>
        /// WMI static method <c>AddPrinterDriver</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="driverInfo">WMI Property <c>DriverInfo</c> of type <c> Win32PrinterDriver</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddPrinterDriverDelegate(WmiContext wmiContext, Win32PrinterDriver driverInfo = default);

        /// <summary>
        /// WMI method <c>StartService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StartServiceDelegate();

        /// <summary>
        /// WMI method <c>StopService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StopServiceDelegate();

        /// <summary>
        /// WMI static method <c>AddPrinterDriver</c>.
        /// </summary>
        public static AddPrinterDriverDelegate AddPrinterDriver;

        /// <summary>
        /// WMI method <c>StartService</c>.
        /// </summary>
        public StartServiceDelegate StartService;

        /// <summary>
        /// WMI method <c>StopService</c>.
        /// </summary>
        public StopServiceDelegate StopService;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ConfigFile
        /// </summary>
        public string ConfigFile { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property DataFile
        /// </summary>
        public string DataFile { get; set; }

        /// <summary>
        /// WMI Property DefaultDataType
        /// </summary>
        public string DefaultDataType { get; set; }

        /// <summary>
        /// WMI Property DependentFiles
        /// </summary>
        public ICollection<string> DependentFiles { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DriverPath
        /// </summary>
        public string DriverPath { get; set; }

        /// <summary>
        /// WMI Property FilePath
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// WMI Property HelpFile
        /// </summary>
        public string HelpFile { get; set; }

        /// <summary>
        /// WMI Property InfName
        /// </summary>
        public string InfName { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property MonitorName
        /// </summary>
        public string MonitorName { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OEMUrl
        /// </summary>
        public string OemUrl { get; set; }

        /// <summary>
        /// WMI Property Started
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// WMI Property StartMode
        /// </summary>
        public string StartMode { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SupportedPlatform
        /// </summary>
        public string SupportedPlatform { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public ushort Version { get; set; }
    }
}