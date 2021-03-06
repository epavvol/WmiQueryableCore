using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DESKTOP
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DESKTOP")]
    public class SmsGSystemDesktop
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
        public uint CoolSwitch { get; set; }
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
        public uint DragFullWindows { get; set; }
        /// <summary>
        /// WMI Property GridGranularity
        /// </summary>
        public uint GridGranularity { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
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
        public uint IconTitleWrap { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Pattern
        /// </summary>
        public string Pattern { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property ScreenSaverActive
        /// </summary>
        public uint ScreenSaverActive { get; set; }
        /// <summary>
        /// WMI Property ScreenSaverExecutable
        /// </summary>
        public string ScreenSaverExecutable { get; set; }
        /// <summary>
        /// WMI Property ScreenSaverSecure
        /// </summary>
        public uint ScreenSaverSecure { get; set; }
        /// <summary>
        /// WMI Property ScreenSaverTimeout
        /// </summary>
        public uint ScreenSaverTimeout { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Wallpaper
        /// </summary>
        public string Wallpaper { get; set; }
        /// <summary>
        /// WMI Property WallpaperStretched
        /// </summary>
        public uint WallpaperStretched { get; set; }
        /// <summary>
        /// WMI Property WallpaperTiled
        /// </summary>
        public uint WallpaperTiled { get; set; }
    }
}
