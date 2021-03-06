using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_FolderRedirectionUserConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_FolderRedirectionUserConfiguration")]
    public class Win32FolderRedirectionUserConfiguration
    {
        /// <summary>
        /// WMI Property AppDataRoaming
        /// </summary>
        public object AppDataRoaming { get; set; }

        /// <summary>
        /// WMI Property Contacts
        /// </summary>
        public object Contacts { get; set; }

        /// <summary>
        /// WMI Property Desktop
        /// </summary>
        public object Desktop { get; set; }

        /// <summary>
        /// WMI Property Documents
        /// </summary>
        public object Documents { get; set; }

        /// <summary>
        /// WMI Property Downloads
        /// </summary>
        public object Downloads { get; set; }

        /// <summary>
        /// WMI Property Favorites
        /// </summary>
        public object Favorites { get; set; }

        /// <summary>
        /// WMI Property IsConfiguredByWMI
        /// </summary>
        public bool IsConfiguredByWmi { get; set; }

        /// <summary>
        /// WMI Property Links
        /// </summary>
        public object Links { get; set; }

        /// <summary>
        /// WMI Property Music
        /// </summary>
        public object Music { get; set; }

        /// <summary>
        /// WMI Property Pictures
        /// </summary>
        public object Pictures { get; set; }

        /// <summary>
        /// WMI Property PrimaryComputerEnabled
        /// </summary>
        public bool PrimaryComputerEnabled { get; set; }

        /// <summary>
        /// WMI Property SavedGames
        /// </summary>
        public object SavedGames { get; set; }

        /// <summary>
        /// WMI Property Searches
        /// </summary>
        public object Searches { get; set; }

        /// <summary>
        /// WMI Property StartMenu
        /// </summary>
        public object StartMenu { get; set; }

        /// <summary>
        /// WMI Property Videos
        /// </summary>
        public object Videos { get; set; }
    }
}