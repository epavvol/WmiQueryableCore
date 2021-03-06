using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_BaseService
    /// </summary>
    [WmiClass(Name = "Win32_BaseService")]
    public class Win32BaseService
    {
        /// <summary>
        /// WMI method <c>Change</c> describing delegate.
        /// <param name="desktopInteract">WMI Property <c>DesktopInteract</c> of type <c>bool</c>.</param>
        /// <param name="displayName">WMI Property <c>DisplayName</c> of type <c>string</c>.</param>
        /// <param name="errorControl">WMI Property <c>ErrorControl</c> of type <c>byte</c>.</param>
        /// <param name="loadOrderGroup">WMI Property <c>LoadOrderGroup</c> of type <c>string</c>.</param>
        /// <param name="loadOrderGroupDependencies">WMI Property <c>LoadOrderGroupDependencies</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="pathName">WMI Property <c>PathName</c> of type <c>string</c>.</param>
        /// <param name="serviceDependencies">WMI Property <c>ServiceDependencies</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="serviceType">WMI Property <c>ServiceType</c> of type <c>byte</c>.</param>
        /// <param name="startMode">WMI Property <c>StartMode</c> of type <c>string</c>.</param>
        /// <param name="startName">WMI Property <c>StartName</c> of type <c>string</c>.</param>
        /// <param name="startPassword">WMI Property <c>StartPassword</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChangeDelegate(bool desktopInteract = default, string displayName = default,
            byte errorControl = default, string loadOrderGroup = default,
            ICollection<string> loadOrderGroupDependencies = default, string pathName = default,
            ICollection<string> serviceDependencies = default, byte serviceType = default, string startMode = default,
            string startName = default, string startPassword = default);

        /// <summary>
        /// WMI method <c>ChangeStartMode</c> describing delegate.
        /// <param name="startMode">WMI Property <c>StartMode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChangeStartModeDelegate(string startMode = default);

        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="desktopInteract">WMI Property <c>DesktopInteract</c> of type <c>bool</c>.</param>
        /// <param name="displayName">WMI Property <c>DisplayName</c> of type <c>string</c>.</param>
        /// <param name="errorControl">WMI Property <c>ErrorControl</c> of type <c>byte</c>.</param>
        /// <param name="loadOrderGroup">WMI Property <c>LoadOrderGroup</c> of type <c>string</c>.</param>
        /// <param name="loadOrderGroupDependencies">WMI Property <c>LoadOrderGroupDependencies</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="pathName">WMI Property <c>PathName</c> of type <c>string</c>.</param>
        /// <param name="serviceDependencies">WMI Property <c>ServiceDependencies</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="serviceType">WMI Property <c>ServiceType</c> of type <c>byte</c>.</param>
        /// <param name="startMode">WMI Property <c>StartMode</c> of type <c>string</c>.</param>
        /// <param name="startName">WMI Property <c>StartName</c> of type <c>string</c>.</param>
        /// <param name="startPassword">WMI Property <c>StartPassword</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, bool desktopInteract = default,
            string displayName = default, byte errorControl = default, string loadOrderGroup = default,
            ICollection<string> loadOrderGroupDependencies = default, string name = default, string pathName = default,
            ICollection<string> serviceDependencies = default, byte serviceType = default, string startMode = default,
            string startName = default, string startPassword = default);

        /// <summary>
        /// WMI method <c>Delete</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteDelegate();

        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>InterrogateService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint InterrogateServiceDelegate();

        /// <summary>
        /// WMI method <c>PauseService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint PauseServiceDelegate();

        /// <summary>
        /// WMI method <c>ResumeService</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResumeServiceDelegate();

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

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
        /// WMI method <c>UserControlService</c> describing delegate.
        /// <param name="controlCode">WMI Property <c>ControlCode</c> of type <c>byte</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UserControlServiceDelegate(byte controlCode = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI method <c>Change</c>.
        /// </summary>
        public ChangeDelegate Change;

        /// <summary>
        /// WMI method <c>ChangeStartMode</c>.
        /// </summary>
        public ChangeStartModeDelegate ChangeStartMode;

        /// <summary>
        /// WMI method <c>Delete</c>.
        /// </summary>
        public DeleteDelegate Delete;

        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c>.
        /// </summary>
        public GetSecurityDescriptorDelegate GetSecurityDescriptor;

        /// <summary>
        /// WMI method <c>InterrogateService</c>.
        /// </summary>
        public InterrogateServiceDelegate InterrogateService;

        /// <summary>
        /// WMI method <c>PauseService</c>.
        /// </summary>
        public PauseServiceDelegate PauseService;

        /// <summary>
        /// WMI method <c>ResumeService</c>.
        /// </summary>
        public ResumeServiceDelegate ResumeService;

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c>.
        /// </summary>
        public SetSecurityDescriptorDelegate SetSecurityDescriptor;

        /// <summary>
        /// WMI method <c>StartService</c>.
        /// </summary>
        public StartServiceDelegate StartService;

        /// <summary>
        /// WMI method <c>StopService</c>.
        /// </summary>
        public StopServiceDelegate StopService;

        /// <summary>
        /// WMI method <c>UserControlService</c>.
        /// </summary>
        public UserControlServiceDelegate UserControlService;

        /// <summary>
        /// WMI Property AcceptPause
        /// </summary>
        public bool AcceptPause { get; set; }

        /// <summary>
        /// WMI Property AcceptStop
        /// </summary>
        public bool AcceptStop { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CheckPoint
        /// </summary>
        public uint CheckPoint { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property DelayedAutoStart
        /// </summary>
        public bool DelayedAutoStart { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DesktopInteract
        /// </summary>
        public bool DesktopInteract { get; set; }

        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// WMI Property ErrorControl
        /// </summary>
        public string ErrorControl { get; set; }

        /// <summary>
        /// WMI Property ExitCode
        /// </summary>
        public uint ExitCode { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PathName
        /// </summary>
        public string PathName { get; set; }

        /// <summary>
        /// WMI Property ProcessId
        /// </summary>
        public uint ProcessId { get; set; }

        /// <summary>
        /// WMI Property ServiceSpecificExitCode
        /// </summary>
        public uint ServiceSpecificExitCode { get; set; }

        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// WMI Property Started
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// WMI Property StartMode
        /// </summary>
        public string StartMode { get; set; }

        /// <summary>
        /// WMI Property StartName
        /// </summary>
        public string StartName { get; set; }

        /// <summary>
        /// WMI Property State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property TagId
        /// </summary>
        public uint TagId { get; set; }

        /// <summary>
        /// WMI Property WaitHint
        /// </summary>
        public uint WaitHint { get; set; }
    }
}