using VNetDev.WmiQueryableCore.Contracts;

namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Context Options abstract class
    /// </summary>
    public abstract class WmiContextOptions
    {
        /// <summary>
        /// Connection description
        /// </summary>
        public string OptionsComment { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        protected WmiContextOptions()
        {

        }

        /// <summary>
        /// WMI Connection
        /// </summary>
        public IWmiConnection Connection { get; set; }
    }
}