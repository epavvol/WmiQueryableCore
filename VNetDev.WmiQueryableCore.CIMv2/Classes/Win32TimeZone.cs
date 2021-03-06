using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_TimeZone
    /// </summary>
    [WmiClass(Name = "Win32_TimeZone")]
    public class Win32TimeZone
    {
        /// <summary>
        /// WMI Property Bias
        /// </summary>
        public int Bias { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property DaylightBias
        /// </summary>
        public int DaylightBias { get; set; }

        /// <summary>
        /// WMI Property DaylightDay
        /// </summary>
        public uint DaylightDay { get; set; }

        /// <summary>
        /// WMI Property DaylightDayOfWeek
        /// </summary>
        public byte DaylightDayOfWeek { get; set; }

        /// <summary>
        /// WMI Property DaylightHour
        /// </summary>
        public uint DaylightHour { get; set; }

        /// <summary>
        /// WMI Property DaylightMillisecond
        /// </summary>
        public uint DaylightMillisecond { get; set; }

        /// <summary>
        /// WMI Property DaylightMinute
        /// </summary>
        public uint DaylightMinute { get; set; }

        /// <summary>
        /// WMI Property DaylightMonth
        /// </summary>
        public uint DaylightMonth { get; set; }

        /// <summary>
        /// WMI Property DaylightName
        /// </summary>
        public string DaylightName { get; set; }

        /// <summary>
        /// WMI Property DaylightSecond
        /// </summary>
        public uint DaylightSecond { get; set; }

        /// <summary>
        /// WMI Property DaylightYear
        /// </summary>
        public uint DaylightYear { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property StandardBias
        /// </summary>
        public uint StandardBias { get; set; }

        /// <summary>
        /// WMI Property StandardDay
        /// </summary>
        public uint StandardDay { get; set; }

        /// <summary>
        /// WMI Property StandardDayOfWeek
        /// </summary>
        public byte StandardDayOfWeek { get; set; }

        /// <summary>
        /// WMI Property StandardHour
        /// </summary>
        public uint StandardHour { get; set; }

        /// <summary>
        /// WMI Property StandardMillisecond
        /// </summary>
        public uint StandardMillisecond { get; set; }

        /// <summary>
        /// WMI Property StandardMinute
        /// </summary>
        public uint StandardMinute { get; set; }

        /// <summary>
        /// WMI Property StandardMonth
        /// </summary>
        public uint StandardMonth { get; set; }

        /// <summary>
        /// WMI Property StandardName
        /// </summary>
        public string StandardName { get; set; }

        /// <summary>
        /// WMI Property StandardSecond
        /// </summary>
        public uint StandardSecond { get; set; }

        /// <summary>
        /// WMI Property StandardYear
        /// </summary>
        public uint StandardYear { get; set; }
    }
}