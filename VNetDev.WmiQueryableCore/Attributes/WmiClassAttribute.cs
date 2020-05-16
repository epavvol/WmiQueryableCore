using System;

namespace VNetDev.WmiQueryableCore.Attributes
{
    /// <summary>
    /// Attribute to set Class name in WMI backend
    /// </summary>
    public class WmiClassAttribute : Attribute
    {
        /// <summary>
        /// WMI Class name
        /// </summary>
        public string Name { get; set; }
    }
}