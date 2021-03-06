using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_UserProfile
    /// </summary>
    [WmiClass(Name = "Win32_UserProfile")]
    public class Win32UserProfile
    {
        /// <summary>
        /// WMI method <c>ChangeOwner</c> describing delegate.
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="newOwnerSid">WMI Property <c>NewOwnerSID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ChangeOwnerDelegate(uint flags = default, string newOwnerSid = default);

        /// <summary>
        /// WMI method <c>ChangeOwner</c>.
        /// </summary>
        public ChangeOwnerDelegate ChangeOwner;

        /// <summary>
        /// WMI Property AppDataRoaming
        /// </summary>
        public Win32FolderRedirectionHealth AppDataRoaming { get; set; }

        /// <summary>
        /// WMI Property Contacts
        /// </summary>
        public Win32FolderRedirectionHealth Contacts { get; set; }

        /// <summary>
        /// WMI Property Desktop
        /// </summary>
        public Win32FolderRedirectionHealth Desktop { get; set; }

        /// <summary>
        /// WMI Property Documents
        /// </summary>
        public Win32FolderRedirectionHealth Documents { get; set; }

        /// <summary>
        /// WMI Property Downloads
        /// </summary>
        public Win32FolderRedirectionHealth Downloads { get; set; }

        /// <summary>
        /// WMI Property Favorites
        /// </summary>
        public Win32FolderRedirectionHealth Favorites { get; set; }

        /// <summary>
        /// WMI Property HealthStatus
        /// </summary>
        public byte HealthStatus { get; set; }

        /// <summary>
        /// WMI Property LastAttemptedProfileDownloadTime
        /// </summary>
        public DateTime LastAttemptedProfileDownloadTime { get; set; }

        /// <summary>
        /// WMI Property LastAttemptedProfileUploadTime
        /// </summary>
        public DateTime LastAttemptedProfileUploadTime { get; set; }

        /// <summary>
        /// WMI Property LastBackgroundRegistryUploadTime
        /// </summary>
        public DateTime LastBackgroundRegistryUploadTime { get; set; }

        /// <summary>
        /// WMI Property LastDownloadTime
        /// </summary>
        public DateTime LastDownloadTime { get; set; }

        /// <summary>
        /// WMI Property LastUploadTime
        /// </summary>
        public DateTime LastUploadTime { get; set; }

        /// <summary>
        /// WMI Property LastUseTime
        /// </summary>
        public DateTime LastUseTime { get; set; }

        /// <summary>
        /// WMI Property Links
        /// </summary>
        public Win32FolderRedirectionHealth Links { get; set; }

        /// <summary>
        /// WMI Property Loaded
        /// </summary>
        public bool Loaded { get; set; }

        /// <summary>
        /// WMI Property LocalPath
        /// </summary>
        public string LocalPath { get; set; }

        /// <summary>
        /// WMI Property Music
        /// </summary>
        public Win32FolderRedirectionHealth Music { get; set; }

        /// <summary>
        /// WMI Property Pictures
        /// </summary>
        public Win32FolderRedirectionHealth Pictures { get; set; }

        /// <summary>
        /// WMI Property RefCount
        /// </summary>
        public uint RefCount { get; set; }

        /// <summary>
        /// WMI Property RoamingConfigured
        /// </summary>
        public bool RoamingConfigured { get; set; }

        /// <summary>
        /// WMI Property RoamingPath
        /// </summary>
        public string RoamingPath { get; set; }

        /// <summary>
        /// WMI Property RoamingPreference
        /// </summary>
        public bool RoamingPreference { get; set; }

        /// <summary>
        /// WMI Property SavedGames
        /// </summary>
        public Win32FolderRedirectionHealth SavedGames { get; set; }

        /// <summary>
        /// WMI Property Searches
        /// </summary>
        public Win32FolderRedirectionHealth Searches { get; set; }

        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// WMI Property Special
        /// </summary>
        public bool Special { get; set; }

        /// <summary>
        /// WMI Property StartMenu
        /// </summary>
        public Win32FolderRedirectionHealth StartMenu { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }

        /// <summary>
        /// WMI Property Videos
        /// </summary>
        public Win32FolderRedirectionHealth Videos { get; set; }
    }
}