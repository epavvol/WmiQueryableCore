using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CodecFile
    /// </summary>
    [WmiClass(Name = "Win32_CodecFile")]
    public class Win32CodecFile
    {
        /// <summary>
        /// WMI method <c>ChangeSecurityPermissions</c> describing delegate.
        /// <param name="option">WMI Property <c>Option</c> of type <c>uint</c>.</param>
        /// <param name="securityDescriptor">WMI Property <c>SecurityDescriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChangeSecurityPermissionsDelegate(uint option = default,
            Win32SecurityDescriptor securityDescriptor = default);

        /// <summary>
        /// WMI method <c>ChangeSecurityPermissionsEx</c> describing delegate.
        /// <param name="option">WMI Property <c>Option</c> of type <c>uint</c>.</param>
        /// <param name="recursive">WMI Property <c>Recursive</c> of type <c>bool</c>.</param>
        /// <param name="securityDescriptor">WMI Property <c>SecurityDescriptor</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChangeSecurityPermissionsExDelegate(uint option = default, bool recursive = default,
            Win32SecurityDescriptor securityDescriptor = default, string startFileName = default);

        /// <summary>
        /// WMI method <c>Compress</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CompressDelegate();

        /// <summary>
        /// WMI method <c>CompressEx</c> describing delegate.
        /// <param name="recursive">WMI Property <c>Recursive</c> of type <c>bool</c>.</param>
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CompressExDelegate(bool recursive = default, string startFileName = default);

        /// <summary>
        /// WMI method <c>Copy</c> describing delegate.
        /// <param name="fileName">WMI Property <c>FileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CopyDelegate(string fileName = default);

        /// <summary>
        /// WMI method <c>CopyEx</c> describing delegate.
        /// <param name="fileName">WMI Property <c>FileName</c> of type <c>string</c>.</param>
        /// <param name="recursive">WMI Property <c>Recursive</c> of type <c>bool</c>.</param>
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CopyExDelegate(string fileName = default, bool recursive = default,
            string startFileName = default);

        /// <summary>
        /// WMI method <c>Delete</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteDelegate();

        /// <summary>
        /// WMI method <c>DeleteEx</c> describing delegate.
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteExDelegate(string startFileName = default);

        /// <summary>
        /// WMI method <c>GetEffectivePermission</c> describing delegate.
        /// <param name="permissions">WMI Property <c>Permissions</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>bool</c>.</returns>
        /// </summary>
        public delegate bool GetEffectivePermissionDelegate(uint permissions = default);

        /// <summary>
        /// WMI method <c>Rename</c> describing delegate.
        /// <param name="fileName">WMI Property <c>FileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenameDelegate(string fileName = default);

        /// <summary>
        /// WMI method <c>TakeOwnerShip</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TakeOwnerShipDelegate();

        /// <summary>
        /// WMI method <c>TakeOwnerShipEx</c> describing delegate.
        /// <param name="recursive">WMI Property <c>Recursive</c> of type <c>bool</c>.</param>
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TakeOwnerShipExDelegate(bool recursive = default, string startFileName = default);

        /// <summary>
        /// WMI method <c>Uncompress</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UncompressDelegate();

        /// <summary>
        /// WMI method <c>UncompressEx</c> describing delegate.
        /// <param name="recursive">WMI Property <c>Recursive</c> of type <c>bool</c>.</param>
        /// <param name="startFileName">WMI Property <c>StartFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UncompressExDelegate(bool recursive = default, string startFileName = default);

        /// <summary>
        /// WMI method <c>ChangeSecurityPermissions</c>.
        /// </summary>
        public ChangeSecurityPermissionsDelegate ChangeSecurityPermissions;

        /// <summary>
        /// WMI method <c>ChangeSecurityPermissionsEx</c>.
        /// </summary>
        public ChangeSecurityPermissionsExDelegate ChangeSecurityPermissionsEx;

        /// <summary>
        /// WMI method <c>Compress</c>.
        /// </summary>
        public CompressDelegate Compress;

        /// <summary>
        /// WMI method <c>CompressEx</c>.
        /// </summary>
        public CompressExDelegate CompressEx;

        /// <summary>
        /// WMI method <c>Copy</c>.
        /// </summary>
        public CopyDelegate Copy;

        /// <summary>
        /// WMI method <c>CopyEx</c>.
        /// </summary>
        public CopyExDelegate CopyEx;

        /// <summary>
        /// WMI method <c>Delete</c>.
        /// </summary>
        public DeleteDelegate Delete;

        /// <summary>
        /// WMI method <c>DeleteEx</c>.
        /// </summary>
        public DeleteExDelegate DeleteEx;

        /// <summary>
        /// WMI method <c>GetEffectivePermission</c>.
        /// </summary>
        public GetEffectivePermissionDelegate GetEffectivePermission;

        /// <summary>
        /// WMI method <c>Rename</c>.
        /// </summary>
        public RenameDelegate Rename;

        /// <summary>
        /// WMI method <c>TakeOwnerShip</c>.
        /// </summary>
        public TakeOwnerShipDelegate TakeOwnerShip;

        /// <summary>
        /// WMI method <c>TakeOwnerShipEx</c>.
        /// </summary>
        public TakeOwnerShipExDelegate TakeOwnerShipEx;

        /// <summary>
        /// WMI method <c>Uncompress</c>.
        /// </summary>
        public UncompressDelegate Uncompress;

        /// <summary>
        /// WMI method <c>UncompressEx</c>.
        /// </summary>
        public UncompressExDelegate UncompressEx;

        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }

        /// <summary>
        /// WMI Property Archive
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Compressed
        /// </summary>
        public bool Compressed { get; set; }

        /// <summary>
        /// WMI Property CompressionMethod
        /// </summary>
        public string CompressionMethod { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }

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
        /// WMI Property Drive
        /// </summary>
        public string Drive { get; set; }

        /// <summary>
        /// WMI Property EightDotThreeFileName
        /// </summary>
        public string EightDotThreeFileName { get; set; }

        /// <summary>
        /// WMI Property Encrypted
        /// </summary>
        public bool Encrypted { get; set; }

        /// <summary>
        /// WMI Property EncryptionMethod
        /// </summary>
        public string EncryptionMethod { get; set; }

        /// <summary>
        /// WMI Property Extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public ulong FileSize { get; set; }

        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// WMI Property FSCreationClassName
        /// </summary>
        public string FsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property FSName
        /// </summary>
        public string FsName { get; set; }

        /// <summary>
        /// WMI Property Group
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// WMI Property Hidden
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InUseCount
        /// </summary>
        public ulong InUseCount { get; set; }

        /// <summary>
        /// WMI Property LastAccessed
        /// </summary>
        public DateTime LastAccessed { get; set; }

        /// <summary>
        /// WMI Property LastModified
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// WMI Property Readable
        /// </summary>
        public bool Readable { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property System
        /// </summary>
        public bool System { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property Writeable
        /// </summary>
        public bool Writeable { get; set; }
    }
}