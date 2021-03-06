using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FileSystem
    /// </summary>
    [WmiClass(Name = "CIM_FileSystem")]
    public class CimFileSystem
    {
        /// <summary>
        /// WMI Property AvailableSpace
        /// </summary>
        public ulong AvailableSpace { get; set; }

        /// <summary>
        /// WMI Property BlockSize
        /// </summary>
        public ulong BlockSize { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CasePreserved
        /// </summary>
        public bool CasePreserved { get; set; }

        /// <summary>
        /// WMI Property CaseSensitive
        /// </summary>
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// WMI Property CodeSet
        /// </summary>
        public ICollection<ushort> CodeSet { get; set; }

        /// <summary>
        /// WMI Property CompressionMethod
        /// </summary>
        public string CompressionMethod { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSCreationClassName
        /// </summary>
        public string CsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSName
        /// </summary>
        public string CsName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property EncryptionMethod
        /// </summary>
        public string EncryptionMethod { get; set; }

        /// <summary>
        /// WMI Property FileSystemSize
        /// </summary>
        public ulong FileSystemSize { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property MaxFileNameLength
        /// </summary>
        public uint MaxFileNameLength { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ReadOnly
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// WMI Property Root
        /// </summary>
        public string Root { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}