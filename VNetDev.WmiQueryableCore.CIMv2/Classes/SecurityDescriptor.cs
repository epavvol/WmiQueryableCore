using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: __SecurityDescriptor
    /// </summary>
    [WmiClass(Name = "__SecurityDescriptor")]
    public class SecurityDescriptor
    {
        /// <summary>
        /// WMI Property ControlFlags
        /// </summary>
        public uint ControlFlags { get; set; }

        /// <summary>
        /// WMI Property DACL
        /// </summary>
        public ICollection<object> Dacl { get; set; }

        /// <summary>
        /// WMI Property Group
        /// </summary>
        public object Group { get; set; }

        /// <summary>
        /// WMI Property Owner
        /// </summary>
        public object Owner { get; set; }

        /// <summary>
        /// WMI Property SACL
        /// </summary>
        public ICollection<object> Sacl { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }
    }
}