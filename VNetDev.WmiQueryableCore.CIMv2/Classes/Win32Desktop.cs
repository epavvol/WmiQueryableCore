using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Desktop
    /// </summary>
    [WmiClass(Name = "Win32_Desktop")]
    public class Win32Desktop
    {
        /// <summary>
        /// WMI Property BorderWidth
        /// </summary>
        public uint BorderWidth { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CoolSwitch
        /// </summary>
        public bool CoolSwitch { get; set; }

        /// <summary>
        /// WMI Property CursorBlinkRate
        /// </summary>
        public uint CursorBlinkRate { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DragFullWindows
        /// </summary>
        public bool DragFullWindows { get; set; }

        /// <summary>
        /// WMI Property GridGranularity
        /// </summary>
        public uint GridGranularity { get; set; }

        /// <summary>
        /// WMI Property IconSpacing
        /// </summary>
        public uint IconSpacing { get; set; }

        /// <summary>
        /// WMI Property IconTitleFaceName
        /// </summary>
        public string IconTitleFaceName { get; set; }

        /// <summary>
        /// WMI Property IconTitleSize
        /// </summary>
        public uint IconTitleSize { get; set; }

        /// <summary>
        /// WMI Property IconTitleWrap
        /// </summary>
        public bool IconTitleWrap { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Pattern
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// WMI Property ScreenSaverActive
        /// </summary>
        public bool ScreenSaverActive { get; set; }

        /// <summary>
        /// WMI Property ScreenSaverExecutable
        /// </summary>
        public string ScreenSaverExecutable { get; set; }

        /// <summary>
        /// WMI Property ScreenSaverSecure
        /// </summary>
        public bool ScreenSaverSecure { get; set; }

        /// <summary>
        /// WMI Property ScreenSaverTimeout
        /// </summary>
        public uint ScreenSaverTimeout { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property Wallpaper
        /// </summary>
        public string Wallpaper { get; set; }

        /// <summary>
        /// WMI Property WallpaperStretched
        /// </summary>
        public bool WallpaperStretched { get; set; }

        /// <summary>
        /// WMI Property WallpaperTiled
        /// </summary>
        public bool WallpaperTiled { get; set; }
    }
}