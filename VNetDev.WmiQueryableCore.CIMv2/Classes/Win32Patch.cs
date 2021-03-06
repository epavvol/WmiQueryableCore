using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Patch
    /// </summary>
    [WmiClass(Name = "Win32_Patch")]
    public class Win32Patch
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public ushort Attributes { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property File
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// WMI Property PatchSize
        /// </summary>
        public uint PatchSize { get; set; }

        /// <summary>
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// WMI Property Sequence
        /// </summary>
        public short Sequence { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
    }
}