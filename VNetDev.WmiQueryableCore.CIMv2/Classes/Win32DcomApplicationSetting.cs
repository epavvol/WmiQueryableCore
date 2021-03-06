using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DCOMApplicationSetting
    /// </summary>
    [WmiClass(Name = "Win32_DCOMApplicationSetting")]
    public class Win32DcomApplicationSetting
    {
        /// <summary>
        /// WMI method <c>GetAccessSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetAccessSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>GetConfigurationSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetConfigurationSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>GetLaunchSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetLaunchSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>SetAccessSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetAccessSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI method <c>SetConfigurationSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetConfigurationSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI method <c>SetLaunchSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetLaunchSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI method <c>GetAccessSecurityDescriptor</c>.
        /// </summary>
        public GetAccessSecurityDescriptorDelegate GetAccessSecurityDescriptor;

        /// <summary>
        /// WMI method <c>GetConfigurationSecurityDescriptor</c>.
        /// </summary>
        public GetConfigurationSecurityDescriptorDelegate GetConfigurationSecurityDescriptor;

        /// <summary>
        /// WMI method <c>GetLaunchSecurityDescriptor</c>.
        /// </summary>
        public GetLaunchSecurityDescriptorDelegate GetLaunchSecurityDescriptor;

        /// <summary>
        /// WMI method <c>SetAccessSecurityDescriptor</c>.
        /// </summary>
        public SetAccessSecurityDescriptorDelegate SetAccessSecurityDescriptor;

        /// <summary>
        /// WMI method <c>SetConfigurationSecurityDescriptor</c>.
        /// </summary>
        public SetConfigurationSecurityDescriptorDelegate SetConfigurationSecurityDescriptor;

        /// <summary>
        /// WMI method <c>SetLaunchSecurityDescriptor</c>.
        /// </summary>
        public SetLaunchSecurityDescriptorDelegate SetLaunchSecurityDescriptor;

        /// <summary>
        /// WMI Property AppID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// WMI Property AuthenticationLevel
        /// </summary>
        public uint AuthenticationLevel { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CustomSurrogate
        /// </summary>
        public string CustomSurrogate { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property EnableAtStorageActivation
        /// </summary>
        public bool EnableAtStorageActivation { get; set; }

        /// <summary>
        /// WMI Property LocalService
        /// </summary>
        public string LocalService { get; set; }

        /// <summary>
        /// WMI Property RemoteServerName
        /// </summary>
        public string RemoteServerName { get; set; }

        /// <summary>
        /// WMI Property RunAsUser
        /// </summary>
        public string RunAsUser { get; set; }

        /// <summary>
        /// WMI Property ServiceParameters
        /// </summary>
        public string ServiceParameters { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property UseSurrogate
        /// </summary>
        public bool UseSurrogate { get; set; }
    }
}