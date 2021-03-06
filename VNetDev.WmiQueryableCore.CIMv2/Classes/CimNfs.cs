using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_NFS
    /// </summary>
    [WmiClass(Name = "CIM_NFS")]
    public class CimNfs
    {
        /// <summary>
        /// WMI Property AttributeCaching
        /// </summary>
        public bool AttributeCaching { get; set; }

        /// <summary>
        /// WMI Property AttributeCachingForDirectoriesMax
        /// </summary>
        public ushort AttributeCachingForDirectoriesMax { get; set; }

        /// <summary>
        /// WMI Property AttributeCachingForDirectoriesMin
        /// </summary>
        public ushort AttributeCachingForDirectoriesMin { get; set; }

        /// <summary>
        /// WMI Property AttributeCachingForRegularFilesMax
        /// </summary>
        public ushort AttributeCachingForRegularFilesMax { get; set; }

        /// <summary>
        /// WMI Property AttributeCachingForRegularFilesMin
        /// </summary>
        public ushort AttributeCachingForRegularFilesMin { get; set; }

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
        /// WMI Property ForegroundMount
        /// </summary>
        public bool ForegroundMount { get; set; }

        /// <summary>
        /// WMI Property HardMount
        /// </summary>
        public bool HardMount { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Interrupt
        /// </summary>
        public bool Interrupt { get; set; }

        /// <summary>
        /// WMI Property MaxFileNameLength
        /// </summary>
        public uint MaxFileNameLength { get; set; }

        /// <summary>
        /// WMI Property MountFailureRetries
        /// </summary>
        public ushort MountFailureRetries { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ReadBufferSize
        /// </summary>
        public ulong ReadBufferSize { get; set; }

        /// <summary>
        /// WMI Property ReadOnly
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// WMI Property RetransmissionAttempts
        /// </summary>
        public ushort RetransmissionAttempts { get; set; }

        /// <summary>
        /// WMI Property RetransmissionTimeout
        /// </summary>
        public uint RetransmissionTimeout { get; set; }

        /// <summary>
        /// WMI Property Root
        /// </summary>
        public string Root { get; set; }

        /// <summary>
        /// WMI Property ServerCommunicationPort
        /// </summary>
        public uint ServerCommunicationPort { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property WriteBufferSize
        /// </summary>
        public ulong WriteBufferSize { get; set; }
    }
}