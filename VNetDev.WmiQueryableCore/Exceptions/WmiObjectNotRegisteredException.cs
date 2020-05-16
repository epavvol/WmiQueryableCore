using System;

namespace VNetDev.WmiQueryableCore.Exceptions
{
    /// <summary>
    /// Thrown when used WMI object is not registered
    /// </summary>
    public class WmiObjectNotRegisteredException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiObjectNotRegisteredException()
        {
        }

        /// <summary>
        /// Constructor with message provided
        /// </summary>
        /// <param name="message">Error message</param>
        public WmiObjectNotRegisteredException(string message) : base(message)
        {
        }
    }
}