using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Product
    /// </summary>
    [WmiClass(Name = "Win32_Product")]
    public class Win32Product
    {
        /// <summary>
        /// WMI static method <c>Admin</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="options">WMI Property <c>Options</c> of type <c>string</c>.</param>
        /// <param name="packageLocation">WMI Property <c>PackageLocation</c> of type <c>string</c>.</param>
        /// <param name="targetLocation">WMI Property <c>TargetLocation</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AdminDelegate(WmiContext wmiContext, string options = default,
            string packageLocation = default, string targetLocation = default);

        /// <summary>
        /// WMI static method <c>Advertise</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="allUsers">WMI Property <c>AllUsers</c> of type <c>bool</c>.</param>
        /// <param name="options">WMI Property <c>Options</c> of type <c>string</c>.</param>
        /// <param name="packageLocation">WMI Property <c>PackageLocation</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AdvertiseDelegate(WmiContext wmiContext, bool allUsers = default, string options = default,
            string packageLocation = default);

        /// <summary>
        /// WMI method <c>Configure</c> describing delegate.
        /// <param name="installLevel">WMI Property <c>InstallLevel</c> of type <c>ushort</c>.</param>
        /// <param name="installState">WMI Property <c>InstallState</c> of type <c>ushort</c>.</param>
        /// <param name="options">WMI Property <c>Options</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ConfigureDelegate(ushort installLevel = default, ushort installState = default,
            string options = default);

        /// <summary>
        /// WMI static method <c>Install</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="allUsers">WMI Property <c>AllUsers</c> of type <c>bool</c>.</param>
        /// <param name="options">WMI Property <c>Options</c> of type <c>string</c>.</param>
        /// <param name="packageLocation">WMI Property <c>PackageLocation</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint InstallDelegate(WmiContext wmiContext, bool allUsers = default, string options = default,
            string packageLocation = default);

        /// <summary>
        /// WMI method <c>Reinstall</c> describing delegate.
        /// <param name="reinstallMode">WMI Property <c>ReinstallMode</c> of type <c>ushort</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ReinstallDelegate(ushort reinstallMode = default);

        /// <summary>
        /// WMI method <c>Uninstall</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UninstallDelegate();

        /// <summary>
        /// WMI method <c>Upgrade</c> describing delegate.
        /// <param name="options">WMI Property <c>Options</c> of type <c>string</c>.</param>
        /// <param name="packageLocation">WMI Property <c>PackageLocation</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UpgradeDelegate(string options = default, string packageLocation = default);

        /// <summary>
        /// WMI static method <c>Install</c>.
        /// </summary>
        public static InstallDelegate Install;

        /// <summary>
        /// WMI static method <c>Admin</c>.
        /// </summary>
        public static AdminDelegate Admin;

        /// <summary>
        /// WMI static method <c>Advertise</c>.
        /// </summary>
        public static AdvertiseDelegate Advertise;

        /// <summary>
        /// WMI method <c>Configure</c>.
        /// </summary>
        public ConfigureDelegate Configure;

        /// <summary>
        /// WMI method <c>Reinstall</c>.
        /// </summary>
        public ReinstallDelegate Reinstall;

        /// <summary>
        /// WMI method <c>Uninstall</c>.
        /// </summary>
        public UninstallDelegate Uninstall;

        /// <summary>
        /// WMI method <c>Upgrade</c>.
        /// </summary>
        public UpgradeDelegate Upgrade;

        /// <summary>
        /// WMI Property AssignmentType
        /// </summary>
        public ushort AssignmentType { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property HelpLink
        /// </summary>
        public string HelpLink { get; set; }

        /// <summary>
        /// WMI Property HelpTelephone
        /// </summary>
        public string HelpTelephone { get; set; }

        /// <summary>
        /// WMI Property IdentifyingNumber
        /// </summary>
        public string IdentifyingNumber { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public string InstallDate { get; set; }

        /// <summary>
        /// WMI Property InstallDate2
        /// </summary>
        public DateTime InstallDate2 { get; set; }

        /// <summary>
        /// WMI Property InstallLocation
        /// </summary>
        public string InstallLocation { get; set; }

        /// <summary>
        /// WMI Property InstallSource
        /// </summary>
        public string InstallSource { get; set; }

        /// <summary>
        /// WMI Property InstallState
        /// </summary>
        public short InstallState { get; set; }

        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// WMI Property LocalPackage
        /// </summary>
        public string LocalPackage { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PackageCache
        /// </summary>
        public string PackageCache { get; set; }

        /// <summary>
        /// WMI Property PackageCode
        /// </summary>
        public string PackageCode { get; set; }

        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// WMI Property ProductID
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// WMI Property RegCompany
        /// </summary>
        public string RegCompany { get; set; }

        /// <summary>
        /// WMI Property RegOwner
        /// </summary>
        public string RegOwner { get; set; }

        /// <summary>
        /// WMI Property SKUNumber
        /// </summary>
        public string SkuNumber { get; set; }

        /// <summary>
        /// WMI Property Transforms
        /// </summary>
        public string Transforms { get; set; }

        /// <summary>
        /// WMI Property URLInfoAbout
        /// </summary>
        public string UrlInfoAbout { get; set; }

        /// <summary>
        /// WMI Property URLUpdateInfo
        /// </summary>
        public string UrlUpdateInfo { get; set; }

        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property WordCount
        /// </summary>
        public uint WordCount { get; set; }
    }
}