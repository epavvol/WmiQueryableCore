using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_IniFileSpecification
    /// </summary>
    [WmiClass(Name = "Win32_IniFileSpecification")]
    public class Win32IniFileSpecification
    {
        /// <summary>
        /// WMI method <c>Invoke</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint InvokeDelegate();

        /// <summary>
        /// WMI method <c>Invoke</c>.
        /// </summary>
        public InvokeDelegate Invoke;

        /// <summary>
        /// WMI Property Action
        /// </summary>
        public ushort Action { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CheckID
        /// </summary>
        public string CheckId { get; set; }

        /// <summary>
        /// WMI Property CheckMode
        /// </summary>
        public bool CheckMode { get; set; }

        /// <summary>
        /// WMI Property CheckSum
        /// </summary>
        public uint CheckSum { get; set; }

        /// <summary>
        /// WMI Property CRC1
        /// </summary>
        public uint Crc1 { get; set; }

        /// <summary>
        /// WMI Property CRC2
        /// </summary>
        public uint Crc2 { get; set; }

        /// <summary>
        /// WMI Property CreateTimeStamp
        /// </summary>
        public DateTime CreateTimeStamp { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public ulong FileSize { get; set; }

        /// <summary>
        /// WMI Property IniFile
        /// </summary>
        public string IniFile { get; set; }

        /// <summary>
        /// WMI Property key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// WMI Property MD5Checksum
        /// </summary>
        public string Md5Checksum { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Section
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementID
        /// </summary>
        public string SoftwareElementId { get; set; }

        /// <summary>
        /// WMI Property SoftwareElementState
        /// </summary>
        public ushort SoftwareElementState { get; set; }

        /// <summary>
        /// WMI Property TargetOperatingSystem
        /// </summary>
        public ushort TargetOperatingSystem { get; set; }

        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}