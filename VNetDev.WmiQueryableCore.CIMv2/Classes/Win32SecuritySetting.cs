using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SecuritySetting
    /// </summary>
    [WmiClass(Name = "Win32_SecuritySetting")]
    public class Win32SecuritySetting
    {
        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetSecurityDescriptorDelegate();

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c> describing delegate.
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetSecurityDescriptorDelegate(Win32SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI method <c>GetSecurityDescriptor</c>.
        /// </summary>
        public GetSecurityDescriptorDelegate GetSecurityDescriptor;

        /// <summary>
        /// WMI method <c>SetSecurityDescriptor</c>.
        /// </summary>
        public SetSecurityDescriptorDelegate SetSecurityDescriptor;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ControlFlags
        /// </summary>
        public uint ControlFlags { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
    }
}