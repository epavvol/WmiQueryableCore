using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Printer
    /// </summary>
    [WmiClass(Name = "Win32_Printer")]
    public class Win32Printer
    {
        /// <summary>
        /// WMI static method <c>AddPrinterConnection</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddPrinterConnectionDelegate(WmiContext wmiContext, string name = default);

        /// <summary>
        /// WMI method <c>CancelAllJobs</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CancelAllJobsDelegate();

        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>Pause</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint PauseDelegate();

        /// <summary>
        /// WMI method <c>PrintTestPage</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint PrintTestPageDelegate();

        /// <summary>
        /// WMI method <c>RenamePrinter</c> describing delegate.
        /// <param name="newPrinterName">WMI Property <c>NewPrinterName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenamePrinterDelegate(string newPrinterName = default);

        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI method <c>Resume</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResumeDelegate();

        /// <summary>
        /// WMI method <c>SetDefaultPrinter</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDefaultPrinterDelegate();

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI static method <c>AddPrinterConnection</c>.
        /// </summary>
        public static AddPrinterConnectionDelegate AddPrinterConnection;

        /// <summary>
        /// WMI method <c>CancelAllJobs</c>.
        /// </summary>
        public CancelAllJobsDelegate CancelAllJobs;

        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c>.
        /// </summary>
        public GetSecurityDescriptorDelegate GetSecurityDescriptor;

        /// <summary>
        /// WMI method <c>Pause</c>.
        /// </summary>
        public PauseDelegate Pause;

        /// <summary>
        /// WMI method <c>PrintTestPage</c>.
        /// </summary>
        public PrintTestPageDelegate PrintTestPage;

        /// <summary>
        /// WMI method <c>RenamePrinter</c>.
        /// </summary>
        public RenamePrinterDelegate RenamePrinter;

        /// <summary>
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>Resume</c>.
        /// </summary>
        public ResumeDelegate Resume;

        /// <summary>
        /// WMI method <c>SetDefaultPrinter</c>.
        /// </summary>
        public SetDefaultPrinterDelegate SetDefaultPrinter;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c>.
        /// </summary>
        public SetSecurityDescriptorDelegate SetSecurityDescriptor;

        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public uint Attributes { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property AvailableJobSheets
        /// </summary>
        public ICollection<string> AvailableJobSheets { get; set; }

        /// <summary>
        /// WMI Property AveragePagesPerMinute
        /// </summary>
        public uint AveragePagesPerMinute { get; set; }

        /// <summary>
        /// WMI Property Capabilities
        /// </summary>
        public ICollection<ushort> Capabilities { get; set; }

        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public ICollection<string> CapabilityDescriptions { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CharSetsSupported
        /// </summary>
        public ICollection<string> CharSetsSupported { get; set; }

        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentCapabilities
        /// </summary>
        public ICollection<ushort> CurrentCapabilities { get; set; }

        /// <summary>
        /// WMI Property CurrentCharSet
        /// </summary>
        public string CurrentCharSet { get; set; }

        /// <summary>
        /// WMI Property CurrentLanguage
        /// </summary>
        public ushort CurrentLanguage { get; set; }

        /// <summary>
        /// WMI Property CurrentMimeType
        /// </summary>
        public string CurrentMimeType { get; set; }

        /// <summary>
        /// WMI Property CurrentNaturalLanguage
        /// </summary>
        public string CurrentNaturalLanguage { get; set; }

        /// <summary>
        /// WMI Property CurrentPaperType
        /// </summary>
        public string CurrentPaperType { get; set; }

        /// <summary>
        /// WMI Property Default
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// WMI Property DefaultCapabilities
        /// </summary>
        public ICollection<ushort> DefaultCapabilities { get; set; }

        /// <summary>
        /// WMI Property DefaultCopies
        /// </summary>
        public uint DefaultCopies { get; set; }

        /// <summary>
        /// WMI Property DefaultLanguage
        /// </summary>
        public ushort DefaultLanguage { get; set; }

        /// <summary>
        /// WMI Property DefaultMimeType
        /// </summary>
        public string DefaultMimeType { get; set; }

        /// <summary>
        /// WMI Property DefaultNumberUp
        /// </summary>
        public uint DefaultNumberUp { get; set; }

        /// <summary>
        /// WMI Property DefaultPaperType
        /// </summary>
        public string DefaultPaperType { get; set; }

        /// <summary>
        /// WMI Property DefaultPriority
        /// </summary>
        public uint DefaultPriority { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DetectedErrorState
        /// </summary>
        public ushort DetectedErrorState { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property Direct
        /// </summary>
        public bool Direct { get; set; }

        /// <summary>
        /// WMI Property DoCompleteFirst
        /// </summary>
        public bool DoCompleteFirst { get; set; }

        /// <summary>
        /// WMI Property DriverName
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// WMI Property EnableBIDI
        /// </summary>
        public bool EnableBidi { get; set; }

        /// <summary>
        /// WMI Property EnableDevQueryPrint
        /// </summary>
        public bool EnableDevQueryPrint { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property ErrorInformation
        /// </summary>
        public ICollection<string> ErrorInformation { get; set; }

        /// <summary>
        /// WMI Property ExtendedDetectedErrorState
        /// </summary>
        public ushort ExtendedDetectedErrorState { get; set; }

        /// <summary>
        /// WMI Property ExtendedPrinterStatus
        /// </summary>
        public ushort ExtendedPrinterStatus { get; set; }

        /// <summary>
        /// WMI Property Hidden
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property JobCountSinceLastReset
        /// </summary>
        public uint JobCountSinceLastReset { get; set; }

        /// <summary>
        /// WMI Property KeepPrintedJobs
        /// </summary>
        public bool KeepPrintedJobs { get; set; }

        /// <summary>
        /// WMI Property LanguagesSupported
        /// </summary>
        public ICollection<ushort> LanguagesSupported { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property Local
        /// </summary>
        public bool Local { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// WMI Property MarkingTechnology
        /// </summary>
        public ushort MarkingTechnology { get; set; }

        /// <summary>
        /// WMI Property MaxCopies
        /// </summary>
        public uint MaxCopies { get; set; }

        /// <summary>
        /// WMI Property MaxNumberUp
        /// </summary>
        public uint MaxNumberUp { get; set; }

        /// <summary>
        /// WMI Property MaxSizeSupported
        /// </summary>
        public uint MaxSizeSupported { get; set; }

        /// <summary>
        /// WMI Property MimeTypesSupported
        /// </summary>
        public ICollection<string> MimeTypesSupported { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NaturalLanguagesSupported
        /// </summary>
        public ICollection<string> NaturalLanguagesSupported { get; set; }

        /// <summary>
        /// WMI Property Network
        /// </summary>
        public bool Network { get; set; }

        /// <summary>
        /// WMI Property PaperSizesSupported
        /// </summary>
        public ICollection<ushort> PaperSizesSupported { get; set; }

        /// <summary>
        /// WMI Property PaperTypesAvailable
        /// </summary>
        public ICollection<string> PaperTypesAvailable { get; set; }

        /// <summary>
        /// WMI Property Parameters
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PortName
        /// </summary>
        public string PortName { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property PrinterPaperNames
        /// </summary>
        public ICollection<string> PrinterPaperNames { get; set; }

        /// <summary>
        /// WMI Property PrinterState
        /// </summary>
        public uint PrinterState { get; set; }

        /// <summary>
        /// WMI Property PrinterStatus
        /// </summary>
        public ushort PrinterStatus { get; set; }

        /// <summary>
        /// WMI Property PrintJobDataType
        /// </summary>
        public string PrintJobDataType { get; set; }

        /// <summary>
        /// WMI Property PrintProcessor
        /// </summary>
        public string PrintProcessor { get; set; }

        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }

        /// <summary>
        /// WMI Property Published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// WMI Property Queued
        /// </summary>
        public bool Queued { get; set; }

        /// <summary>
        /// WMI Property RawOnly
        /// </summary>
        public bool RawOnly { get; set; }

        /// <summary>
        /// WMI Property SeparatorFile
        /// </summary>
        public string SeparatorFile { get; set; }

        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// WMI Property Shared
        /// </summary>
        public bool Shared { get; set; }

        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }

        /// <summary>
        /// WMI Property SpoolEnabled
        /// </summary>
        public bool SpoolEnabled { get; set; }

        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }

        /// <summary>
        /// WMI Property UntilTime
        /// </summary>
        public DateTime UntilTime { get; set; }

        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }

        /// <summary>
        /// WMI Property WorkOffline
        /// </summary>
        public bool WorkOffline { get; set; }
    }
}