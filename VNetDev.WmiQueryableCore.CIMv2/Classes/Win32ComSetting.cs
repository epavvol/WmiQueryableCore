using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_COMSetting
    /// </summary>
    [WmiClass(Name = "Win32_COMSetting")]
    public class Win32ComSetting
    {
        /// <summary>
        /// WMI Property AppID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// WMI Property AutoConvertToClsid
        /// </summary>
        public string AutoConvertToClsid { get; set; }

        /// <summary>
        /// WMI Property AutoTreatAsClsid
        /// </summary>
        public string AutoTreatAsClsid { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ComponentId
        /// </summary>
        public string ComponentId { get; set; }

        /// <summary>
        /// WMI Property Control
        /// </summary>
        public bool Control { get; set; }

        /// <summary>
        /// WMI Property DefaultIcon
        /// </summary>
        public string DefaultIcon { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InprocHandler
        /// </summary>
        public string InprocHandler { get; set; }

        /// <summary>
        /// WMI Property InprocHandler32
        /// </summary>
        public string InprocHandler32 { get; set; }

        /// <summary>
        /// WMI Property InprocServer
        /// </summary>
        public string InprocServer { get; set; }

        /// <summary>
        /// WMI Property InprocServer32
        /// </summary>
        public string InprocServer32 { get; set; }

        /// <summary>
        /// WMI Property Insertable
        /// </summary>
        public bool Insertable { get; set; }

        /// <summary>
        /// WMI Property JavaClass
        /// </summary>
        public bool JavaClass { get; set; }

        /// <summary>
        /// WMI Property LocalServer
        /// </summary>
        public string LocalServer { get; set; }

        /// <summary>
        /// WMI Property LocalServer32
        /// </summary>
        public string LocalServer32 { get; set; }

        /// <summary>
        /// WMI Property LongDisplayName
        /// </summary>
        public string LongDisplayName { get; set; }

        /// <summary>
        /// WMI Property ProgId
        /// </summary>
        public string ProgId { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property ShortDisplayName
        /// </summary>
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// WMI Property ThreadingModel
        /// </summary>
        public string ThreadingModel { get; set; }

        /// <summary>
        /// WMI Property ToolBoxBitmap32
        /// </summary>
        public string ToolBoxBitmap32 { get; set; }

        /// <summary>
        /// WMI Property TreatAsClsid
        /// </summary>
        public string TreatAsClsid { get; set; }

        /// <summary>
        /// WMI Property TypeLibraryId
        /// </summary>
        public string TypeLibraryId { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property VersionIndependentProgId
        /// </summary>
        public string VersionIndependentProgId { get; set; }
    }
}