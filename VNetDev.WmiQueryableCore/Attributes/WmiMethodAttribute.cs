using System;

namespace VNetDev.WmiQueryableCore.Attributes
{
    /// <summary>
    /// Attribute to set Method name in WMI backend
    /// </summary>
    public class WmiMethodAttribute: Attribute
    {
        /// <summary>
        /// WMI method name
        /// </summary>
        public string Name { get; set; }
    }
}