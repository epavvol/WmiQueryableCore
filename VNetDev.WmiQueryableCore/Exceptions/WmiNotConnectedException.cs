using System;

namespace VNetDev.WmiQueryableCore.Exceptions
{
    /// <summary>
    /// Thrown when used WMI connection was not established
    /// </summary>
    public class WmiNotConnectedException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiNotConnectedException()
        {
        }

        /// <summary>
        /// Constructor with message provided
        /// </summary>
        /// <param name="message">Error message</param>
        public WmiNotConnectedException(string message) : base(message)
        {
        }
    }
}