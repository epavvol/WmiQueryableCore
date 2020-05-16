using System;

namespace VNetDev.WmiQueryableCore.Exceptions
{
    /// <summary>
    /// Thrown when WMI context tried to be reassigned
    /// </summary>
    public class WmiContextReassignmentException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiContextReassignmentException()
        {
        }

        /// <summary>
        /// Constructor with message provided
        /// </summary>
        /// <param name="message">Error message</param>
        public WmiContextReassignmentException(string message) : base(message)
        {
        }
    }
}