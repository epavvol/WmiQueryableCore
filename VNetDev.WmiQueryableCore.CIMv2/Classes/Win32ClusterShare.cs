using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ClusterShare
    /// </summary>
    [WmiClass(Name = "Win32_ClusterShare")]
    public class Win32ClusterShare
    {
        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="access">WMI Property <c>Access</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="maximumAllowed">WMI Property <c>MaximumAllowed</c> of type <c>uint</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="path">WMI Property <c>Path</c> of type <c>string</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, Win32SecurityDescriptor access = default,
            string description = default, uint maximumAllowed = default, string name = default,
            string password = default, string path = default, uint type = default);

        /// <summary>
        /// WMI method <c>Delete</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteDelegate();

        /// <summary>
        /// WMI method <c>GetAccessMask</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetAccessMaskDelegate();

        /// <summary>
        /// WMI method <c>SetShareInfo</c> describing delegate.
        /// <param name="access">WMI Property <c>Access</c> of type <c> Win32SecurityDescriptor</c>.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="maximumAllowed">WMI Property <c>MaximumAllowed</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetShareInfoDelegate(Win32SecurityDescriptor access = default,
            string description = default, uint maximumAllowed = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI method <c>Delete</c>.
        /// </summary>
        public DeleteDelegate Delete;

        /// <summary>
        /// WMI method <c>GetAccessMask</c>.
        /// </summary>
        public GetAccessMaskDelegate GetAccessMask;

        /// <summary>
        /// WMI method <c>SetShareInfo</c>.
        /// </summary>
        public SetShareInfoDelegate SetShareInfo;

        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }

        /// <summary>
        /// WMI Property AllowMaximum
        /// </summary>
        public bool AllowMaximum { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property MaximumAllowed
        /// </summary>
        public uint MaximumAllowed { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}