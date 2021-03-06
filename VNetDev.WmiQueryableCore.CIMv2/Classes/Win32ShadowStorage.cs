using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShadowStorage
    /// </summary>
    [WmiClass(Name = "Win32_ShadowStorage")]
    public class Win32ShadowStorage
    {
        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="diffVolume">WMI Property <c>DiffVolume</c> of type <c>string</c>.</param>
        /// <param name="maxSpace">WMI Property <c>MaxSpace</c> of type <c>ulong</c>.</param>
        /// <param name="volume">WMI Property <c>Volume</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, string diffVolume = default,
            ulong maxSpace = default, string volume = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI Property AllocatedSpace
        /// </summary>
        public ulong AllocatedSpace { get; set; }

        /// <summary>
        /// WMI Property DiffVolume
        /// </summary>
        public object DiffVolume { get; set; }

        /// <summary>
        /// WMI Property MaxSpace
        /// </summary>
        public ulong MaxSpace { get; set; }

        /// <summary>
        /// WMI Property UsedSpace
        /// </summary>
        public ulong UsedSpace { get; set; }

        /// <summary>
        /// WMI Property Volume
        /// </summary>
        public object Volume { get; set; }
    }
}