using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SecurityDescriptorHelper
    /// </summary>
    [WmiClass(Name = "Win32_SecurityDescriptorHelper")]
    public class Win32SecurityDescriptorHelper
    {
        /// <summary>
        /// WMI static method <c>BinarySDToSDDL</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="binarySd">WMI Property <c>BinarySD</c> of type <c>ICollection{byte}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint BinarySdToSddlDelegate(WmiContext wmiContext, ICollection<byte> binarySd = default);

        /// <summary>
        /// WMI static method <c>BinarySDToWin32SD</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="binarySd">WMI Property <c>BinarySD</c> of type <c>ICollection{byte}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint BinarySdToWin32sdDelegate(WmiContext wmiContext, ICollection<byte> binarySd = default);

        /// <summary>
        /// WMI static method <c>SDDLToBinarySD</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sddl">WMI Property <c>SDDL</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SddlToBinarySdDelegate(WmiContext wmiContext, string sddl = default);

        /// <summary>
        /// WMI static method <c>SDDLToWin32SD</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="sddl">WMI Property <c>SDDL</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SddlToWin32sdDelegate(WmiContext wmiContext, string sddl = default);

        /// <summary>
        /// WMI static method <c>Win32SDToBinarySD</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c> SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint Win32sdToBinarySdDelegate(WmiContext wmiContext, SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI static method <c>Win32SDToSDDL</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="descriptor">WMI Property <c>Descriptor</c> of type <c>SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint Win32sdToSddlDelegate(WmiContext wmiContext, SecurityDescriptor descriptor = default);

        /// <summary>
        /// WMI static method <c>Win32SDToSDDL</c>.
        /// </summary>
        public static Win32sdToSddlDelegate Win32sdToSddl;

        /// <summary>
        /// WMI static method <c>Win32SDToBinarySD</c>.
        /// </summary>
        public static Win32sdToBinarySdDelegate Win32sdToBinarySd;

        /// <summary>
        /// WMI static method <c>SDDLToWin32SD</c>.
        /// </summary>
        public static SddlToWin32sdDelegate SddlToWin32sd;

        /// <summary>
        /// WMI static method <c>SDDLToBinarySD</c>.
        /// </summary>
        public static SddlToBinarySdDelegate SddlToBinarySd;

        /// <summary>
        /// WMI static method <c>BinarySDToWin32SD</c>.
        /// </summary>
        public static BinarySdToWin32sdDelegate BinarySdToWin32sd;

        /// <summary>
        /// WMI static method <c>BinarySDToSDDL</c>.
        /// </summary>
        public static BinarySdToSddlDelegate BinarySdToSddl;
    }
}