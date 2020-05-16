using System;

namespace VNetDev.WmiQueryableCore.Attributes
{
    /// <summary>
    /// Attribute to set Property name in WMI backend
    /// </summary>
    public class WmiPropertyAttribute : Attribute
    {
        /// <summary>
        /// WMI property name
        /// </summary>
        public string Name { get; set; }
    }
}