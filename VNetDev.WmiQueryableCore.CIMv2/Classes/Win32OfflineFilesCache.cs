using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesCache
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesCache")]
    public class Win32OfflineFilesCache
    {
        /// <summary>
        /// WMI static method <c>DeleteItems</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="paths">WMI Property <c>Paths</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteItemsDelegate(WmiContext wmiContext, uint flags = default,
            ICollection<string> paths = default);

        /// <summary>
        /// WMI static method <c>Enable</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="enable">WMI Property <c>Enable</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableDelegate(WmiContext wmiContext, bool enable = default);

        /// <summary>
        /// WMI static method <c>Encrypt</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="encrypt">WMI Property <c>Encrypt</c> of type <c>bool</c>.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EncryptDelegate(WmiContext wmiContext, bool encrypt = default, uint flags = default);

        /// <summary>
        /// WMI static method <c>Pin</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deep">WMI Property <c>Deep</c> of type <c>bool</c>.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="paths">WMI Property <c>Paths</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint PinDelegate(WmiContext wmiContext, bool deep = default, uint flags = default,
            ICollection<string> paths = default);

        /// <summary>
        /// WMI static method <c>RenameItem</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="newPath">WMI Property <c>NewPath</c> of type <c>string</c>.</param>
        /// <param name="originalPath">WMI Property <c>OriginalPath</c> of type <c>string</c>.</param>
        /// <param name="replaceIfExists">WMI Property <c>ReplaceIfExists</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenameItemDelegate(WmiContext wmiContext, string newPath = default,
            string originalPath = default, bool replaceIfExists = default);

        /// <summary>
        /// WMI static method <c>RenameItemEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="newPath">WMI Property <c>NewPath</c> of type <c>string</c>.</param>
        /// <param name="originalPath">WMI Property <c>OriginalPath</c> of type <c>string</c>.</param>
        /// <param name="replaceIfExists">WMI Property <c>ReplaceIfExists</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenameItemExDelegate(WmiContext wmiContext, string newPath = default,
            string originalPath = default, bool replaceIfExists = default);

        /// <summary>
        /// WMI static method <c>SuspendRoot</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="path">WMI Property <c>Path</c> of type <c>string</c>.</param>
        /// <param name="suspend">WMI Property <c>Suspend</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SuspendRootDelegate(WmiContext wmiContext, string path = default, bool suspend = default);

        /// <summary>
        /// WMI static method <c>Synchronize</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="paths">WMI Property <c>Paths</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SynchronizeDelegate(WmiContext wmiContext, uint flags = default,
            ICollection<string> paths = default);

        /// <summary>
        /// WMI static method <c>TransitionOffline</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="force">WMI Property <c>Force</c> of type <c>bool</c>.</param>
        /// <param name="path">WMI Property <c>Path</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TransitionOfflineDelegate(WmiContext wmiContext, uint flags = default,
            bool force = default, string path = default);

        /// <summary>
        /// WMI static method <c>TransitionOnline</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="path">WMI Property <c>Path</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TransitionOnlineDelegate(WmiContext wmiContext, uint flags = default,
            string path = default);

        /// <summary>
        /// WMI static method <c>Unpin</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deep">WMI Property <c>Deep</c> of type <c>bool</c>.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <param name="paths">WMI Property <c>Paths</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UnpinDelegate(WmiContext wmiContext, bool deep = default, uint flags = default,
            ICollection<string> paths = default);

        /// <summary>
        /// WMI static method <c>Enable</c>.
        /// </summary>
        public static EnableDelegate Enable;

        /// <summary>
        /// WMI static method <c>RenameItem</c>.
        /// </summary>
        public static RenameItemDelegate RenameItem;

        /// <summary>
        /// WMI static method <c>RenameItemEx</c>.
        /// </summary>
        public static RenameItemExDelegate RenameItemEx;

        /// <summary>
        /// WMI static method <c>Synchronize</c>.
        /// </summary>
        public static SynchronizeDelegate Synchronize;

        /// <summary>
        /// WMI static method <c>Pin</c>.
        /// </summary>
        public static PinDelegate Pin;

        /// <summary>
        /// WMI static method <c>Unpin</c>.
        /// </summary>
        public static UnpinDelegate Unpin;

        /// <summary>
        /// WMI static method <c>DeleteItems</c>.
        /// </summary>
        public static DeleteItemsDelegate DeleteItems;

        /// <summary>
        /// WMI static method <c>Encrypt</c>.
        /// </summary>
        public static EncryptDelegate Encrypt;

        /// <summary>
        /// WMI static method <c>SuspendRoot</c>.
        /// </summary>
        public static SuspendRootDelegate SuspendRoot;

        /// <summary>
        /// WMI static method <c>TransitionOffline</c>.
        /// </summary>
        public static TransitionOfflineDelegate TransitionOffline;

        /// <summary>
        /// WMI static method <c>TransitionOnline</c>.
        /// </summary>
        public static TransitionOnlineDelegate TransitionOnline;

        /// <summary>
        /// WMI Property Active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }
    }
}